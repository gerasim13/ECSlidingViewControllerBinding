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
	[Register("ECPercentDrivenInteractiveTransition", true)]
	public unsafe partial class ECPercentDrivenInteractiveTransition : NSObject {
		[CompilerGenerated]
		const string selAnimationController = "animationController";
		static readonly IntPtr selAnimationControllerHandle = Selector.GetHandle ("animationController");
		[CompilerGenerated]
		const string selSetAnimationController_ = "setAnimationController:";
		static readonly IntPtr selSetAnimationController_Handle = Selector.GetHandle ("setAnimationController:");
		[CompilerGenerated]
		const string selPercentComplete = "percentComplete";
		static readonly IntPtr selPercentCompleteHandle = Selector.GetHandle ("percentComplete");
		[CompilerGenerated]
		const string selCompletionSpeed = "completionSpeed";
		static readonly IntPtr selCompletionSpeedHandle = Selector.GetHandle ("completionSpeed");
		[CompilerGenerated]
		const string selCompletionCurve = "completionCurve";
		static readonly IntPtr selCompletionCurveHandle = Selector.GetHandle ("completionCurve");
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
		const string selStartInteractiveTransition_ = "startInteractiveTransition:";
		static readonly IntPtr selStartInteractiveTransition_Handle = Selector.GetHandle ("startInteractiveTransition:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ECPercentDrivenInteractiveTransition");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ECPercentDrivenInteractiveTransition () : base (NSObjectFlag.Empty)
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
		public ECPercentDrivenInteractiveTransition (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECPercentDrivenInteractiveTransition (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECPercentDrivenInteractiveTransition (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		
		[Export ("startInteractiveTransition:")]
		[CompilerGenerated]
		public virtual void StartInteractiveTransition (global::MonoTouch.UIKit.UIViewControllerContextTransitioning transitionContext)
		{
			if (transitionContext == null)
				throw new ArgumentNullException ("transitionContext");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStartInteractiveTransition_Handle, transitionContext.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStartInteractiveTransition_Handle, transitionContext.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_AnimationController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewControllerAnimatedTransitioning AnimationController {
			[Export ("animationController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewControllerAnimatedTransitioning ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewControllerAnimatedTransitioning> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnimationControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewControllerAnimatedTransitioning> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnimationControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnimationController_var = ret;
				return ret;
			}
			
			[Export ("setAnimationController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnimationController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnimationController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnimationController_var = value;
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
		public virtual float CompletionSpeed {
			[Export ("completionSpeed")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCompletionSpeedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selCompletionSpeedHandle);
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnimationController_var = null;
			}
		}
	} /* class ECPercentDrivenInteractiveTransition */
}
