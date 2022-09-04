namespace SimpleLoginUI.Views.Dashboard;

public partial class AddUpdatePostingDetail : ContentPage
{


	public AddUpdatePostingDetail(AddUpdatePostingDetailViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}