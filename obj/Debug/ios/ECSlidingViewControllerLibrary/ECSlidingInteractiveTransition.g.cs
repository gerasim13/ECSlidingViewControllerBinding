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
	[Register("ECSlidingInteractiveTransition", true)]
	public unsafe partial class ECSlidingInteractiveTransition : ECPercentDrivenInteractiveTransition {
		[CompilerGenerated]
		const string selInitWithSlidingViewController_ = "initWithSlidingViewController:";
		static readonly IntPtr selInitWithSlidingViewController_Handle = Selector.GetHandle ("initWithSlidingViewController:");
		[CompilerGenerated]
		const string selUpdateTopViewHorizontalCenterWithRecognizer_ = "updateTopViewHorizontalCenterWithRecognizer:";
		static readonly IntPtr selUpdateTopViewHorizontalCenterWithRecognizer_Handle = Selector.GetHandle ("updateTopViewHorizontalCenterWithRecognizer:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ECSlidingInteractiveTransition");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ECSlidingInteractiveTransition () : base (NSObjectFlag.Empty)
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
		public ECSlidingInteractiveTransition (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingInteractiveTransition (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ECSlidingInteractiveTransition (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSlidingViewController:")]
		[CompilerGenerated]
		public ECSlidingInteractiveTransition (ECSlidingViewController slidingViewController)
			: base (NSObjectFlag.Empty)
		{
			if (slidingViewController == null)
				throw new ArgumentNullException ("slidingViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithSlidingViewController_Handle, slidingViewController.Handle), "initWithSlidingViewController:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithSlidingViewController_Handle, slidingViewController.Handle), "initWithSlidingViewController:");
			}
		}
		
		[Export ("updateTopViewHorizontalCenterWithRecognizer:")]
		[CompilerGenerated]
		public virtual void UpdateTopViewHorizontalCenterWithRecognizer (global::MonoTouch.UIKit.UIPanGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUpdateTopViewHorizontalCenterWithRecognizer_Handle, recognizer.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUpdateTopViewHorizontalCenterWithRecognizer_Handle, recognizer.Handle);
			}
		}
		
	} /* class ECSlidingInteractiveTransition */
}
