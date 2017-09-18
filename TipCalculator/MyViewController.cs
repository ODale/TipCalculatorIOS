using UIKit;
using CoreGraphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator
{
    class MyViewController : UIViewController
    {

        public MyViewController()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Yellow;

            //create a text field control with the specified properties
            var totalAmount = new UITextField()
            {
                Frame = new CGRect(20, 28, View.Bounds.Width - 40, 35),
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Total Amount",
            };

            //create a button control with the specified properties
            var calcButton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CGRect(20,71, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.FromRGB(0, 0.5f, 0),
            };
            calcButton.SetTitle("Calculate", UIControlState.Normal);

            //create lable control with the specified properties
            var resultLabel = new UILabel(new CGRect(20, 124, View.Bounds.Width - 40, 40))
            {
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(24),
                Text = "Tip is $0.00",
            };

            //add all the child views (controls defined about) to screen (root view)
            View.AddSubviews(totalAmount, calcButton, resultLabel);


        }

    }
}
