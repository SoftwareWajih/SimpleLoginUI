namespace SimpleLoginUI.Views.Dashboard;

public partial class BidDetailsPage : ContentPage
{
	public BidDetailsPage(BidDetailsViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}