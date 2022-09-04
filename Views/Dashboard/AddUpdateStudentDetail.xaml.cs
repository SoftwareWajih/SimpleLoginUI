namespace SimpleLoginUI.Views.Dashboard;

public partial class AddUpdateStudentDetail : ContentPage
{
	public AddUpdateStudentDetail(AddUpdateStudentDetailViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}