using SQLite;
using System.Threading.Tasks;
using WatchModel;

namespace MauiApp1.Services
{
    public class DataService
    {
        private SQLiteAsyncConnection _database;

        private async Task Init()
        {
            if (_database != null)
            {
                return;
            }

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "watchbill.db");


            _database = new SQLiteAsyncConnection(dbPath);

            await _database.CreateTableAsync<Personel.Personel>();
            await _database.CreateTableAsync<WatchModel.Watchbill>();
            await _database.CreateTableAsync<WatchTask.WatchAssingnment>();
        }



        public async Task<string> GetDataPath()
        {
            await Init();

            var dbpath = Path.Combine(FileSystem.AppDataDirectory, "watchbill.db");
            return dbpath;
        }
        public async Task<List<Personel.Personel>> GetAllPersonelAsync()
        {
            await Init();

            return await _database.Table<Personel.Personel>().ToListAsync();
        }

        public async Task<int> AddPersonelAsync(Personel.Personel personel)
        {
            await Init();

            return await _database.InsertAsync(personel);
        }

        public async Task<int> UpdatePersonelAsync(Personel.Personel person)
        {
            await Init();

            return await _database.UpdateAsync(person);
        }

        public async Task<int> DeletePersonelAsync(Personel.Personel person)

        {
            await Init();

            return await _database.DeleteAsync(person);
        }
        //watch assingment


       
        public async Task<List<WatchModel.Watchbill>>GetWatchbills()
            {
            await Init();

            return await _database.Table<WatchModel.Watchbill>().ToListAsync(); 
            }
        public async Task<int> AddWatchbill(WatchModel.Watchbill Watchbill)
        {
            await Init();
            return await _database.InsertAsync(Watchbill);
        }
        public async Task<int> UpdateWatchbill(WatchModel.Watchbill Watchbill)
        {
            await Init();

            return await _database.UpdateAsync(Watchbill);
        }

        public async Task<int> RemoveWatchbill(WatchModel.Watchbill Watchbill)
        {
            await Init();
            return await _database.DeleteAsync(Watchbill);
        }

        public async Task<List<WatchTask.WatchAssingnment>> GetWatchAssignment()
        {
            await Init();
            return await _database.Table<WatchTask.WatchAssingnment>().ToListAsync();
        }
        public async Task<int> AddWatch(WatchTask.WatchAssingnment Watch)
        {
            await Init();
            return await _database.InsertAsync(Watch);
        }
        public async Task<int> UpdateWatch(WatchTask.WatchAssingnment Watch)
        {
            await Init();
            return await _database.UpdateAsync(Watch);
        }

        public async Task<int> RemoveWatch(WatchTask.WatchAssingnment Watch)
        {
            await Init();
            return await _database.DeleteAsync(Watch);
        }
    }
}