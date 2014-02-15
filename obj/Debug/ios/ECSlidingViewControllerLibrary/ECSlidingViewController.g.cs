//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace ECSlidingViewControllerLibrary {
	[Register("ECSlidingViewController", true)]
	public unsafe partial class ECSlidingViewController : global::MonoTouch.UIKit.UIViewController {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selTopViewController = "topViewController";
		static readonly IntPtr selTopViewControllerHandle = Selector.GetHandle ("topViewController");
		[CompilerGenerated]
		const string selSetTopViewController_ = "setTopViewController:";
		static readonly IntPtr selSetTopViewController_Handle = Selector.GetHandle ("setTopViewController:");
		[CompilerGenerated]
		const string selUnderLeftViewController = "underLeftViewController";
		static readonly IntPtr selUnderLeftViewControllerHandle = Selector.GetHandle ("underLeftViewController");
		[CompilerGenerated]
		const string selSetUnderLeftViewController_ = "setUnderLeftViewController:";
		static readonly IntPtr selSetUnderLeftViewController_Handle = Selector.GetHandle ("setUnderLeftViewController:");
		[CompilerGenerated]
		const string selUnderRightViewController = "underRightViewController";
		static readonly IntPtr selUnderRightViewControllerHandle = Selector.GetHandle ("underRightViewController");
		[CompilerGenerated]
		const string selSetUnderRightViewController_ = "setUnderRightViewController:";
		static readonly IntPtr selSetUnderRightViewController_Handle = Selector.GetHandle ("setUnderRightViewController:");
		[CompilerGenerated]
		const string selAnchorLeftPeekAmount = "anchorLeftPeekAmount";
		static readonly IntPtr selAnchorLeftPeekAmountHandle = Selector.GetHandle ("anchorLeftPeekAmount");
		[CompilerGenerated]
		const string selSetAnchorLeftPeekAmount_ = "setAnchorLeftPeekAmount:";
		static readonly IntPtr selSetAnchorLeftPeekAmount_Handle = Selector.GetHandle ("setAnchorLeftPeekAmount:");
		[CompilerGenerated]
		const string selAnchorLeftRevealAmount = "anchorLeftRevealAmount";
		static readonly IntPtr selAnchorLeftRevealAmountHandle = Selector.GetHandle ("anchorLeftRevealAmount");
		[CompilerGenerated]
		const string selSetAnchorLeftRevealAmount_ = "setAnchorLeftRevealAmount:";
		static readonly IntPtr selSetAnchorLeftRevealAmount_Handle = Selector.GetHandle ("setAnchorLeftRevealAmount:");
		[CompilerGenerated]
		const string selAnchorRightPeekAmount = "anchorRightPeekAmount";
		static readonly IntPtr selAnchorRightPeekAmountHandle = Selector.GetHandle ("anchorRightPeekAmount");
		[CompilerGenerated]
		const string selSetAnchorRightPeekAmount_ = "setAnchorRightPeekAmount:";
		static readonly IntPtr selSetAnchorRightPeekAmount_Handle = Selector.GetHandle ("setAnchorRightPeekAmount:");
		[CompilerGenerated]
		const string selAnchorRightRevealAmount = "anchorRightRevealAmount";
		static readonly IntPtr selAnchorRightRevealAmountHandle = Selector.GetHandle ("anchorRightRevealAmount");
		[CompilerGenerated]
		const string selSetAnchorRightRevealAmount_ = "setAnchorRightRevealAmount:";
		static readonly IntPtr selSetAnchorRightRevealAmount_Handle = Selector.GetHandle ("setAnchorRightRevealAmount:");
		[CompilerGenerated]
		const string selTopViewControllerStoryboardId = "topViewControllerStoryboardId";
		static readonly IntPtr selTopViewControllerStoryboardIdHandle = Selector.GetHandle ("topViewControllerStoryboardId");
		[CompilerGenerated]
		const string selSetTopViewControllerStoryboardId_ = "setTopViewControllerStoryboardId:";
		static readonly IntPtr selSetTopViewControllerStoryboardId_Handle = Selector.GetHandle ("setTopViewControllerStoryboardId:");
		[CompilerGenerated]
		const string selUnderLeftViewControllerStoryboardId = "underLeftViewControllerStoryboardId";
		static readonly IntPtr selUnderLeftViewControllerStoryboardIdHandle = Selector.GetHandle ("underLeftViewControllerStoryboardId");
		[CompilerGenerated]
		const string selSetUnderLeftViewControllerStoryboardId_ = "setUnderLeftViewControllerStoryboardId:";
		static readonly IntPtr selSetUnderLeftViewControllerStoryboardId_Handle = Selector.GetHandle ("setUnderLeftViewControllerStoryboardId:");
		[CompilerGenerated]
		const string selUnderRightViewControllerStoryboardId = "underRightViewControllerStoryboardId";
		static readonly IntPtr selUnderRightViewControllerStoryboardIdHandle = Selector.GetHandle ("underRightViewControllerStoryboardId");
		[CompilerGenerated]
		const string selSetUnderRightViewControllerStoryboardId_ = "setUnderRightViewControllerStoryboardId:";
		static readonly IntPtr selSetUnderRightViewControllerStoryboardId_Handle = Selector.GetHandle ("setUnderRightViewControllerStoryboardId:");
		[CompilerGenerated]
		const string selTopViewAnchoredGesture = "topViewAnchoredGesture";
		static readonly IntPtr selTopViewAnchoredGestureHandle = Selector.GetHandle ("topViewAnchoredGesture");
		[CompilerGenerated]
		const string selSetTopViewAnchoredGesture_ = "setTopViewAnchoredGesture:";
		static readonly IntPtr selSetTopViewAnchoredGesture_Handle = Selector.GetHandle ("setTopViewAnchoredGesture:");
		[CompilerGenerated]
		const string selCurrentTopViewPosition = "currentTopViewPosition";
		static readonly IntPtr selCurrentTopViewPositionHandle = Selector.GetHandle ("currentTopViewPosition");
		[CompilerGenerated]
		const string selPanGesture = "panGesture";
		static readonly IntPtr selPanGestureHandle = Selector.GetHandle ("panGesture");
		[CompilerGenerated]
		const string selResetTapGesture = "resetTapGesture";
		static readonly IntPtr selResetTapGestureHandle = Selector.GetHandle ("resetTapGesture");
		[CompilerGenerated]
		const string selCustomAnchoredGestures = "customAnchoredGestures";
		static readonly IntPtr selCustomAnchoredGesturesHandle = Selector.GetHandle ("customAnchoredGestures");
		[CompilerGenerated]
		const string selSetCustomAnchoredGestures_ = "setCustomAnchoredGestures:";
		static readonly IntPtr selSetCustomAnchoredGestures_Handle = Selector.GetHandle ("setCustomAnchoredGestures:");
		[CompilerGenerated]
		const string selContainerView = "containerView";
		static readonly IntPtr selContainerViewHandle = Selector.GetHandle ("containerView");
		[CompilerGenerated]
		const string selIsAnimated = "isAnimated";
		static readonly IntPtr selIsAnimatedHandle = Selector.GetHandle ("isAnimated");
		[CompilerGenerated]
		const string selIsInteractive = "isInteractive";
		static readonly IntPtr selIsInteractiveHandle = Selector.GetHandle ("isInteractive");
		[CompilerGenerated]
		const string selTransitionWasCancelled = "transitionWasCancelled";
		static readonly IntPtr selTransitionWasCancelledHandle = Selector.GetHandle ("transitionWasCancelled");
		[CompilerGenerated]
		const string selPresentationStyle = "presentationStyle";
		static readonly IntPtr selPresentationStyleHandle = Selector.GetHandle ("presentationStyle");
		[CompilerGenerated]
		const string selInitiallyInteractive = "initiallyInteractive";
		static readonly IntPtr selInitiallyInteractiveHandle = Selector.GetHandle ("initiallyInteractive");
		[CompilerGenerated]
		const string selTransitionDuration = "transitionDuration";
		static readonly IntPtr selTransitionDurationHandle = Selector.GetHandle ("transitionDuration");
		[CompilerGenerated]
		const string selPercentComplete = "percentComplete";
		static readonly IntPtr selPercentCompleteHandle = Selector.GetHandle ("percentComplete");
		[CompilerGenerated]
		const string selCompletionVelocity = "completionVelocity";
		static readonly IntPtr selCompletionVelocityHandle = Selector.GetHandle ("completionVelocity");
		[CompilerGenerated]
		const string selCompletionCurve = "completionCurve";
		static readonly IntPtr selCompletionCurveHandle = Selector.GetHandle ("completionCurve");
		[CompilerGenerated]
		const string selSlidingWithTopViewController_ = "slidingWithTopViewController:";
		static readonly IntPtr selSlidingWithTopViewController_Handle = Selector.GetHandle ("slidingWithTopViewController:");
		[CompilerGenerated]
		const string selInitWithTopViewController_ = "initWithTopViewController:";
		static readonly IntPtr selInitWithTopViewController_Handle = Selector.GetHandle ("initWithTopViewController:");
		[CompilerGenerated]
		const string selAnchorTopViewToRightAnimatedOnComplete_ = "anchorTopViewToRightAnimated:onComplete:";
		static readonly IntPtr selAnchorTopViewToRightAnimatedOnComplete_Handle = Selector.GetHandle ("anchorTopViewToRightAnimated:onComplete:");
		[CompilerGenerated]
		const string selAnchorTopViewToLeftAnimatedOnComplete_ = "anchorTopViewToLeftAnimated:onComplete:";
		static readonly IntPtr selAnchorTopViewToLeftAnimatedOnComplete_Handle = Selector.GetHandle ("anchorTopViewToLeftAnimated:onComplete:");
		[CompilerGenerated]
		const string selResetTopViewAnimatedOnComplete_ = "resetTopViewAnimated:onComplete:";
		static readonly IntPtr selResetTopViewAnimatedOnComplete_Handle = Selector.GetHandle ("resetTopViewAnimated:onComplete:");
		[CompilerGenerated]
		const string selUpdateInteractiveTransition_ = "updateInteractiveTransition:";
		static readonly IntPtr selUpdateInteractiveTransition_Handle = Selector.GetHandle ("updateInteractiveTransition:");
		[CompilerGenerated]
		const string selCancelInteractiveTransition = "cancelInteractiveTransition";
		static readonly IntPtr selCancelInteractiveTransitionHandle = Selector.GetHandle ("cancelInteractiveTransition");
		[CompilerGenerated]
		const string selFinishInteractiveTransition = "finishInteractiveTransition";
		static readonly IntPtr selFinishInteractiveTransitionHandle = Selector.GetHandle ("finishInteractiveTransition");
		[CompilerGenerated]
		const string selCompleteTransition_ = "completeTransition:";
		static readonly IntPtr selCompleteTransition_Handle = Selector.GetHandle ("completeTransition:");
		[CompilerGenerated]
		const string selViewControllerForKey_ = "viewControllerForKey:";
		static readonly IntPtr selViewControllerForKey_Handle = Selector.GetHandle ("viewControllerForKey:");
		[CompilerGenerated]
		const string selInitialFrameForViewController_ = "initialFrameForViewController:";
		static readonly IntPtr selInitialFrameForViewController_Handle = Selector.GetHandle ("initialFrameForViewController:");
		[CompilerGenerated]
		const string selFinalFrameForViewController_ = "finalFrameForViewController:";
		static readonly IntPtr selFinalFrameForViewController_Handle = Selector.GetHandle ("finalFrameForViewController:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ECSlidingViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ECSlidingViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init), "init");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ECSlidingViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("slidingWithTopViewController:")]
		[CompilerGenerated]
		public static ECSlidingViewController SlidingWithTopViewController (global::MonoTouch.UIKit.UIViewController topViewController)
		{
			if (topViewController == null)
				throw new ArgumentNullException ("topViewController");
			return  Runtime.GetNSObject<ECSlidingViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selSlidingWithTopViewController_Handle, topViewController.Handle));
		}
		
		[Export ("initWithTopViewController:")]
		[CompilerGenerated]
		public ECSlidingViewController (global::MonoTouch.UIKit.UIViewController topViewController)
			: base (NSObjectFlag.Empty)
		{
			if (topViewController == null)
				throw new ArgumentNullException ("topViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithTopViewController_Handle, topViewController.Handle), "initWithTopViewController:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithTopViewController_Handle, topViewController.Handle), "initWithTopViewController:");
			}
		}
		
		[Export ("anchorTopViewToRightAnimated:onComplete:")]
		[CompilerGenerated]
		public unsafe virtual void AnchorTopViewToRightAnimated (bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDECSlidingViewAnimationComplete))]ECSlidingViewAnimationComplete complete)
		{
			BlockLiteral *block_ptr_complete;
			BlockLiteral block_complete;
			if (complete == null){
				block_ptr_complete = null;
			} else {
				block_complete = new BlockLiteral ();
				block_ptr_complete = &block_complete;
				block_complete.SetupBlock (Trampolines.SDECSlidingViewAnimationComplete.Handler, complete);
			}
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, selAnchorTopViewToRightAnimatedOnComplete_Handle, animated, (IntPtr) block_ptr_complete);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selAnchorTopViewToRightAnimatedOnComplete_Handle, animated, (IntPtr) block_ptr_complete);
			}
			if (block_ptr_complete != null)
				block_ptr_complete->CleanupBlock ();
			
		}
		
		[Export ("anchorTopViewToLeftAnimated:onComplete:")]
		[CompilerGenerated]
		public unsafe virtual void AnchorTopViewToLeftAnimated (bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDECSlidingViewAnimationComplete))]ECSlidingViewAnimationComplete complete)
		{
			BlockLiteral *block_ptr_complete;
			BlockLiteral block_complete;
			if (complete == null){
				block_ptr_complete = null;
			} else {
				block_complete = new BlockLiteral ();
				block_ptr_complete = &block_complete;
				block_complete.SetupBlock (Trampolines.SDECSlidingViewAnimationComplete.Handler, complete);
			}
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, selAnchorTopViewToLeftAnimatedOnComplete_Handle, animated, (IntPtr) block_ptr_complete);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selAnchorTopViewToLeftAnimatedOnComplete_Handle, animated, (IntPtr) block_ptr_complete);
			}
			if (block_ptr_complete != null)
				block_ptr_complete->CleanupBlock ();
			
		}
		
		[Export ("resetTopViewAnimated:onComplete:")]
		[CompilerGenerated]
		public unsafe virtual void ResetTopViewAnimated (bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDECSlidingViewAnimationComplete))]ECSlidingViewAnimationComplete complete)
		{
			BlockLiteral *block_ptr_complete;
			BlockLiteral block_complete;
			if (complete == null){
				block_ptr_complete = null;
			} else {
				block_complete = new BlockLiteral ();
				block_ptr_complete = &block_complete;
				block_complete.SetupBlock (Trampolines.SDECSlidingViewAnimationComplete.Handler, complete);
			}
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, selResetTopViewAnimatedOnComplete_Handle, animated, (IntPtr) block_ptr_complete);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selResetTopViewAnimatedOnComplete_Handle, animated, (IntPtr) block_ptr_complete);
			}
			if (block_ptr_complete != null)
				block_ptr_complete->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public void AnchorTopViewToRightAnimated (bool animated)
		{
			AnchorTopViewToRightAnimated(animated, null);
		}
		
		[CompilerGenerated]
		public void AnchorTopViewToLeftAnimated (bool animated)
		{
			AnchorTopViewToLeftAnimated(animated, null);
		}
		
		[CompilerGenerated]
		public void ResetTopViewAnimated (bool animated)
		{
			ResetTopViewAnimated(animated, null);
		}
		
		[Export ("updateInteractiveTransition:")]
		[CompilerGenerated]
		public virtual void UpdateInteractiveTransition (float percentComplete)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selUpdateInteractiveTransition_Handle, percentComplete);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selUpdateInteractiveTransition_Handle, percentComplete);
			}
		}
		
		[Export ("cancelInteractiveTransition")]
		[CompilerGenerated]
		public virtual void CancelInteractiveTransition ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelInteractiveTransitionHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelInteractiveTransitionHandle);
			}
		}
		
		[Export ("finishInteractiveTransition")]
		[CompilerGenerated]
		public virtual void FinishInteractiveTransition ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinishInteractiveTransitionHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFinishInteractiveTransitionHandle);
			}
		}
		
		[Export ("completeTransition:")]
		[CompilerGenerated]
		public virtual void CompleteTransition (bool complete)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selCompleteTransition_Handle, complete);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selCompleteTransition_Handle, complete);
			}
		}
		
		[Export ("viewControllerForKey:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController GetViewControllerForKey (NSString key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selViewControllerForKey_Handle, key.Handle));
			} else {
				return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selViewControllerForKey_Handle, key.Handle));
			}
		}
		
		[Export ("initialFrameForViewController:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF GetInitialFrameForViewController (global::MonoTouch.UIKit.UIViewController vc)
		{
			if (vc == null)
				throw new ArgumentNullException ("vc");
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_IntPtr (out ret, this.Handle, selInitialFrameForViewController_Handle, vc.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, selInitialFrameForViewController_Handle, vc.Handle);
			}
			return ret;
		}
		
		[Export ("finalFrameForViewController:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF GetFinalFrameForViewController (global::MonoTouch.UIKit.UIViewController vc)
		{
			if (vc == null)
				throw new ArgumentNullException ("vc");
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_IntPtr (out ret, this.Handle, selFinalFrameForViewController_Handle, vc.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, selFinalFrameForViewController_Handle, vc.Handle);
			}
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public ECSlidingViewControllerDelegate Delegate {
			get {
				return WeakDelegate as ECSlidingViewControllerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TopViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController TopViewController {
			[Export ("topViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTopViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTopViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TopViewController_var = ret;
				return ret;
			}
			
			[Export ("setTopViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTopViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTopViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TopViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UnderLeftViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController UnderLeftViewController {
			[Export ("underLeftViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUnderLeftViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUnderLeftViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UnderLeftViewController_var = ret;
				return ret;
			}
			
			[Export ("setUnderLeftViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUnderLeftViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUnderLeftViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UnderLeftViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UnderRightViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController UnderRightViewController {
			[Export ("underRightViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUnderRightViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUnderRightViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UnderRightViewController_var = ret;
				return ret;
			}
			
			[Export ("setUnderRightViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUnderRightViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUnderRightViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UnderRightViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float AnchorLeftPeekAmount {
			[Export ("anchorLeftPeekAmount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAnchorLeftPeekAmountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAnchorLeftPeekAmountHandle);
				}
			}
			
			[Export ("setAnchorLeftPeekAmount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAnchorLeftPeekAmount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAnchorLeftPeekAmount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float AnchorLeftRevealAmount {
			[Export ("anchorLeftRevealAmount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAnchorLeftRevealAmountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAnchorLeftRevealAmountHandle);
				}
			}
			
			[Export ("setAnchorLeftRevealAmount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAnchorLeftRevealAmount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAnchorLeftRevealAmount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float AnchorRightPeekAmount {
			[Export ("anchorRightPeekAmount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAnchorRightPeekAmountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAnchorRightPeekAmountHandle);
				}
			}
			
			[Export ("setAnchorRightPeekAmount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAnchorRightPeekAmount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAnchorRightPeekAmount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float AnchorRightRevealAmount {
			[Export ("anchorRightRevealAmount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAnchorRightRevealAmountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAnchorRightRevealAmountHandle);
				}
			}
			
			[Export ("setAnchorRightRevealAmount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAnchorRightRevealAmount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAnchorRightRevealAmount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string TopViewControllerStoryboardId {
			[Export ("topViewControllerStoryboardId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTopViewControllerStoryboardIdHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTopViewControllerStoryboardIdHandle));
				}
			}
			
			[Export ("setTopViewControllerStoryboardId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTopViewControllerStoryboardId_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTopViewControllerStoryboardId_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UnderLeftViewControllerStoryboardId {
			[Export ("underLeftViewControllerStoryboardId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUnderLeftViewControllerStoryboardIdHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUnderLeftViewControllerStoryboardIdHandle));
				}
			}
			
			[Export ("setUnderLeftViewControllerStoryboardId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUnderLeftViewControllerStoryboardId_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUnderLeftViewControllerStoryboardId_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UnderRightViewControllerStoryboardId {
			[Export ("underRightViewControllerStoryboardId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUnderRightViewControllerStoryboardIdHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUnderRightViewControllerStoryboardIdHandle));
				}
			}
			
			[Export ("setUnderRightViewControllerStoryboardId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUnderRightViewControllerStoryboardId_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUnderRightViewControllerStoryboardId_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual ECSlidingViewControllerAnchoredGesture TopViewAnchoredGesture {
			[Export ("topViewAnchoredGesture")]
			get {
				if (IsDirectBinding) {
					return (ECSlidingViewControllerAnchoredGesture) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTopViewAnchoredGestureHandle);
				} else {
					return (ECSlidingViewControllerAnchoredGesture) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTopViewAnchoredGestureHandle);
				}
			}
			
			[Export ("setTopViewAnchoredGesture:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetTopViewAnchoredGesture_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetTopViewAnchoredGesture_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ECSlidingViewControllerTopViewPosition CurrentTopViewPosition {
			[Export ("currentTopViewPosition")]
			get {
				if (IsDirectBinding) {
					return (ECSlidingViewControllerTopViewPosition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCurrentTopViewPositionHandle);
				} else {
					return (ECSlidingViewControllerTopViewPosition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCurrentTopViewPositionHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PanGesture_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIPanGestureRecognizer PanGesture {
			[Export ("panGesture", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIPanGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIPanGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPanGestureHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIPanGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPanGestureHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PanGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ResetTapGesture_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UITapGestureRecognizer ResetTapGesture {
			[Export ("resetTapGesture", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UITapGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResetTapGestureHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UITapGestureRecognizer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selResetTapGestureHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ResetTapGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CustomAnchoredGestures_var;
		[CompilerGenerated]
		public virtual NSObject[] CustomAnchoredGestures {
			[Export ("customAnchoredGestures", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomAnchoredGesturesHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomAnchoredGesturesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomAnchoredGestures_var = ret;
				return ret;
			}
			
			[Export ("setCustomAnchoredGestures:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomAnchoredGestures_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCustomAnchoredGestures_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_CustomAnchoredGestures_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ContainerView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView ContainerView {
			[Export ("containerView")]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContainerViewHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContainerViewHandle));
				}
				MarkDirty ();
				__mt_ContainerView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Animated {
			[Export ("isAnimated")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAnimatedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAnimatedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Interactive {
			[Export ("isInteractive")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInteractiveHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsInteractiveHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool TransitionWasCancelled {
			[Export ("transitionWasCancelled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTransitionWasCancelledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selTransitionWasCancelledHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIModalPresentationStyle PresentationStyle {
			[Export ("presentationStyle")]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIModalPresentationStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPresentationStyleHandle);
				} else {
					return (global::MonoTouch.UIKit.UIModalPresentationStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPresentationStyleHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool InitiallyInteractive {
			[Export ("initiallyInteractive")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selInitiallyInteractiveHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selInitiallyInteractiveHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double TransitionDuration {
			[Export ("transitionDuration")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTransitionDurationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selTransitionDurationHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float PercentComplete {
			[Export ("percentComplete")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPercentCompleteHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPercentCompleteHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float CompletionVelocity {
			[Export ("completionVelocity")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCompletionVelocityHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selCompletionVelocityHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewAnimationCurve CompletionCurve {
			[Export ("completionCurve")]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIViewAnimationCurve) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCompletionCurveHandle);
				} else {
					return (global::MonoTouch.UIKit.UIViewAnimationCurve) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCompletionCurveHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _ECTransitionContextTopViewControllerKey;
		[Field ("ECTransitionContextTopViewControllerKey",  "__Internal")]
		public static NSString ECTransitionContextTopViewControllerKey {
			get {
				if (_ECTransitionContextTopViewControllerKey == null)
					_ECTransitionContextTopViewControllerKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "ECTransitionContextTopViewControllerKey");
				return _ECTransitionContextTopViewControllerKey;
			}
		}
		[CompilerGenerated]
		static NSString _ECTransitionContextUnderLeftControllerKey;
		[Field ("ECTransitionContextUnderLeftControllerKey",  "__Internal")]
		public static NSString ECTransitionContextUnderLeftControllerKey {
			get {
				if (_ECTransitionContextUnderLeftControllerKey == null)
					_ECTransitionContextUnderLeftControllerKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "ECTransitionContextUnderLeftControllerKey");
				return _ECTransitionContextUnderLeftControllerKey;
			}
		}
		[CompilerGenerated]
		static NSString _ECTransitionContextUnderRightControllerKey;
		[Field ("ECTransitionContextUnderRightControllerKey",  "__Internal")]
		public static NSString ECTransitionContextUnderRightControllerKey {
			get {
				if (_ECTransitionContextUnderRightControllerKey == null)
					_ECTransitionContextUnderRightControllerKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "ECTransitionContextUnderRightControllerKey");
				return _ECTransitionContextUnderRightControllerKey;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
				__mt_TopViewController_var = null;
				__mt_UnderLeftViewController_var = null;
				__mt_UnderRightViewController_var = null;
				__mt_PanGesture_var = null;
				__mt_ResetTapGesture_var = null;
				__mt_CustomAnchoredGestures_var = null;
				__mt_ContainerView_var = null;
			}
		}
	} /* class ECSlidingViewController */
	public delegate void ECSlidingViewAnimationComplete ();
}
