namespace SimpleLoginUI.Views.Dashboard;

public partial class PostingDetailsPage : ContentPage
{
	public PostingDetailsPage(PostingDetailsViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}