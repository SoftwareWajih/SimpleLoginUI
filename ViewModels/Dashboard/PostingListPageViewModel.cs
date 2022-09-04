namespace SimpleLoginUI.ViewModels.Dashboard
{
    public partial class PostingListPageViewModel : ObservableObject
    {
        public static List<Posting> PostingListForSearch { get; private set; } = new List<Posting>();
        public ObservableCollection<Posting> Postings { get; set; } = new ObservableCollection<Posting>();

        private readonly ITajjarService _tajjarService;

        public PostingListPageViewModel(ITajjarService tajjarService)
        {
            _tajjarService = tajjarService;
        }

        [ICommand]
        public async void GetPostingList()
        {
            Postings.Clear();
            var postingList = await _tajjarService.GetPostingList();
            if (postingList?.Count > 0)
            {
                foreach (var posting in postingList)
                {
                    Postings.Add(posting);
                }
                PostingListForSearch.Clear();
                PostingListForSearch.AddRange(postingList);
            }
        }

        [ICommand]
        public async void AddUpdatePosting()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdatePostingDetail));
        }

        [ICommand]
        public async void DisplayAction(Posting postingModel)
        {
            var response = await AppShell.Current.DisplayActionSheet("Select Option", "OK", null, "Details", "Edit", "Delete");
            if (response == "Details")
            {
                var navParam = new Dictionary<string, object>
                {
                    { "PostingDetail", postingModel }
                };
                await AppShell.Current.GoToAsync(nameof(PostingDetailsPage), navParam);
            }
            else if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>
                {
                    { "PostingDetail", postingModel }
                };
                await AppShell.Current.GoToAsync(nameof(AddUpdatePostingDetail), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse = await _tajjarService.DeletePosting(postingModel);
                if (delResponse > 0)
                {
                    GetPostingList();
                }
            }
        }

    }
}
