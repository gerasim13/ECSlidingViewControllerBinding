using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ECSlidingViewControllerLib;

namespace ECSlidingViewControllerDemo
{
	[Register ("LeftPanelViewController")]
	public class LeftPanelViewController : UITableViewController
	{
		//___________________________________________________________________________________________________
		#region Properties
		//___________________________________________________________________________________________________

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region Lifecycle
		//___________________________________________________________________________________________________

		public LeftPanelViewController (IntPtr handle) : base (handle)
		{
		}

		public override bool PrefersStatusBarHidden ()
		{
			return true;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.EdgesForExtendedLayout = UIRectEdge.Top | UIRectEdge.Bottom | UIRectEdge.Left;
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
		#region UITableViewDelegate Protocol
		//___________________________________________________________________________________________________

		public override void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			cell.BackgroundColor = UIColor.Clear;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.CellAt (indexPath);
			ECSlidingViewController sliding = this.SlidingViewController ();
			sliding.TopViewController = LeftPanelSegue.NavigationControllerWithIdentifier(cell.ReuseIdentifier);
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			// Set sliding view controller
			((LeftPanelSegue)segue).SlidingViewController = this.SlidingViewController ();
			// Call base method
			base.PrepareForSegue (segue, sender);
		}

		//___________________________________________________________________________________________________
		#endregion
		//___________________________________________________________________________________________________
	}
}

