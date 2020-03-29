using System;
using System.Collections.Generic;
using System.Diagnostics;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Custom_ActivityIndicator_SkiaSharp.Loader
{
    public partial class ThreeArcs : ContentView
    {
        SKCanvasView canvasView; //canvasview variable surface we will be drawing
        bool isAnimating;
        Stopwatch stopwatch = new Stopwatch(); //stopwatch to start the timer to render the animation

        float firstOvalStartAngle = 90; //outer arc start angle
        float firstOvalSweepAngle = 100; //outer arcg sweep angle from the start angle position

        float secondOvalStartAngle = 90; //middle arc start angle
        float secondOvalSweepAngle = 90; //middle arc sweep angle from the start angle position

        float thirdOvalStartAngle = 90; //inner arc start angle
        float thirdOvalSweepAngle = 80; //inner arc sweep angle from the start angle postion


        /// <summary>
        /// outer arc paint style
        /// defined the style as stroke
        /// color of the stroke using hsl format * you can change the color code here*
        /// width of the outer arc
        /// </summary>
        SKPaint firstArcPaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,

            Color = SKColor.FromHsl(339, 66, 33),
            StrokeWidth = 25,
            IsAntialias = true,
            StrokeCap = SKStrokeCap.Round

        };

        /// <summary>
        /// middle arc paint style
        /// defined the style as stroke
        /// color of the stroke using hsl format * you can change the color code here*
        /// width of the middle arc
        /// </summary>
        SKPaint secondArcPaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,

            Color = SKColor.FromHsl(339, 67, 44),
            StrokeWidth = 25,
            IsAntialias = true,
            StrokeCap = SKStrokeCap.Round

        };

        /// <summary>
        /// inner arc paint style
        /// defined the style as stroke
        /// color of the stroke using hsl format * you can change the color code here*
        /// width of the inner arc
        /// </summary>
        SKPaint thirdArcPaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,

            Color = SKColor.FromHsl(339, 81, 55),
            StrokeWidth = 25,
            IsAntialias = true,
            StrokeCap = SKStrokeCap.Round

        };

        public ThreeArcs()
        {
            InitializeComponent();
            canvasView = new SKCanvasView(); //canvas surface initialized
            canvasView.PaintSurface += OnCanvasViewPaintSurface; //this method will be trigered at the start of the app to draw in canvas surface
            Content = canvasView; //set the canvas view to the content so it get displayed in the screen
            isAnimating = true; //make animation true so timer gets running every 20ms
            stopwatch.Start(); //start the stop watch
            Device.StartTimer(TimeSpan.FromMilliseconds(20), OnTimerTick); //timer has been set to every 20ms to trigger OnTimerTick method

        }

        bool OnTimerTick()
        {
            firstOvalStartAngle += 5; //outer arc start angle will be increased by 5 every 20ms
            secondOvalStartAngle += 3; //middle arc start angle will be increased by 3 every 20ms
            thirdOvalStartAngle += 2; //inner arc start angle will be increased by 2 every 20ms
            canvasView.InvalidateSurface(); //redraw the surface with new values

            return isAnimating;
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            /*
             * 500 is the diameter of the outer arc
             * each inner arc from the outer arc will get reduced by 50
             *you can change the value according to make the arc smaller or bigger
             * */

            float left, right;
            float top, bottom;
            right = left = (info.Width - 500) / 2; //get the left and right postions to support all the devices
            top = bottom = (info.Height - 500) / 2;//get the top and bottom postions to support all the devices

            //first Arc
            SKRect rect = new SKRect(left, top, info.Width - right, info.Height - bottom);

            using (SKPath path = new SKPath())
            {
                path.AddArc(rect, firstOvalStartAngle, firstOvalSweepAngle);
                canvas.DrawPath(path, firstArcPaint);
            }

            //second Arc
            SKRect rect2 = new SKRect(left + 50, top + 50, (info.Width - right) - 50, (info.Height - bottom) - 50);

            using (SKPath path = new SKPath())
            {
                path.AddArc(rect2, secondOvalStartAngle, secondOvalSweepAngle);
                canvas.DrawPath(path, secondArcPaint);
            }

            //third Arc
            SKRect rect3 = new SKRect(left + 100, top + 100, (info.Width - right) - 100, (info.Height - bottom) - 100);

            using (SKPath path = new SKPath())
            {
                path.AddArc(rect3, thirdOvalStartAngle, thirdOvalSweepAngle);
                canvas.DrawPath(path, thirdArcPaint);
            }


        }
    }
}
