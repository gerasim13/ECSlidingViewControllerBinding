using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using ECSlidingViewControllerLib;

namespace ECSlidingViewControllerDemo
{
	[Adopts   ("UIViewControllerInteractiveTransitioning")]
	[Adopts   ("UIDynamicAnimatorDelegate")]
	[Adopts   ("ECSlidingViewControllerDelegate")]
	[Register ("SlidingTransition")]
	internal class SlidingTransition : NSObject
	{
		//___________________________________________________________________________________________________
		#region Structs & Enums
		//___________________________________________________________________________________________________

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region Lifecycle
		//___________________________________________________________________________________________________

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region Properties
		//___________________________________________________________________________________________________

		internal delegate void PanGestureHandler(UIPanGestureRecognizer gesture);
		internal delegate void TapGestureHandler(UITapGestureRecognizer gesture);

		internal event PanGestureHandler PanGestureEvent;
		internal event TapGestureHandler TapGestureEvent;

		//___________________________________________________________________________________________________

		private bool  _interactive;
		private bool  _positiveLeftToRight;
		private bool  _panningRight;
		private float _fullWidth;

		private RectangleF _initialTopViewFrame;

		//___________________________________________________________________________________________________

		private List<float> _leftEdgeQueue;
		private List<float> LeftEdgeQueue
		{
			get
			{
				if (_leftEdgeQueue == null) _leftEdgeQueue = new List<float>(5);
				return _leftEdgeQueue;
			}
		}

		private UIDynamicAnimator _animator;
		private UIDynamicAnimator Animator
		{
			get
			{
				if (_animator == null)
				{
					_animator = new UIDynamicAnimator(this.SlidingViewController.View);
					_animator.WeakDelegate = this;
					_animator.UpdateItemUsingCurrentState(this.SlidingViewController.TopViewController.View);
				}
				return _animator;
			}
		}

		private UICollisionBehavior _collision;
		private UICollisionBehavior Collision
		{
			get
			{
				if (_collision == null)
				{
					_collision = new UICollisionBehavior(new IUIDynamicItem[] { this.SlidingViewController.TopViewController.View });

					float containerHeight = this.SlidingViewController.View.Bounds.Height;
					float containerWidth  = this.SlidingViewController.View.Bounds.Width;
					float revealAmount    = this.SlidingViewController.AnchorRightRevealAmount;

					_collision.AddBoundary(
						new NSString("LeftEdge"),
						new PointF(-1f, 0f),
						new PointF(-1f, containerHeight)
					);
					_collision.AddBoundary(
						new NSString("RightEdge"),
						new PointF(revealAmount + containerWidth + 1, 0f),
						new PointF(revealAmount + containerWidth + 1, containerHeight)
					);
				}
				return _collision;
			}
		}

		private UIGravityBehavior _gravity;
		private UIGravityBehavior Gravity
		{
			get
			{
				if (_gravity == null) _gravity = new UIGravityBehavior(new IUIDynamicItem[] { this.SlidingViewController.TopViewController.View });
				return _gravity;
			}
		}

		private UIPushBehavior _push;
		private UIPushBehavior Push
		{
			get
			{
				if (_push == null) _push = new UIPushBehavior(new IUIDynamicItem[] { this.SlidingViewController.TopViewController.View }, UIPushBehaviorMode.Instantaneous);
				return _push;
			}
		}

		private UIDynamicItemBehavior _topView;
		private UIDynamicItemBehavior TopView
		{
			get
			{
				if (_topView == null)
				{
					_topView = new UIDynamicItemBehavior(new IUIDynamicItem[] { this.SlidingViewController.TopViewController.View });
					// The density ranges from 1 to 5 for iPad to iPhone
					_topView.Density    = 908800 / (this.SlidingViewController.TopViewController.View.Bounds.Width * this.SlidingViewController.TopViewController.View.Bounds.Height);
					_topView.Elasticity = 0;
					_topView.Resistance = 1;
				}
				return _topView;
			}
		}

		private UIDynamicBehavior _composite;
		private UIDynamicBehavior Composite
		{
			get
			{
				if (_composite == null)
				{
					_composite = new UIDynamicBehavior();
					// Add child behaviors
					_composite.AddChildBehavior(this.Collision);
					_composite.AddChildBehavior(this.Gravity);
					_composite.AddChildBehavior(this.Push);
					_composite.AddChildBehavior(this.TopView);

					_composite.Action = delegate()
					{
						// Stop the dynamic animation when the value of the left edge is the same 5 times in a row.
						this.LeftEdgeQueue.Insert(0, this.SlidingViewController.TopViewController.View.Frame.X);
						if (this.LeftEdgeQueue.Count == 6)
						{
							this.LeftEdgeQueue.RemoveAt (this.LeftEdgeQueue.Count - 1);
						}
						if (this.LeftEdgeQueue.Count == 5 && this.LeftEdgeQueue.Distinct().Count() == 1)
						{
							this.Animator.RemoveAllBehaviors();
						}
					};
				}
				return _composite;
			}
		}

		private SlidingAnimationController _animationController;
		private SlidingAnimationController AnimationController
		{
			get
			{
				if (_animationController == null)
				{
					_animationController = new SlidingAnimationController();
					_animationController.SlidingViewController = this.SlidingViewController;
				}
				return _animationController;
			}
		}

		public SlidingViewController SlidingViewController
		{ get; set; }

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region Gestures Handling
		//___________________________________________________________________________________________________

		[Export("HandlePanGesture:")]
		protected void HandlePanGesture (UIPanGestureRecognizer gesture)
		{
			if (this.Animator.Running || this.PanGestureEvent == null) return;
			this.PanGestureEvent(gesture);
		}

		[Export("HandleTapGesture:")]
		protected void HandleTapGesture (UITapGestureRecognizer gesture)
		{
			if (this.Animator.Running || this.TapGestureEvent == null) return;
			this.TapGestureEvent(gesture);
		}

		internal void PanBegan (SlidingViewController slidingController, UIView topView, float translationX, float velocityX)
		{
			bool movingRight     = velocityX > 0;
			_initialTopViewFrame = ((CALayer)topView.Layer.PresentationLayer).Frame;
			_interactive         = true;

			ECSlidingViewControllerTopViewPosition pos = slidingController.CurrentTopViewPosition;

			// Move sliding panel
			if (ECSlidingViewControllerTopViewPosition.Centered == pos && slidingController.UnderLeftViewController != null && movingRight)
			{
				slidingController.AnchorTopViewToRightAnimated (true);
			}
			else if (ECSlidingViewControllerTopViewPosition.Centered == pos && slidingController.UnderRightViewController != null && !movingRight)
			{
				slidingController.AnchorTopViewToLeftAnimated (true);
			}
			else if (ECSlidingViewControllerTopViewPosition.AnchoredLeft == pos || ECSlidingViewControllerTopViewPosition.AnchoredRight == pos)
			{
				slidingController.ResetTopViewAnimated(true);
			}
			else
			{
				_interactive = false;
			}
		}

		internal void PanChanged (SlidingViewController slidingController, UIView topView, float translationX, float velocityX)
		{
			if (!_interactive) return;

			RectangleF initialFrame = _initialTopViewFrame;
			float      newLeftEdge  = initialFrame.X + translationX;
			// Calculate left edge
			if (newLeftEdge < 0)
			{
				newLeftEdge = 0;
			}
			else if (newLeftEdge > slidingController.AnchorRightRevealAmount)
			{
				newLeftEdge = slidingController.AnchorRightRevealAmount;
			}
			// Update top view frame
			initialFrame.X = newLeftEdge;
			topView.Frame  = initialFrame;
			// Update transition
			float percentComplete = ((!_positiveLeftToRight ? translationX * -1f : translationX) / _fullWidth);
			percentComplete = percentComplete < 0   ? 0   : percentComplete;
			percentComplete = percentComplete > 100 ? 100 : percentComplete;

			slidingController.UpdateInteractiveTransition(percentComplete);
		}

		internal void PanEnded (SlidingViewController slidingController, UIView topView, float translationX, float velocityX)
		{
			if (!_interactive) return;

			_panningRight = velocityX > 0;
			_interactive  = false;

			// Update gravity direction
			this.Gravity.GravityDirection = _panningRight ? new CGVector(2f, 0f) : new CGVector(-2f, 0f);
			// Update push behavior
			this.Push.Angle     = 0;
			this.Push.Magnitude = velocityX;
			this.Push.Active    = true;
			// Add composite behavior
			this.Animator.AddBehavior(this.Composite);
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region ECSlidingViewControllerDelegate
		//___________________________________________________________________________________________________

		[Export ("slidingViewController:animationControllerForOperation:topViewController:")]
		public NSObject AnimationControllerForOperation
		(
			ECSlidingViewController slidingViewController,
			ECSlidingViewControllerOperation operation,
			UIViewController topViewController
		)
		{
			return this.AnimationController;
		}

		[Export ("slidingViewController:interactionControllerForAnimationController:")]
		public NSObject InteractionControllerForAnimationController
		(
			ECSlidingViewController slidingViewController,
			UIViewControllerAnimatedTransitioning animationController
		)
		{
			return this;
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region UIViewControllerInteractiveTransitioning
		//___________________________________________________________________________________________________

		[Export ("startInteractiveTransition:")]
		protected void StartInteractiveTransition (IUIViewControllerContextTransitioning transitionCtx)
		{
			SlidingViewController sliding = this.SlidingViewController;
			UIViewController topController = sliding.GetViewControllerForKey(ECSlidingViewController.ECTransitionContextTopViewControllerKey);
			// Disable user interaction of top controller's view
			topController.View.UserInteractionEnabled = false;
			if (_interactive)
			{
				UIViewController underController = sliding.GetViewControllerForKey(ECSlidingViewController.ECTransitionContextUnderLeftControllerKey);
				RectangleF underViewInitialFrame = sliding.GetInitialFrameForViewController(underController);
				RectangleF underViewFinalFrame   = sliding.GetFinalFrameForViewController(underController);

				// Update frame of under controller view
				underController.View.Frame = underViewInitialFrame.IsEmpty ? underViewFinalFrame : underViewInitialFrame;
				// Insert under view below top view
				sliding.ContainerView.InsertSubviewBelow(underController.View, topController.View);

				// Do some calculation 
				float  finalLeftEdge   = sliding.GetFinalFrameForViewController(topController).GetMinX();
				float  initialLeftEdge = sliding.GetInitialFrameForViewController(topController).GetMinX();

				_fullWidth           = Math.Abs(finalLeftEdge - initialLeftEdge);
				_positiveLeftToRight = initialLeftEdge < finalLeftEdge;
			}
			else
			{
				this.AnimationController.AnimateTransition(transitionCtx);
			}
			// Enable user interaction of top controller's view
			topController.View.UserInteractionEnabled = true;
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region UIDynamicAnimatorDelegate
		//___________________________________________________________________________________________________

		[Export ("dynamicAnimatorDidPause:")]
		protected void DynamicAnimatorDidPause (UIDynamicAnimator animator)
		{
			this.Animator.RemoveAllBehaviors();

			_collision = null;
			_topView   = null;
			_push      = null;
			_gravity   = null;
			_composite = null;
			_animator  = null;

			this.SlidingViewController.TopViewController.View.UserInteractionEnabled = true;

			UIViewController topController = this.SlidingViewController.GetViewControllerForKey(ECSlidingViewController.ECTransitionContextTopViewControllerKey);
			if ((_panningRight && _positiveLeftToRight) || (!_panningRight && !_positiveLeftToRight))
			{
				topController.View.Frame = this.SlidingViewController.GetFinalFrameForViewController(topController);
				this.SlidingViewController.FinishInteractiveTransition();
			}
			else if ((_panningRight && !_positiveLeftToRight) || (!_panningRight && _positiveLeftToRight))
			{
				topController.View.Frame = this.SlidingViewController.GetInitialFrameForViewController(topController);
				this.SlidingViewController.CancelInteractiveTransition();
			}

			this.SlidingViewController.CompleteTransition(true);
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
	}
}

