using System;
using System.Drawing;
using MonoTouch.CoreAnimation;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using ECSlidingViewControllerLib;

namespace ECSlidingViewControllerDemo
{
	internal class SlidingAnimationController : UIViewControllerAnimatedTransitioning
	{
		//___________________________________________________________________________________________________

		private const double AnimationDuration = 0.25;
		private const float  M_PI_2            = (float)(Math.PI / 2);

		public delegate void CoordinatorAnimationsHandler(IUIViewControllerContextTransitioning context);
		public delegate void CoordinatorCompletionHandler(IUIViewControllerContextTransitioning context);

		public event CoordinatorAnimationsHandler CoordinatorAnimations;
		public event CoordinatorCompletionHandler CoordinatorCompletion;

		public SlidingViewController SlidingViewController
		{ get; set; }

		//___________________________________________________________________________________________________

		public override double TransitionDuration (IUIViewControllerContextTransitioning transitionContext)
		{
			return AnimationDuration;
		}

		public override void AnimateTransition (IUIViewControllerContextTransitioning transitionCtx)
		{
			SlidingViewController sliding = this.SlidingViewController;
			// Get constant from uikit
			IntPtr handle = Dlfcn.dlopen(MonoTouch.Constants.UIKitLibrary, 0);
			NSString UITransitionContextToViewControllerKey = Dlfcn.GetStringConstant(handle, "UITransitionContextToViewControllerKey");
			Dlfcn.dlclose(handle);
			// Get controllers
			UIViewController topController = sliding.GetViewControllerForKey(ECSlidingViewController.ECTransitionContextTopViewControllerKey);
			UIViewController toController  = sliding.GetViewControllerForKey(UITransitionContextToViewControllerKey);
			RectangleF topViewInitialFrame = sliding.GetInitialFrameForViewController(topController);
			RectangleF topViewFinalFrame   = sliding.GetFinalFrameForViewController(topController);
			// Update top view frame
			topController.View.Frame = topViewInitialFrame;
			// Reset layer transforms
			CATransform3D transform = CATransform3D.Identity;
			transform.m34 = -0.002f;
			sliding.ContainerView.Layer.SublayerTransform = transform;

			UIViewController underController;
			float revealWidth = 0f;
			bool  resetting   = false;

			if (topController == toController)
			{
				underController = sliding.GetViewControllerForKey(ECSlidingViewController.ECTransitionContextUnderLeftControllerKey);
				revealWidth     = sliding.GetInitialFrameForViewController(topController).X;
				resetting       = true;
			} else {
				underController = sliding.GetViewControllerForKey(UITransitionContextToViewControllerKey);
				revealWidth     = sliding.GetFinalFrameForViewController(topController).X;
				resetting       = false;
			}

			RectangleF underViewInitialFrame = sliding.GetInitialFrameForViewController(underController);
			RectangleF underViewFinalFrame   = sliding.GetFinalFrameForViewController(underController);
			underController.View.Frame       = underViewInitialFrame.IsEmpty ? underViewFinalFrame : underViewInitialFrame;
			underController.View.RemoveFromSuperview();

			float underViewHalfwayPoint = revealWidth / 2;
			RectangleF leftSideFrame    = new RectangleF(0, 0, underViewHalfwayPoint, underController.View.Bounds.Height);
			RectangleF rightSideFrame   = new RectangleF(underViewHalfwayPoint, 0, underViewHalfwayPoint, underController.View.Bounds.Height);

			UIView leftSideView  = underController.View.ResizableSnapshotView(leftSideFrame,  true, UIEdgeInsets.Zero);
			UIView rightSideView = underController.View.ResizableSnapshotView(rightSideFrame, true, UIEdgeInsets.Zero);

			leftSideView.Layer.AnchorPoint = new PointF(0f, 0.5f);
			leftSideView.Frame             = leftSideFrame;

			rightSideView.Layer.Frame       = rightSideFrame;
			rightSideView.Layer.AnchorPoint = new PointF(1F, 0F);

			if (resetting) this.UnfoldLayers(leftSideView.Layer, rightSideView.Layer);
			else           this.FoldLayers  (leftSideView.Layer, rightSideView.Layer);

			sliding.ContainerView.Layer.InsertSublayerBelow(leftSideView.Layer,  topController.View.Layer);
			sliding.ContainerView.Layer.InsertSublayerBelow(rightSideView.Layer, topController.View.Layer);

			// Animate panel
			UIView.Animate(
				this.TransitionDuration(transitionCtx),
				new NSAction(
					delegate()
					{
						UIView.SetAnimationCurve(UIViewAnimationCurve.Linear);
						if (this.CoordinatorAnimations != null) this.CoordinatorAnimations(transitionCtx);
						topController.View.Frame = topViewFinalFrame;

						if (resetting)
						{
							this.FoldLayers(leftSideView.Layer, rightSideView.Layer);
						}
						else
						{
							this.UnfoldLayers(leftSideView.Layer, rightSideView.Layer);
						}
					}
				),
				new NSAction(
					delegate()
					{
						sliding.ContainerView.Layer.SublayerTransform = CATransform3D.Identity;
						leftSideView.RemoveFromSuperview();
						rightSideView.RemoveFromSuperview();

						bool topViewReset = (resetting && !sliding.TransitionWasCancelled) || (!resetting && sliding.TransitionWasCancelled);
						topController.View.Frame = sliding.TransitionWasCancelled ? sliding.GetInitialFrameForViewController(topController) : sliding.GetFinalFrameForViewController(topController);

						if (topViewReset)
						{
							underController.View.RemoveFromSuperview();
						}
						else
						{
							underController.View.Frame = sliding.TransitionWasCancelled ? sliding.GetInitialFrameForViewController(underController) : sliding.GetFinalFrameForViewController(underController);
							sliding.ContainerView.InsertSubviewBelow(underController.View, topController.View);
						}

						if (this.CoordinatorCompletion != null) this.CoordinatorCompletion(transitionCtx);
						sliding.CompleteTransition(true);
					}
				)
			);
		}

		//___________________________________________________________________________________________________

		private void FoldLayers (CALayer leftSide, CALayer rightSide)
		{
			leftSide.Transform  = CATransform3D.MakeRotation(M_PI_2, 0f, 1f, 0f);
			rightSide.Position  = new PointF(0, 0);
			rightSide.Transform = CATransform3D.MakeRotation(-M_PI_2, 0f, 1f, 0f);
		}

		private void UnfoldLayers (CALayer leftSide, CALayer rightSide)
		{
			leftSide.Transform  = CATransform3D.MakeRotation(0f, 0f, 1f, 0f);
			rightSide.Position  = new PointF(rightSide.Bounds.Width * 2, 0);
			rightSide.Transform = CATransform3D.MakeRotation(0f, 0f, 1f, 0f);
		}
	}
}

