// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Mvx4.IOS.Views
{
	[Register ("ParameterizedView")]
	partial class ParameterizedView
	{
		[Outlet]
		UILabel KeyLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (KeyLabel != null) {
				KeyLabel.Dispose ();
				KeyLabel = null;
			}
		}
	}
}
