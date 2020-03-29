using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Custom_ActivityIndicator_SkiaSharp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new ThreeArcsWithTwoSamePositionPage();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
