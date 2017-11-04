using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneMasterDetail.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneMasterDetail.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewItemPage : ContentPage
	{
        public Item Item { get; set; }

		public NewItemPage ()
		{
			InitializeComponent ();

		    Item = new Item
		    {
		        Text = "Item name",
		        Description = "This is an item description"
		    };

		    BindingContext = this;
		}

	    private async void Save_Clicked(object sender, EventArgs e)
	    {
	        MessagingCenter.Send(this, "AddItem", Item);
	        await Navigation.PopToRootAsync();
	    }
	}
}