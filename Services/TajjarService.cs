using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginUI.Services
{
    public class TajjarService : ITajjarService
    {
        private SQLiteAsyncConnection _dbConnection;

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TajjarulBahar.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Posting>();
            }
        }
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
    }
}
