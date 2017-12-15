using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Label element = e.NewElement;
            TextBlock control = Control;
            
            if (element != null && control != null)
            {
                Underline underline = new Underline();
                Run run = new Run {Text = control.Text};
                control.Text = "";
                control.Inlines.Clear();
                underline.Inlines.Add(run);
                control.Inlines.Add(underline);
            }
        }
    }
}
