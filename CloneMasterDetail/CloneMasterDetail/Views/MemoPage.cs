using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CloneMasterDetail.Views
{
	public class MemoPage : ContentPage
	{
		public MemoPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Unsupported Page" }
				}
			};
		}
	}
}