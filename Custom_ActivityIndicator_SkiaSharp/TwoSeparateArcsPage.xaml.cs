using System;
using System.Collections.Generic;
using Custom_ActivityIndicator_SkiaSharp.Loader;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp
{
    public partial class TwoSeparateArcsPage : ContentPage
    {
        public TwoSeparateArcsPage()
        {
            InitializeComponent();
            TwoSepareteArcs page = new TwoSepareteArcs();
            TwoSeparateArcsContentView.Content = page;
        }
    }
}
