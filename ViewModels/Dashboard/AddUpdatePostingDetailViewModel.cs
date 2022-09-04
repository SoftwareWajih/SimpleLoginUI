namespace SimpleLoginUI.ViewModels.Dashboard
{
    [QueryProperty(nameof(PostingDetail), "PostingDetail")]
    public partial class AddUpdatePostingDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private Posting _postingDetail = new Posting();

        private readonly ITajjarService _tajjarService;

        public List<LoadPicker> LoadPicker { get; set; }

        public List<PostingTypePicker> PostingTypePickers { get; set; }


        public AddUpdatePostingDetailViewModel(ITajjarService tajjarService)
        {
            _tajjarService = tajjarService;

            //Select Picker
            LoadPicker = new List<LoadPicker>();
            LoadPicker.Add(new LoadPicker() { LoadId = 1 , LoadName = "Containerized" });
            LoadPicker.Add(new LoadPicker() { LoadId = 2 , LoadName = "Break Bulk" });
            LoadPicker.Add(new LoadPicker() { LoadId = 3 , LoadName = "Bulk" });

            PostingTypePickers = new List<PostingTypePicker>
            {
                new PostingTypePicker() { PostingTypeId = 1 , PostingTypeName = "General" },
                new PostingTypePicker() { PostingTypeId = 2 , PostingTypeName = "Export" },
                new PostingTypePicker() { PostingTypeId = 3 , PostingTypeName = "Import" }
            };

        }

        public LoadPicker _lpInfo;
        public PostingTypePicker _ptInfo;

        public LoadPicker SelectedLoad
        {
            get { return _lpInfo; }
            set{ _lpInfo = value; }
        }

        public PostingTypePicker SelectedTypePicer
        {
            get { return _ptInfo; }
            set { _ptInfo = value; }
        }


        [ICommand]
        public async void AddUpdatePosting()
        {
            if (!string.IsNullOrWhiteSpace(PostingDetail.Pickup) && !string.IsNullOrWhiteSpace(PostingDetail.Dropoff))
            {
                AddUpdatePostingDetails();
            }
            else
            {
                await Shell.Current.DisplayAlert("Warning!", "Please Enter Required Fields", "OK");
            }
        }

        public async void AddUpdatePostingDetails()
        {
            int response = -1;
            if (PostingDetail.PostingId > 0)
            {
                response = await _tajjarService.UpdatePosting(PostingDetail);
            }
            else
            {
                //int loadId = Int32.Parse(SelectedLoad.LoadName.ToString());
                var loadType = SelectedLoad.LoadName.ToString();
                var postingType = SelectedTypePicer.PostingTypeName.ToString();

                response = await _tajjarService.AddPosting(new Posting
                {
                    Pickup = PostingDetail.Pickup,
                    Dropoff = PostingDetail.Dropoff,
                    LoadType = loadType,
                    PostingType = postingType
                });
            }



            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Info Saved", "Record Saved", "OK");
                await Shell.Current.GoToAsync($"PostingListPage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Heads Up!", "Something went wrong while adding record", "OK");
            }
        }

    }
}
