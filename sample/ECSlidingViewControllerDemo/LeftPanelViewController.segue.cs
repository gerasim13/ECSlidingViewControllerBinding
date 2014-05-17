using System;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ECSlidingViewControllerLib;

namespace ECSlidingViewControllerDemo
{
	[Register ("LeftPanelSegue")]
	public class LeftPanelSegue : UIStoryboardSegue
	{
		//___________________________________________________________________________________________________

		protected static Dictionary<string, UINavigationController> _sharedStack;

		//___________________________________________________________________________________________________

		#region Properties

		protected static Dictionary<string, UINavigationController> NavigationStack
		{
			get
			{
				if (_sharedStack == null)
				{
					_sharedStack = new Dictionary<string, UINavigationController> ();
				}
				return _sharedStack;
			}
		}

		public ECSlidingViewController SlidingViewController
		{
			get;
			set;
		}

		#endregion

		//___________________________________________________________________________________________________

		#region Public Methods

		public LeftPanelSegue (IntPtr handle) : base (handle)
		{
		}

		public override void Perform ()
		{
			SlidingViewController.TopViewController = NavigationControllerWithIdentifier(this.Identifier, this.DestinationViewController);
		}

		#endregion

		//___________________________________________________________________________________________________

		#region Static Methods

		private static UINavigationController NavigationControllerWithIdentifier (string identifier, UIViewController destination)
		{
			// Try to get opened navigation controller
			if (!NavigationStack.ContainsKey (identifier))
			{
				// Instantiate new navigation controller
				UINavigationController nav = new UINavigationController(destination);
				// Add navigation controller to stack
				NavigationStack.Add(identifier, nav);
			}
			// Return navigation controller from stack
			return NavigationStack [identifier];
		}

		internal static UINavigationController NavigationControllerWithIdentifier (string identifier)
		{
			UIViewController destination = null;
			// Create new instance of content view
			if (!NavigationStack.ContainsKey (identifier))
			{
				destination = new UIViewController ();
				destination.View = new UIView ();
				destination.View.BackgroundColor = UIColor.Red;
			}
			// Return navigation controller from stack
			return NavigationControllerWithIdentifier(identifier, destination);
		}

		#endregion

		//___________________________________________________________________________________________________
	}
}

