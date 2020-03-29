using System;
using System.Collections.Generic;
using Custom_ActivityIndicator_SkiaSharp.Loader;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp
{
    public partial class ThreeArcsWithTwoSamePositionPage : ContentPage
    {
        public ThreeArcsWithTwoSamePositionPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ThreeArcsWithTwoInSamePosition page = new ThreeArcsWithTwoInSamePosition();
            ThreeArcWithTwoSamePositionContentView.Content = page;
        }
    }
}
