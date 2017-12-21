using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NativeFormsTest.Core
{
    public partial class TestPage1 : ContentPage
    {
        public TestPage1()
        {
            InitializeComponent();

            MyLabel.Text = "Forms Page!";
        }
    }
}
