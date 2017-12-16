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

            if (e.NewElement is ContentPage element)
                element.Content = null;
            
            this.SetNativeControl(new InkCanvasMemoPage());
        }
    }
}
