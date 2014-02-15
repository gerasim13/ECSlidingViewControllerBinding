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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DECSlidingViewAnimationComplete (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDECSlidingViewAnimationComplete {
			static internal readonly DECSlidingViewAnimationComplete Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DECSlidingViewAnimationComplete))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::ECSlidingViewControllerLibrary.ECSlidingViewAnimationComplete) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ();
			}
		} /* class SDECSlidingViewAnimationComplete */
		
		internal class NIDECSlidingViewAnimationComplete {
			IntPtr blockPtr;
			DECSlidingViewAnimationComplete invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDECSlidingViewAnimationComplete (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DECSlidingViewAnimationComplete) Runtime.GetDelegateForBlock (block->invoke, typeof (DECSlidingViewAnimationComplete));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::ECSlidingViewControllerLibrary.ECSlidingViewAnimationComplete Create (IntPtr block)
			{
				return new NIDECSlidingViewAnimationComplete ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDECSlidingViewAnimationComplete */
	}
}
