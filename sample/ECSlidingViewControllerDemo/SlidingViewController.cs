using System;
using System.Drawing;
using ECSlidingViewControllerLib;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace ECSlidingViewControllerDemo
{
	[Adopts ("UIViewControllerInteractiveTransitioning")]
	[Adopts ("UIViewControllerTransitionCoordinator")]
	[Adopts ("UIViewControllerContextTransitioning")]
	[Register ("SlidingViewController")]
	public class SlidingViewController : ECSlidingViewController
	{
		//___________________________________________________________________________________________________
		#region Properties
		//___________________________________________________________________________________________________

		private SlidingTransition _slidingTransition;
		private SlidingTransition SlidingTransition
		{
			get
			{
				if (_slidingTransition == null)
				{
					_slidingTransition = new SlidingTransition();
					_slidingTransition.PanGestureEvent += HandlePan;
					_slidingTransition.TapGestureEvent += HandleTap;
				}
				return _slidingTransition;
			}
		}

		private UIPanGestureRecognizer _panGesture;
		private UIPanGestureRecognizer TransitionPanGesture
		{
			get
			{
				if (_panGesture == null)
				{
					_panGesture = new UIPanGestureRecognizer(
						this.SlidingTransition,
						new Selector("HandlePanGesture:")
					);
					_panGesture.CancelsTouchesInView = false;
					_panGesture.DelaysTouchesBegan   = false;
					_panGesture.WeakDelegate         = this;
				}
				return _panGesture;
			}
		}

		private UITapGestureRecognizer _tapGesture;
		private UITapGestureRecognizer TransitionTapGesture
		{
			get
			{
				if (_tapGesture == null)
				{
					_tapGesture = new UITapGestureRecognizer (
						this.SlidingTransition,
						new Selector("HandleTapGesture:")
					);
					_tapGesture.CancelsTouchesInView = false;
					_tapGesture.DelaysTouchesBegan   = false;
					_tapGesture.NumberOfTapsRequired = 2;
					_tapGesture.WeakDelegate         = this;
				}
				return _tapGesture;
			}
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region Lifecycle
		//___________________________________________________________________________________________________

		protected void Setup ()
		{
			this.WeakDelegate           = this.SlidingTransition;
			this.TopViewAnchoredGesture = ECSlidingViewControllerAnchoredGesture.Tapping | ECSlidingViewControllerAnchoredGesture.Custom;
			this.CustomAnchoredGestures = new NSObject[]{ this.TransitionPanGesture, this.TransitionTapGesture };
		}

		public SlidingViewController (IntPtr handle) : base (handle)
		{
			this.Setup ();
		}

		public override bool PrefersStatusBarHidden ()
		{
			return true;
		}

		public override void ViewDidLoad ()
		{
			// Setup sliding transition
			this.SlidingTransition.SlidingViewController = this;
			// Update status bar
			this.SetNeedsStatusBarAppearanceUpdate ();
			// Call parent method
			base.ViewDidLoad ();
		}

		public override UIViewController TopViewController
		{
			set
			{
				// Remove gestures
				if (this.TopViewController != null)
				{
					this.TopViewController.View.RemoveGestureRecognizer(this.PanGesture);
					this.TopViewController.View.RemoveGestureRecognizer(this.ResetTapGesture);
				}
				// Set new top vew controller
				base.TopViewController = value;
				// Add gestures
				if (this.TopViewController != null)
				{
					this.TopViewController.View.AddGestureRecognizer(this.TransitionPanGesture);
					this.TopViewController.View.AddGestureRecognizer(this.TransitionTapGesture);
				}
			}
		}

		public void SwitchLeftPanelVisibility ()
		{
			if (CurrentTopViewPosition == ECSlidingViewControllerTopViewPosition.Centered)
			{
				AnchorTopViewToRightAnimated (true);
			}
			else
			{
				ResetTopViewAnimated (true);
			}
		}

		protected void HandlePan (UIPanGestureRecognizer gesture)
		{
			// Prepare values
			UIView topView      = this.TopViewController.View;
			float  translationX = gesture.TranslationInView (this.View).X;
			float  velocityX    = gesture.VelocityInView(this.View).X;
			// Handle gesture
			switch (gesture.State)
			{
				case UIGestureRecognizerState.Began:
				{
					this.SlidingTransition.PanBegan(this, topView, translationX, velocityX);
					break;
				}
				case UIGestureRecognizerState.Changed:
				{
					this.SlidingTransition.PanChanged(this, topView, translationX, velocityX);
					break;
				}
				case UIGestureRecognizerState.Ended:
				case UIGestureRecognizerState.Cancelled:
				{
					this.SlidingTransition.PanEnded(this, topView, translationX, velocityX);
					break;
				}
			}
		}

		protected void HandleTap (UITapGestureRecognizer gesture)
		{
			// Hide left panel
			if (this.CurrentTopViewPosition == ECSlidingViewControllerTopViewPosition.Centered) return;
			this.ResetTopViewAnimated(true);
		}

		[Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		public virtual bool ShouldRecognizeSimultaneously (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			return true;
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
	}
}

