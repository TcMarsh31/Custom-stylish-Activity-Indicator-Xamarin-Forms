using System;

using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp.Loader
{
    public class OneArc : ContentPage
    {
        public OneArc()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

