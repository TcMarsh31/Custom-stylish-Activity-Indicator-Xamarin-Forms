using System;
using System.Collections.Generic;
using Custom_ActivityIndicator_SkiaSharp.Loader;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp
{
    public partial class FourArcsPage : ContentPage
    {
        public FourArcsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FourArcs page = new FourArcs();
            FourArcContentView.Content = page;
        }
    }
}
