namespace SimpleLoginUI.Views.Dashboard;

public partial class PostingListPage : ContentPage
{
    private PostingListPageViewModel _viewMode;
    public PostingListPage(PostingListPageViewModel viewModel)
	{
		InitializeComponent();
        _viewMode = viewModel;
        this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewMode.GetPostingListCommand.Execute(null);
    }
}