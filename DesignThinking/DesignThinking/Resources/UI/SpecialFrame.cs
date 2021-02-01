using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DesignThinking.Resources.UI
{
    public class SpecialFrame : Frame
    {
        public static readonly BindableProperty ShadowColorProperty = BindableProperty.Create(nameof(ShadowColor), typeof(Color), typeof(SpecialFrame), Color.Transparent);
        public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create(nameof(BorderWidth), typeof(float), typeof(SpecialFrame));

        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }


        public float BorderWidth
        {
            get { return (float)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }
    }
}
