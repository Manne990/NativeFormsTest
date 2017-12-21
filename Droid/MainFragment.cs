using System;
using Android.App;
using Android.Widget;

namespace NativeFormsTest.Droid
{
    public class MainFragment : Fragment
    {
        private readonly Action _buttonListener;

        public MainFragment(Action buttonListener)
        {
            _buttonListener = buttonListener;
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.MainFragmentLayout, container, false);

            var button = view.FindViewById<Button>(Resource.Id.myButton);
            button.Click += (sender, e) => 
            {
                _buttonListener?.Invoke();
            };

            return view;
        }
    }
}