using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ECSlidingViewControllerLib
{
	public delegate void ECSlidingViewAnimationComplete ();

	[BaseType (typeof (UIViewController))]
	public partial interface ECSlidingViewController
	{
		[Field ("ECTransitionContextTopViewControllerKey", "__Internal")]
		NSString ECTransitionContextTopViewControllerKey { get; }

		[Field ("ECTransitionContextUnderLeftControllerKey", "__Internal")]
		NSString ECTransitionContextUnderLeftControllerKey { get; }

		[Field ("ECTransitionContextUnderRightControllerKey", "__Internal")]
		NSString ECTransitionContextUnderRightControllerKey { get; }

		[Static, Export ("slidingWithTopViewController:")]
		ECSlidingViewController SlidingWithTopViewController (UIViewController topViewController);

		[Export ("initWithTopViewController:")]
		IntPtr Constructor (UIViewController topViewController);

		[Export ("delegate"), NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		ECSlidingViewControllerDelegate Delegate { get; set; }


		[Export ("topViewController", ArgumentSemantic.Retain)]
		UIViewController TopViewController { get; set; }

		[Export ("underLeftViewController", ArgumentSemantic.Retain)]
		UIViewController UnderLeftViewController { get; set; }

		[Export ("underRightViewController", ArgumentSemantic.Retain)]
		UIViewController UnderRightViewController { get; set; }


		[Export ("anchorLeftPeekAmount")]
		float AnchorLeftPeekAmount { get; set; }

		[Export ("anchorLeftRevealAmount")]
		float AnchorLeftRevealAmount { get; set; }

		[Export ("anchorRightPeekAmount")]
		float AnchorRightPeekAmount { get; set; }

		[Export ("anchorRightRevealAmount")]
		float AnchorRightRevealAmount { get; set; }


		[Export ("anchorTopViewToRightAnimated:onComplete:")]
		void AnchorTopViewToRightAnimated (bool animated, [NullAllowed] ECSlidingViewAnimationComplete complete = null);

		[Export ("anchorTopViewToLeftAnimated:onComplete:")]
		void AnchorTopViewToLeftAnimated (bool animated, [NullAllowed] ECSlidingViewAnimationComplete complete = null);

		[Export ("resetTopViewAnimated:onComplete:")]
		void ResetTopViewAnimated (bool animated, [NullAllowed] ECSlidingViewAnimationComplete complete = null);

		// [Export ("anchorTopViewToRightAnimated:")]
		[Wrap ("AnchorTopViewToRightAnimated(animated, null)")]
		void AnchorTopViewToRightAnimated (bool animated);

		// [Export ("anchorTopViewToLeftAnimated:")]
		[Wrap ("AnchorTopViewToLeftAnimated(animated, null)")]
		void AnchorTopViewToLeftAnimated (bool animated);

		// [Export ("resetTopViewAnimated:")]
		[Wrap ("ResetTopViewAnimated(animated, null)")]
		void ResetTopViewAnimated (bool animated);


		[Export ("topViewControllerStoryboardId", ArgumentSemantic.Retain)]
		string TopViewControllerStoryboardId { get; set; }

		[Export ("underLeftViewControllerStoryboardId", ArgumentSemantic.Retain)]
		string UnderLeftViewControllerStoryboardId { get; set; }

		[Export ("underRightViewControllerStoryboardId", ArgumentSemantic.Retain)]
		string UnderRightViewControllerStoryboardId { get; set; }


		[Export ("topViewAnchoredGesture")]
		ECSlidingViewControllerAnchoredGesture TopViewAnchoredGesture { get; set; }

		[Export ("currentTopViewPosition")]
		ECSlidingViewControllerTopViewPosition CurrentTopViewPosition { get; }

		[Export ("panGesture", ArgumentSemantic.Retain)]
		UIPanGestureRecognizer PanGesture { get; }

		[Export ("resetTapGesture", ArgumentSemantic.Retain)]
		UITapGestureRecognizer ResetTapGesture { get; }

		[Export ("customAnchoredGestures", ArgumentSemantic.Retain)]
		NSObject [] CustomAnchoredGestures { get; set; }


		// UIViewControllerContextTransitioning
		[Export ("containerView")]
		UIView ContainerView { get; }

		[Export ("isAnimated")]
		bool Animated { get; }

		[Export ("isInteractive")]
		bool Interactive { get; }

		[Export ("transitionWasCancelled")]
		bool TransitionWasCancelled { get; }

		[Export ("presentationStyle")]
		UIModalPresentationStyle PresentationStyle { get; }

		[Export ("updateInteractiveTransition:")]
		void UpdateInteractiveTransition (float percentComplete);

		[Export ("cancelInteractiveTransition")]
		void CancelInteractiveTransition ();

		[Export ("finishInteractiveTransition")]
		void FinishInteractiveTransition ();

		[Export ("completeTransition:")]
		void CompleteTransition (bool complete);

		[Export ("viewControllerForKey:")]
		UIViewController GetViewControllerForKey (NSString key);

		[Export ("initialFrameForViewController:")]
		RectangleF GetInitialFrameForViewController (UIViewController vc);

		[Export ("finalFrameForViewController:")]
		RectangleF GetFinalFrameForViewController (UIViewController vc);

		// UIViewControllerTransitionCoordinator

		// UIViewControllerTransitionCoordinatorContext
		[Export ("initiallyInteractive")]
		bool InitiallyInteractive { get; }

		[Export ("transitionDuration")]
		double TransitionDuration { get; }

		[Export ("percentComplete")]
		float PercentComplete { get; }

		[Export ("completionVelocity")]
		float CompletionVelocity { get; }

		[Export ("completionCurve")]
		UIViewAnimationCurve CompletionCurve { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface ECPercentDrivenInteractiveTransition
	{

		[Export ("animationController", ArgumentSemantic.Retain)]
		UIViewControllerAnimatedTransitioning AnimationController { get; set; }

		[Export ("percentComplete")]
		float PercentComplete { get; }

		[Export ("updateInteractiveTransition:")]
		void UpdateInteractiveTransition (float percentComplete);

		[Export ("cancelInteractiveTransition")]
		void CancelInteractiveTransition ();

		[Export ("finishInteractiveTransition")]
		void FinishInteractiveTransition ();

		// UIViewControllerInteractiveTransitioning
		[Export ("startInteractiveTransition:")]
		void StartInteractiveTransition (UIViewControllerContextTransitioning transitionContext);

		[Export ("completionSpeed")]
		float CompletionSpeed { get; }

		[Export ("completionCurve")]
		UIViewAnimationCurve CompletionCurve { get; }
	}

	[BaseType (typeof (NSObject))]
	//[Adopts("UIViewControllerAnimatedTransitioning")]
	//[Register("UIViewControllerAnimatedTransitioning"), Model]
	//[Protocol(Name = "UIViewControllerAnimatedTransitioning")]
	public partial interface ECSlidingAnimationController
	{
		[Export ("transitionDuration:")]
		double TransitionDuration (IUIViewControllerContextTransitioning transitionContext);

		[Export ("animateTransition:")]
		void AnimateTransition (IUIViewControllerContextTransitioning transitionContext);
	}

	[BaseType (typeof (ECPercentDrivenInteractiveTransition))]
	public partial interface ECSlidingInteractiveTransition
	{
		[Export ("initWithSlidingViewController:")]
		IntPtr Constructor (ECSlidingViewController slidingViewController);

		[Export ("updateTopViewHorizontalCenterWithRecognizer:")]
		void UpdateTopViewHorizontalCenterWithRecognizer (UIPanGestureRecognizer recognizer);
	}

	[BaseType (typeof (UIStoryboardSegue))]
	public partial interface ECSlidingSegue
	{
		[Export ("skipSettingTopViewController")]
		bool SkipSettingTopViewController { get; set; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface ECSlidingViewControllerLayout
	{
		[Export ("slidingViewController:frameForViewController:topViewPosition:")]
		RectangleF SlidingViewController (ECSlidingViewController slidingViewController, UIViewController viewController, ECSlidingViewControllerTopViewPosition topViewPosition);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface ECSlidingViewControllerDelegate
	{
		[Export ("slidingViewController:animationControllerForOperation:topViewController:")]
		NSObject AnimationControllerForOperation (ECSlidingViewController slidingViewController, ECSlidingViewControllerOperation operation, UIViewController topViewController);

		[Export ("slidingViewController:interactionControllerForAnimationController:")]
		NSObject InteractionControllerForAnimationController (ECSlidingViewController slidingViewController, UIViewControllerAnimatedTransitioning animationController);

		[Export ("slidingViewController:layoutControllerForTopViewPosition:")]
		NSObject LayoutControllerForTopViewPosition (ECSlidingViewController slidingViewController, ECSlidingViewControllerTopViewPosition topViewPosition);
	}

	[Category, BaseType (typeof (UIViewController))]
	public partial interface ECSlidingViewController_UIViewController
	{
		[Export ("slidingViewController")]
		ECSlidingViewController SlidingViewController ();
	}
}

