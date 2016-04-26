using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Mvx4.Droid.Views
{
    [Activity(Label = "My Activity")]
    public class ParameterizedView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Param);
        }
    }
}