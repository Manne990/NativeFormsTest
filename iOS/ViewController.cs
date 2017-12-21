using System;
using NativeFormsTest.Core;
using UIKit;
using Xamarin.Forms;

namespace NativeFormsTest.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            // Init Forms
            Forms.Init();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.Title = "Start";

            // Perform any additional setup after loading the view, typically from a nib.
            Button.TouchUpInside += delegate
            {
                NavigationController?.PushViewController(new TestPage1().CreateViewController(), true);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
