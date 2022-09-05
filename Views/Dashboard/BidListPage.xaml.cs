namespace SimpleLoginUI.Views.Dashboard;

public partial class BidListPage : ContentPage
{
    private BidListPageViewModel _viewMode;
    public BidListPage(BidListPageViewModel viewModel)
    {
        InitializeComponent();
        _viewMode = viewModel;
        this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewMode.GetBidListCommand.Execute(null);
    }
}