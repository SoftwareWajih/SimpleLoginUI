namespace SimpleLoginUI.ViewModels.Dashboard
{
    [QueryProperty(nameof(PostingDetail), "PostingDetail")]
    public partial class PostingDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Posting _postingDetail = new Posting();

        public ObservableCollection<Posting> Postings { get; set; } = new ObservableCollection<Posting>();

    }
}
