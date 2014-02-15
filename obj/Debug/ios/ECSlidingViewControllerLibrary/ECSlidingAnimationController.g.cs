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
	[Register("ECSlidingAnimationController", true)]
	public unsafe partial class ECSlidingAnimationController : NSObject {
		[CompilerGenerated]
		const string selTransitionDuration_ = "transitionDuration:";
		static readonly IntPtr selTransitionDuration_Handle = Selector.GetHandle ("transitionDuration:");
		[CompilerGenerated]
		const string selAnimateTransition_ = "animateTransition:";
		static readonly IntPtr selAnimateTransition_Handle = Selector.GetHandle ("animateTransition:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ECSlidingAnimationController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ECSlidingAnimationController () : base (NSObjectFlag.Empty)
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
		public ECSlidingAnimationController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingAnimationController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingAnimationController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("transitionDuration:")]
		[CompilerGenerated]
		public virtual global::System.Double TransitionDuration (global::MonoTouch.UIKit.UIViewControllerContextTransitioning transitionContext)
		{
			if (transitionContext == null)
				throw new ArgumentNullException ("transitionContext");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend_IntPtr (this.Handle, selTransitionDuration_Handle, transitionContext.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, selTransitionDuration_Handle, transitionContext.Handle);
			}
		}
		
		[Export ("animateTransition:")]
		[CompilerGenerated]
		public virtual void AnimateTransition (global::MonoTouch.UIKit.UIViewControllerContextTransitioning transitionContext)
		{
			if (transitionContext == null)
				throw new ArgumentNullException ("transitionContext");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAnimateTransition_Handle, transitionContext.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAnimateTransition_Handle, transitionContext.Handle);
			}
		}
		
	} /* class ECSlidingAnimationController */
}
