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
	[Register("ECSlidingViewControllerDelegate", true)]
	[Model]
	public unsafe partial class ECSlidingViewControllerDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ECSlidingViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		public ECSlidingViewControllerDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("slidingViewController:animationControllerForOperation:topViewController:")]
		[CompilerGenerated]
		public virtual NSObject AnimationControllerForOperation (ECSlidingViewController slidingViewController, ECSlidingViewControllerOperation operation, global::MonoTouch.UIKit.UIViewController topViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("slidingViewController:interactionControllerForAnimationController:")]
		[CompilerGenerated]
		public virtual NSObject InteractionControllerForAnimationController (ECSlidingViewController slidingViewController, global::MonoTouch.UIKit.UIViewControllerAnimatedTransitioning animationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("slidingViewController:layoutControllerForTopViewPosition:")]
		[CompilerGenerated]
		public virtual NSObject LayoutControllerForTopViewPosition (ECSlidingViewController slidingViewController, ECSlidingViewControllerTopViewPosition topViewPosition)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class ECSlidingViewControllerDelegate */
}
