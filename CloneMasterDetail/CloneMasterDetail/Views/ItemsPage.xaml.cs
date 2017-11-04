using System;
using CloneMasterDetail.Models;
using CloneMasterDetail.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneMasterDetail.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage
	{
	    private readonly ItemsViewModel _viewModel;

		public ItemsPage ()
		{
			InitializeComponent ();

		    BindingContext = _viewModel = new ItemsViewModel();
		}

	    private async void ItemsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        if (!(e.SelectedItem is Item item))
	            return;

	        await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

	        // Manually deselect item
	        ItemsListView.SelectedItem = null;
        }

	    private async void AddItem_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new NewItemPage());
	    }

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        if (_viewModel.Items.Count == 0)
                _viewModel.LoadItemsCommand.Execute(null);
	    }
	}
}