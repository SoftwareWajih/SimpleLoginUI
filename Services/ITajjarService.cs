namespace SimpleLoginUI.Services
{
    public interface ITajjarService
    {
        Task<List<Posting>> GetPostingList();
        Task<int> AddPosting(Posting postingModel);
        Task<int> DeletePosting(Posting postingModel);
        Task<int> UpdatePosting(Posting postingModel);
    }
}
