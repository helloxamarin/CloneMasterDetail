using System;
using Xamarin.Forms;

namespace CloneMasterDetail.Views.Components
{
    public class UnderlineLabel : Label
    {
        public event EventHandler Tapped;

        public UnderlineLabel()
        {
            var tabGestureRecognizer = new TapGestureRecognizer();
            tabGestureRecognizer.Tapped += (sender, args) => RaiseTapped();
            GestureRecognizers.Add(tabGestureRecognizer);
        }

        public void RaiseTapped() => Tapped?.Invoke(this, EventArgs.Empty);
    }
}
