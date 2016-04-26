// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Mvx4.IOS.Views
{
	[Register ("SimpleView")]
	partial class SimpleView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView ListTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ListTableView != null) {
				ListTableView.Dispose ();
				ListTableView = null;
			}
		}
	}
}
