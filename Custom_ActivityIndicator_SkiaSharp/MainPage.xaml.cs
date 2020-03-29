using System.ComponentModel;
using System.Threading.Tasks;
using Custom_ActivityIndicator_SkiaSharp.Loader;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //first loader
            OneArc content1 = new OneArc();
            OneArcsContentView.Content = content1;

            //second loader
            TwoArcs content2 = new TwoArcs();
            TwoArcsContentView.Content = content2;

            //third loader
            ArcWithinArc content3 = new ArcWithinArc();
            ArcWithinArcContentView.Content = content3;

            //fourth loader
            TwoSepareteArcs content4 = new TwoSepareteArcs();
            TwoSeparateArcsContentView.Content = content4;

            //fifth loader
            FourArcs content5 = new FourArcs();
            FourArcsContentView.Content = content5;

            //sixth loader
            ThreeArcs content6 = new ThreeArcs();
            ThreeArcsContentView.Content = content6;

            //seventh loader
            ThreeArcsWithTwoInSamePosition content7 = new ThreeArcsWithTwoInSamePosition();
            ThreeArcsWithTwoInSamePositionContentView.Content = content7;

            if(Device.iOS == Device.RuntimePlatform)
            {
                row1.Height = 300;
                row2.Height = 300;
                row3.Height = 300;
                row4.Height = 300;
                row5.Height = 300;
                row6.Height = 300;
                row7.Height = 300;
            }

            arcFrame.TranslateTo(0, 0) ;

        }
            
        #region first loader tap functions
            //first loader tapped functions
            async void FirstLoaderFullScreen(System.Object sender, System.EventArgs e)
            {
                await Navigation.PushAsync(new SecondPage());
            }

            async void FirstLoaderPopup(System.Object sender, System.EventArgs e)
            {
                arcFrame.IsVisible = true; //visible the frame
                Scroll.ScrollToAsync(arcFrame, ScrollToPosition.Center, true); //scrolls so that the frame is at the center of the list
                MainContent.Opacity = 0.3; //set the main grid opacity to low
                MainContent.InputTransparent = true; //set the main grid not touchable
                OneArc page = new OneArc();
                frameArcContentView.Content = page;
                await Task.Delay(5000); //delay for 5 secs
                arcFrame.IsVisible = false; //hide the frame
                MainContent.Opacity = 1; //make back the opacity of main grid
                MainContent.InputTransparent = false; //make main grid touchable
            }
            #endregion

        #region Second loader tap functions
            //second loader tapped functions
            async void SecondLoaderFullScreen(System.Object sender, System.EventArgs e)
            {
                await Navigation.PushAsync(new SecondPage());
            }

            async void SecondLoaderPopup(System.Object sender, System.EventArgs e)
            {
                arcFrame.IsVisible = true; //visible the frame
                Scroll.ScrollToAsync(arcFrame, ScrollToPosition.Center, true); //scrolls so that the frame is at the center of the list 
                MainContent.Opacity = 0.3; //set the main grid opacity to low
                MainContent.InputTransparent = true; //set the main grid not touchable
                TwoArcs page = new TwoArcs();
                frameArcContentView.Content = page;
                await Task.Delay(5000); //delay for 5 secs
                arcFrame.IsVisible = false; //hide the frame
                MainContent.Opacity = 1; //make back the opacity of main grid
                MainContent.InputTransparent = false; //make main grid touchable
            }

            #endregion

        #region Third loader tap functions
            //second loader tapped functions
            async void ThirdLoaderFullScreen(System.Object sender, System.EventArgs e)
            {
                await Navigation.PushAsync(new ArcWithinArcPage());
            }

            async void ThirdLoaderPopup(System.Object sender, System.EventArgs e)
            {
                arcFrame.IsVisible = true; //visible the frame
                Scroll.ScrollToAsync(arcFrame, ScrollToPosition.Center, true); //scrolls so that the frame is at the center of the list
                MainContent.Opacity = 0.3; //set the main grid opacity to low
                MainContent.InputTransparent = true; //set the main grid not touchable
                ArcWithinArc page = new ArcWithinArc();
                frameArcContentView.Content = page;
                await Task.Delay(5000); //delay for 5 secs
                arcFrame.IsVisible = false; //hide the frame
                MainContent.Opacity = 1; //make back the opacity of main grid
                MainContent.InputTransparent = false; //make main grid touchable
            }

        #endregion

        #region Fourth loader tap functions
        //second loader tapped functions
        async void FourthLoaderFullScreen(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TwoSeparateArcsPage());
        }

        async void FourthLoaderPopup(System.Object sender, System.EventArgs e)
        {
            arcFrame.IsVisible = true; //visible the frame
            Scroll.ScrollToAsync(arcFrame, ScrollToPosition.Center, true); //scrolls so that the frame is at the center of the list
            MainContent.Opacity = 0.3; //set the main grid opacity to low
            MainContent.InputTransparent = true; //set the main grid not touchable
            TwoSepareteArcs page = new TwoSepareteArcs();
            frameArcContentView.Content = page;
            await Task.Delay(5000); //delay for 5 secs
            arcFrame.IsVisible = false; //hide the frame
            MainContent.Opacity = 1; //make back the opacity of main grid
            MainContent.InputTransparent = false; //make main grid touchable
        }

        #endregion

        #region Fifth loader tap functions
        //second loader tapped functions
        async void FifthLoaderFullScreen(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FourArcsPage());
        }

        async void FifthLoaderPopup(System.Object sender, System.EventArgs e)
        {
            arcFrame.IsVisible = true; //visible the frame
            Scroll.ScrollToAsync(arcFrame, ScrollToPosition.Center, true); //scrolls so that the frame is at the center of the list
            MainContent.Opacity = 0.3; //set the main grid opacity to low
            MainContent.InputTransparent = true; //set the main grid not touchable
            FourArcs page = new FourArcs();
            frameArcContentView.Content = page;
            await Task.Delay(5000); //delay for 5 secs
            arcFrame.IsVisible = false; //hide the frame
            MainContent.Opacity = 1; //make back the opacity of main grid
            MainContent.InputTransparent = false; //make main grid touchable
        }

        #endregion

        #region Sixth loader tap functions
        //second loader tapped functions
        async void SixthLoaderFullScreen(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FourthPage());
        }

        async void SixthLoaderPopup(System.Object sender, System.EventArgs e)
        {
            arcFrame.IsVisible = true; //visible the frame
            Scroll.ScrollToAsync(arcFrame, ScrollToPosition.Center, true); //scrolls so that the frame is at the center of the list
            MainContent.Opacity = 0.3; //set the main grid opacity to low
            MainContent.InputTransparent = true; //set the main grid not touchable
            ThreeArcs page = new ThreeArcs();
            frameArcContentView.Content = page;
            await Task.Delay(5000); //delay for 5 secs
            arcFrame.IsVisible = false; //hide the frame
            MainContent.Opacity = 1; //make back the opacity of main grid
            MainContent.InputTransparent = false; //make main grid touchable
        }

        #endregion

        #region Seventh loader tap functions
        //second loader tapped functions
        async void SeventhLoaderFullScreen(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThreeArcsWithTwoSamePositionPage());
        }

        async void SeventhLoaderPopup(System.Object sender, System.EventArgs e)
        {
            arcFrame.IsVisible = true; //visible the frame
            Scroll.ScrollToAsync(arcFrame, ScrollToPosition.Center, true); //scrolls so that the frame is at the center of the list
            MainContent.Opacity = 0.3; //set the main grid opacity to low
            MainContent.InputTransparent = true; //set the main grid not touchable
            ThreeArcsWithTwoInSamePosition page = new ThreeArcsWithTwoInSamePosition();
            frameArcContentView.Content = page;
            await Task.Delay(5000); //delay for 5 secs
            arcFrame.IsVisible = false; //hide the frame
            MainContent.Opacity = 1; //make back the opacity of main grid
            MainContent.InputTransparent = false; //make main grid touchable
        }

        #endregion
    }

}

