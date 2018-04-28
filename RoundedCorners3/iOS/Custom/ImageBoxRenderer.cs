using System;
using Xamarin.Forms;
using RoundedCorners3.Custom;
using RoundedCorners3.iOS.Custom;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ImageBox),typeof(ImageBoxRenderer))]
namespace RoundedCorners3.iOS.Custom
{
    public class ImageBoxRenderer : ImageRenderer
    {
        public ImageBoxRenderer()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }
            CreateBox();
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName==VisualElement.HeightProperty.PropertyName || 
                e.PropertyName == VisualElement.WidthProperty.PropertyName)
            {
                CreateBox();
            }
        }

        private void CreateBox()
        {
            try
            {
                Control.Layer.CornerRadius = 10.0f;
                Control.Layer.MasksToBounds = false;
                Control.Layer.BorderColor = Xamarin.Forms.Color.FromHex("1B1D24").ToCGColor();
                Control.Layer.BorderWidth = 1;
                Control.ClipsToBounds = true;
            }
            catch {}

        }
    }
}
