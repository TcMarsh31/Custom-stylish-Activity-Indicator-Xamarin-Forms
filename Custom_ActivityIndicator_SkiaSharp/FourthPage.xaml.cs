using System;
using System.Collections.Generic;
using Custom_ActivityIndicator_SkiaSharp.Loader;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp
{
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ThreeArcs page = new ThreeArcs();
            ThreeArc.Content = page;
        }
    }
}
