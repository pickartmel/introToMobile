using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RoundedCorners3.Custom;
using RoundedCorners3.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ImageBox), typeof(ImageBoxRenderer))]

namespace RoundedCorners3.Droid.Custom
{
    class ImageBoxRenderer : ImageRenderer
    {
        protected override bool DrawChild(Canvas canvas, Android.Views.View child, long drawingTime)
        {
            try
            {
                //clip path
                var radius = 25.0f;
                var path = new Path();
                RectF rect = new RectF(0, 0, Width, Height);
                path.AddRoundRect(rect, radius, radius, Path.Direction.Cw);
                canvas.Save();
                canvas.ClipPath(path);
                var result = base.DrawChild(canvas, child, drawingTime);
                canvas.Restore();

                //create border
                path = new Path();
                path.AddRoundRect(rect, radius, radius, Path.Direction.Cw);
                var paint = new Paint();
                paint.AntiAlias = true;
                paint.StrokeWidth = 1;
                paint.SetStyle(Paint.Style.Stroke);
                paint.Color = global::Android.Graphics.Color.Rgb(11, 11, 14);
                canvas.DrawPath(path, paint);

                //clean up
                paint.Dispose();
                path.Dispose();

                return result;
            }
            catch { }


            return base.DrawChild(canvas, child, drawingTime);
        }
    }
}