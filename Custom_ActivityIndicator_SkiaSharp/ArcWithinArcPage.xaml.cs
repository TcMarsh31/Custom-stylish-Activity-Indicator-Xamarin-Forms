using System;
using System.Collections.Generic;
using Custom_ActivityIndicator_SkiaSharp.Loader;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp
{
    public partial class ArcWithinArcPage : ContentPage
    {
        public ArcWithinArcPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ArcWithinArc page = new ArcWithinArc();
            ArcWithinArcContentView.Content = page;
        }
    }
}
