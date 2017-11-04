using System;
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

	    private void ItemsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
            //TODO
	        throw new NotImplementedException();
	    }

	    private void AddItem_OnClicked(object sender, EventArgs e)
	    {
            //TODO
	        throw new NotImplementedException();
	    }

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        if (_viewModel.Items.Count == 0)
                _viewModel.LoadItemsCommand.Execute(null);
	    }
	}
}