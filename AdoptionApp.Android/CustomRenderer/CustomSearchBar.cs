using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdoptionApp.Control;
using AdoptionApp.Droid.CustomRenderer;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly:ExportRenderer(typeof(Xamarin.Forms.SearchBar), typeof(CustomSearchBar), new[] { typeof(CustomVisual) })]
namespace AdoptionApp.Droid.CustomRenderer
{
    public class CustomSearchBar : SearchBarRenderer
    {
        public CustomSearchBar(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(60f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.Transparent);

                
                Control.SetBackground(gradientDrawable);
            }

   
        }
    }
}