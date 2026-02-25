using SQLite;
using System.Threading.Tasks;

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

        public async Task<int> UpdatePersonelAsync (Personel.Personel person)
        {
            await Init();

            return await _database.UpdateAsync(person);
        }

        public async Task<int> DeletePersonelAsync (Personel.Personel person)

        {
            await Init();

            return await _database.DeleteAsync(person);
        }
    }
}