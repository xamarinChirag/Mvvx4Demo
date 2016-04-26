using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Mvx4.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
      //  private string _parameterKey;

        public MainViewModel()
        {
            ParameterKey = "42";
        }

        public ICommand GoFirstViewCommand
        {
            get { return new MvxCommand(() => ShowViewModel<FirstViewModel>()); }
        }

        public ICommand GoSimpleCommand
        {
            get { return new MvxCommand(() => ShowViewModel<SimpleViewModel>()); }
        }

        public string ParameterKey { get; set; }
        //{
        //    get { return _parameterKey; }
        //    set
        //    {
        //        _parameterKey = value;
        //        RaisePropertyChanged(() => ParameterKey);
        //    }
        //}

        public ICommand GoParameterizedCommand
        {
            get
            {
                return
                    new MvxCommand(
                        () =>
                        ShowViewModel<ParameterizedViewModel>(new ParameterizedViewModel.Parameters { Key = ParameterKey }));
            }
        }

        public ICommand GoAnonymousCommand
        {
            get { return new MvxCommand(() => ShowViewModel<AnonymousViewModel>(new { key = ParameterKey })); }
        }
    }
}