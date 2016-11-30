using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DevDays.Renderers.Droid.Controls;
using Android.Graphics;
using DevDays.Renderers.Controls;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(ExtendedImage), typeof(ExtendedImageRenderer))]
namespace DevDays.Renderers.Droid.Controls
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
                Control.SetColorFilter(element.ImageColor.ToAndroid(), Android.Graphics.PorterDuff.Mode.SrcAtop); 
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