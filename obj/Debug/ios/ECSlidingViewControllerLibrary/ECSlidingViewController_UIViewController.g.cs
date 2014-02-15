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
	public unsafe static partial class ECSlidingViewController_UIViewController  {
		[CompilerGenerated]
		const string selSlidingViewController = "slidingViewController";
		static readonly IntPtr selSlidingViewControllerHandle = Selector.GetHandle ("slidingViewController");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MonoTouch.UIKit.UIViewController");
		
		[Export ("slidingViewController")]
		[CompilerGenerated]
		public static ECSlidingViewController SlidingViewController (this global::MonoTouch.UIKit.UIViewController This)
		{
			return  Runtime.GetNSObject<ECSlidingViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, selSlidingViewControllerHandle));
		}
		
	} /* class ECSlidingViewController_UIViewController */
}
