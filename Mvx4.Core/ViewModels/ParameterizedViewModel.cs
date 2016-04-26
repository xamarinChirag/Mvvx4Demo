using MvvmCross.Core.ViewModels;

namespace Mvx4.Core.ViewModels
{
    public class ParameterizedViewModel : MvxViewModel
    {
        //private string _key;

        public string Key { get; set; }
        //{
        //    get { return _key; }
        //    set
        //    {
        //        _key = value;
        //        RaisePropertyChanged(() => Key);
        //    }
        //}

        public void Init(Parameters parameters)
        {
            Key = parameters.Key;
        }

        public class Parameters
        {
            public string Key { get; set; }
        }
    }
}