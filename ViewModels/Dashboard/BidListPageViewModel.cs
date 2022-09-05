namespace SimpleLoginUI.ViewModels.Dashboard
{
    public partial class BidListPageViewModel : ObservableObject
    {
        public static List<Bid> BidListForSearch { get; private set; } = new List<Bid>();
        public ObservableCollection<Bid> Bids { get; set; } = new ObservableCollection<Bid>();

        private readonly ITajjarService _tajjarService;

        public BidListPageViewModel(ITajjarService tajjarService)
        {
            _tajjarService = tajjarService;
        }

        [ICommand]
        public async void GetBidList()
        {
            Bids.Clear();
            var BidList = await _tajjarService.GetBidList();
            if (BidList?.Count > 0)
            {
                foreach (var Bid in BidList)
                {
                    Bids.Add(Bid);
                }
                BidListForSearch.Clear();
                BidListForSearch.AddRange(BidList);
            }
        }

        [ICommand]
        public async void AddUpdateBid()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdateBidDetail));
        }

        [ICommand]
        public async void DisplayAction(Bid BidModel)
        {
            var response = await AppShell.Current.DisplayActionSheet("Select Option", "OK", null, "Details", "Edit", "Delete");
            if (response == "Details")
            {
                var navParam = new Dictionary<string, object>
                {
                    { "BidDetail", BidModel }
                };
                await AppShell.Current.GoToAsync(nameof(BidDetailsPage), navParam);
            }
            else if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>
                {
                    { "BidDetail", BidModel }
                };
                await AppShell.Current.GoToAsync(nameof(AddUpdateBidDetail), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse = await _tajjarService.DeleteBid(BidModel);
                if (delResponse > 0)
                {
                    GetBidList();
                }
            }
        }

}
}
