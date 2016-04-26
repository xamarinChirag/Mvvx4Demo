using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Mvx4.Core.ViewModels;
using Sequence.Plugins.InfiniteScroll.iOS;

namespace Mvx4.IOS.Views
{
    public partial class SimpleView : MvxViewController
    {
        public SimpleView() : base("SimpleView", null)
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

            IncrementalTableViewSource source = new IncrementalTableViewSource(ListTableView, ItemEntries.Key);
            source.CreateBinding<SimpleViewModel>(this, vm => vm.Numbers);

            ListTableView.RowHeight = 300;
            ListTableView.Source = source;
        }
    }
}