namespace SimpleLoginUI.Views.Dashboard;

public partial class AddUpdateBidDetail : ContentPage
{
	public AddUpdateBidDetail(AddUpdateBidDetailViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}