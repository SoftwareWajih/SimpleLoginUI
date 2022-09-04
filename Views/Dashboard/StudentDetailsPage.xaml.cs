namespace SimpleLoginUI.Views.Dashboard;

public partial class StudentDetailsPage : ContentPage
{
	public StudentDetailsPage(StudentDetailsViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}