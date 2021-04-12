using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomControlDemo.Controls
{
    public partial class CustomContentView : ContentView
    {
        public CustomContentView()
        {
            InitializeComponent();
        }
    }

    public class MyBoxView : BoxView
    {
        public MyBoxView()
        {

        }
        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            return new SizeRequest(new Size(widthConstraint, heightConstraint));
        }
    }

}
