using System;
using Foundation;
using UIKit;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Mvx4.Core.ViewModels;
using MvvmCross.Binding.iOS.Views;

namespace Mvx4.IOS.Views
{
    public partial class ItemEntries : MvxTableViewCell
    {
        public static readonly UINib Nib = UINib.FromName("ItemEntries", NSBundle.MainBundle);
        public static readonly NSString Key = new NSString("ItemEntries");

        public ItemEntries(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<ItemEntries, NumberViewModel>();
                set.Bind(LabelTitle).To(numberViewModel => numberViewModel.Value);
                set.Apply();
            });
        }

        public static ItemEntries Create()
        {
            return (ItemEntries) Nib.Instantiate(null, null)[0];
        }
    }
}