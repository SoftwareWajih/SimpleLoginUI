namespace SimpleLoginUI.Services
{
    public class TajjarService : ITajjarService
    {
        #region Variables
        private SQLiteAsyncConnection _dbConnection;
        #endregion

        #region Main
        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TajjarulBahar.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Posting>();
                await _dbConnection.CreateTableAsync<Bid>();
            }
        }

        //private async Task SetUpDbBid()
        //{
        //    if (_dbConnection == null)
        //    {
        //        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TajjarulBahar.db3");
        //        _dbConnection = new SQLiteAsyncConnection(dbPath);
        //        await _dbConnection.CreateTableAsync<Posting>();
        //    }
        //}
        #endregion

        #region Posting
        public async Task<int> AddPosting(Posting postingModel)
        {
            await SetUpDb();
            return await _dbConnection.InsertAsync(postingModel);
        }

        public async Task<int> DeletePosting(Posting postingModel)
        {
            await SetUpDb();
            return await _dbConnection.DeleteAsync(postingModel);
        }

        public async Task<List<Posting>> GetPostingList()
        {
            await SetUpDb();
            var studentList = await _dbConnection.Table<Posting>().ToListAsync();
            return studentList;
        }

        public async Task<int> UpdatePosting(Posting postingModel)
        {
            await SetUpDb();
            return await _dbConnection.UpdateAsync(postingModel);
        }
        #endregion

        #region Bid
        public async Task<int> AddBid(Bid BidModel)
        {
            await SetUpDb();
            return await _dbConnection.InsertAsync(BidModel);
        }

        public async Task<int> DeleteBid(Bid BidModel)
        {
            await SetUpDb();
            return await _dbConnection.DeleteAsync(BidModel);
        }

        public async Task<List<Bid>> GetBidList()
        {
            await SetUpDb();
            var studentList = await _dbConnection.Table<Bid>().ToListAsync();
            return studentList;
        }

        public async Task<int> UpdateBid(Bid BidModel)
        {
            await SetUpDb();
            return await _dbConnection.UpdateAsync(BidModel);
        }
        #endregion

    }
}
