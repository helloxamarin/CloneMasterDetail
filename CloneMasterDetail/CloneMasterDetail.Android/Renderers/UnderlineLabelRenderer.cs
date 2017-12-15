using Android.Graphics;
using Android.Widget;
using CloneMasterDetail.Droid.Renderers;
using CloneMasterDetail.Views.Components;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(UnderlineLabel), typeof(UnderlineLabelRenderer))]
namespace CloneMasterDetail.Droid.Renderers
{
    public class UnderlineLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Label element = e.NewElement;
            TextView control = Control;
            
            if (element != null && control != null)
            {
                control.PaintFlags |= PaintFlags.UnderlineText;
            }
        }
    }
}
