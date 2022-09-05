namespace SimpleLoginUI.Services
{
    public interface ITajjarService
    {
        #region Posting
        Task<List<Posting>> GetPostingList();
        Task<int> AddPosting(Posting postingModel);
        Task<int> DeletePosting(Posting postingModel);
        Task<int> UpdatePosting(Posting postingModel);
        #endregion

        #region Bid
        Task<List<Bid>> GetBidList();
        Task<int> AddBid(Bid bidModel);
        Task<int> DeleteBid(Bid bidModel);
        Task<int> UpdateBid(Bid bidModel);
        #endregion

    }
}
