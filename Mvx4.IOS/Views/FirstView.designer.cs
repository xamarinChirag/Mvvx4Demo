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
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField FirstName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel FullName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Label { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField LastName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (FirstName != null) {
				FirstName.Dispose ();
				FirstName = null;
			}
			if (FullName != null) {
				FullName.Dispose ();
				FullName = null;
			}
			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
			if (LastName != null) {
				LastName.Dispose ();
				LastName = null;
			}
			if (TextField != null) {
				TextField.Dispose ();
				TextField = null;
			}
		}
	}
}
