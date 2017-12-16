using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using CloneMasterDetail.UWP.Renderers;
using CloneMasterDetail.Views.Components;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(UnderlineLabel), typeof(UnderlineLabelRenderer))]
namespace CloneMasterDetail.UWP.Renderers
{
    public class UnderlineLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (!(Control is TextBlock control)) return;
            var underline = new Underline();
            var run = new Run {Text = control.Text};
            control.Text = "";
            control.Inlines.Clear();
            underline.Inlines.Add(run);
            control.Inlines.Add(underline);
        }
    }
}
