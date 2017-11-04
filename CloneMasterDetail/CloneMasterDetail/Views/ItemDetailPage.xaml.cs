using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneMasterDetail.Models;
using CloneMasterDetail.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneMasterDetail.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{
	    // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
	    public ItemDetailPage()
	    {
	        InitializeComponent();

	        var item = new Item
	        {
	            Text = "Example Item",
	            Description = "This is an example item description for previewer."
	        };

	        var viewModel = new ItemDetailViewModel(item);
	        BindingContext = viewModel;
	    }

	    public ItemDetailPage(ItemDetailViewModel viewModel)
	    {
	        InitializeComponent();

	        BindingContext = viewModel;
	    }
    }
}