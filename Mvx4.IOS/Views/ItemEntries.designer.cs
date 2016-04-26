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
	[Register ("ItemEntries")]
	partial class ItemEntries
	{
		[Outlet]
		UIKit.UIImageView ImageMain { get; set; }

		[Outlet]
		UIKit.UILabel LabelEntryNo { get; set; }

		[Outlet]
		UIKit.UILabel LabelTitle { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LabelTitle != null) {
				LabelTitle.Dispose ();
				LabelTitle = null;
			}
		}
	}
}
