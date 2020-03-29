using System;
using System.Collections.Generic;
using Custom_ActivityIndicator_SkiaSharp.Loader;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TwoArcs page = new TwoArcs();
            DoubleArc.Content = page;
        }
    }
}
