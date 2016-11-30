using DevDays.Renderers.Controls;
using DevDays.Renderers.iOS.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Image), typeof(ExtendedImageRenderer))]
namespace DevDays.Renderers.iOS.Controls
{
    public class ExtendedImageRenderer : ImageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            SetImageColor();
        }

        private void SetImageColor()
        {
            var element = (ExtendedImage)Element;

            if (element != null && Control != null)
            {
                Control.Image = Control.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
                Control.TintColor = Color.Red.ToUIColor();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ExtendedImage.ImageColorProperty.PropertyName)
            {
                SetImageColor();
            }
        }
    }
}