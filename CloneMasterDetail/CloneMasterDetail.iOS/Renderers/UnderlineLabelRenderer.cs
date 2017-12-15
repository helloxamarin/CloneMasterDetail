using System;
using System.Collections.Generic;
using System.Text;
using CloneMasterDetail.iOS.Renderers;
using CloneMasterDetail.Views.Components;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(UnderlineLabel), typeof(UnderlineLabelRenderer))]
namespace CloneMasterDetail.iOS.Renderers
{
    public class UnderlineLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var label = Control;
            var text = label.AttributedText as NSMutableAttributedString;
            var range = new NSRange(0, text.Length);
            
            text.AddAttribute(UIStringAttributeKey.UnderlineStyle, NSNumber.FromInt32((int)NSUnderlineStyle.Single), range);
            
        }
    }
}
