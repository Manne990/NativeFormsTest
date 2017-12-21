using Android.App;
using Android.Widget;
using Android.OS;
using NativeFormsTest.Core;
using Xamarin.Forms.Platform.Android;

namespace NativeFormsTest.Droid
{
    [Activity(Label = "NativeFormsTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Init Forms
            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var fragment = new MainFragment(HandleAction);
            LoadFragment(fragment, "Start");
        }

        private void HandleAction()
        {
            LoadFragment(new TestPage1().CreateFragment(this), "Start");
        }

        private void LoadFragment(Fragment fragment, string title)
        {
            var ft = FragmentManager.BeginTransaction();

            ft.Replace(Resource.Id.fragmentContainer, fragment, nameof(fragment));
            ft.AddToBackStack(title);

            ft.Commit();
        }
    }
}