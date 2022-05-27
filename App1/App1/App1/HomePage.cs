using App1.CustomControls;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public class HomePage: ContentPage
    {
        public HomePage()
        {
            var label = new Label
            {
                Text = "Label Shadow Effect",
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Color color = Color.Default;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    color = Color.Black;
                    break;
                case Device.Android:
                    color = Color.Black;
                    break;
                case Device.UWP:
                    color = Color.Red;
                    break;
            }

            label.Effects.Add(new CustomLabel
            {
                Radius = 5,
                Color = color,
                DistanceX = 5,
                DistanceY = 5
            }); ;
        }
    }
}
