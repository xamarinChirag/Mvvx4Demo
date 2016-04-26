using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Mvx4.Core.ViewModels;

namespace Mvx4.IOS.Views
{
    public partial class ParameterizedView : MvxViewController
    {
        public ParameterizedView() : base("ParameterizedView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(KeyLabel).To((ParameterizedViewModel vm) => vm.Key).Apply();
        }
    }
}