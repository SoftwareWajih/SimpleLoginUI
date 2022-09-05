namespace SimpleLoginUI.ViewModels.Dashboard
{
    [QueryProperty(nameof(BidDetail), "BidDetail")]
    public partial class BidDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Bid _bidDetail = new Bid();

        public ObservableCollection<Bid> Bids { get; set; } = new ObservableCollection<Bid>();
    }
}
