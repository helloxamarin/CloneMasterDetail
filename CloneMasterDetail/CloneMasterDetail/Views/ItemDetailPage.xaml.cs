using System;
using CloneMasterDetail.Models;
using CloneMasterDetail.Services;
using CloneMasterDetail.ViewModels;
using CloneMasterDetail.Views.Components;
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

        private void UnderlineLabel_Tapped(object sender, EventArgs e)
        {
            var label = sender as UnderlineLabel;
            DependencyService.Get<ITextToSpeech>().Speak(label.Text);
        }
    }
}