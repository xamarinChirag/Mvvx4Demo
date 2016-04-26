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
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		UIButton SimpleButton { get; set; }

		[Outlet]
		UIButton ParamsButton { get; set; }

		[Outlet]
		UIButton AnonButton { get; set; }

		[Outlet]
		UITextField KeyTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton FirstViewButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AnonButton != null) {
				AnonButton.Dispose ();
				AnonButton = null;
			}
			if (FirstViewButton != null) {
				FirstViewButton.Dispose ();
				FirstViewButton = null;
			}
			if (KeyTextField != null) {
				KeyTextField.Dispose ();
				KeyTextField = null;
			}
			if (ParamsButton != null) {
				ParamsButton.Dispose ();
				ParamsButton = null;
			}
			if (SimpleButton != null) {
				SimpleButton.Dispose ();
				SimpleButton = null;
			}
		}
	}
}
