using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneMasterDetail.UWP.Renderers;
using CloneMasterDetail.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;



[assembly: ExportRenderer(typeof(MemoPage), typeof(MemoPageRenderer))]
namespace CloneMasterDetail.UWP.Renderers
{
    public class MemoPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as ContentPage;
            element.Content = null;
            
            this.SetNativeControl(new InkCanvasMemoPage());
        }
    }
}
