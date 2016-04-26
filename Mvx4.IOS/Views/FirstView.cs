using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Mvx4.Core.ViewModels;

namespace Mvx4.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
            set.Bind(FirstName).To(vm => vm.FirstName);
            set.Bind(LastName).To(vm => vm.LastName);
            set.Bind(FullName).To(vm => vm.FullName);

            set.Apply();
        }
    }
}
