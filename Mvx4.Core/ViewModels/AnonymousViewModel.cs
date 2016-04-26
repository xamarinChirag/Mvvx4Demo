using MvvmCross.Core.ViewModels;

namespace Mvx4.Core.ViewModels
{
    public class AnonymousViewModel : MvxViewModel
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
        ////}

        public void Init(string key)
        {
            Key = key;
        }
    }
}