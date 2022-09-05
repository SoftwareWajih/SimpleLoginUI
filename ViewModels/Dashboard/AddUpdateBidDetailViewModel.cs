namespace SimpleLoginUI.ViewModels.Dashboard
{
    [QueryProperty(nameof(BidDetail), "BidDetail")]
    public partial class AddUpdateBidDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private Bid _bidDetail = new Bid();

        private readonly ITajjarService _tajjarService;

        //public List<LoadPicker> LoadPicker { get; set; }

        //public List<BidTypePicker> BidTypePickers { get; set; }


        public AddUpdateBidDetailViewModel(ITajjarService tajjarService)
        {
            _tajjarService = tajjarService;

            ////Select Picker
            //LoadPicker = new List<LoadPicker>();
            //LoadPicker.Add(new LoadPicker() { LoadId = 1, LoadName = "Containerized" });
            //LoadPicker.Add(new LoadPicker() { LoadId = 2, LoadName = "Break Bulk" });
            //LoadPicker.Add(new LoadPicker() { LoadId = 3, LoadName = "Bulk" });

            //BidTypePickers = new List<BidTypePicker>
            //{
            //    new BidTypePicker() { BidTypeId = 1 , BidTypeName = "General" },
            //    new BidTypePicker() { BidTypeId = 2 , BidTypeName = "Export" },
            //    new BidTypePicker() { BidTypeId = 3 , BidTypeName = "Import" }
            //};

        }

        //public LoadPicker _lpInfo;
        //public BidTypePicker _ptInfo;

        //public LoadPicker SelectedLoad
        //{
        //    get { return _lpInfo; }
        //    set { _lpInfo = value; }
        //}

        //public BidTypePicker SelectedTypePicer
        //{
        //    get { return _ptInfo; }
        //    set { _ptInfo = value; }
        //}


        [ICommand]
        public async void AddUpdateBid()
        {
            if (!string.IsNullOrWhiteSpace(BidDetail.Cost.ToString()) && !string.IsNullOrWhiteSpace(BidDetail.PostingId.ToString()))
            {
                AddUpdateBidDetails();
            }
            else
            {
                await Shell.Current.DisplayAlert("Warning!", "Please Enter Required Fields", "OK");
            }
        }

        public async void AddUpdateBidDetails()
        {
            int response = -1;
            if (BidDetail.BidId > 0)
            {
                response = await _tajjarService.UpdateBid(BidDetail);
            }
            else
            {
                
                //var loadType = SelectedLoad.LoadName.ToString();
                //var BidType = SelectedTypePicer.BidTypeName.ToString();

                response = await _tajjarService.AddBid(new Bid
                {
                    PostingId = BidDetail.PostingId,
                    Cost = BidDetail.Cost,
                    Status = "Pending",
                    Details = BidDetail.Details
                });
            }



            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Info Saved", "Record Saved", "OK");
                await Shell.Current.GoToAsync($"BidListPage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Heads Up!", "Something went wrong while adding record", "OK");
            }
        }
    }
}
