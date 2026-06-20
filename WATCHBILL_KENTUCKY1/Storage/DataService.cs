using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
namespace KENTUCKY_WATCHBILL1.Storage
{
    public class DataService
    {
        private SQLiteAsyncConnection _database;

        public async Task Init()
        {
            if (_database != null) return;

            var path = Path.Combine(FileSystem.AppDataDirectory, "watchbill.db");
            _database = new SQLiteAsyncConnection(path);

            await _database.CreateTablesAsync<Quals,Section,User,SectionLeader>();
            //await TestingSection();
        }

        private async Task TestingSection()
        {
            var placeHolderUser = new User() { userName="a", userPassword="a"};
            var placeHolderSection = new Section() { };
            var placeHolderSectionLeader = new SectionLeader() { };
            var placeHolderQuals = new Quals() { };
            await AddUser(placeHolderUser);
        }

        public async Task AddUser(User user)
        {
            try
            {
                await Init();
                await _database.InsertAsync(user);
            }
            catch (Exception)
            {
                
                await Application.Current.Windows[0].Page.DisplayAlertAsync("Warning", "Error Entering User in Database", "ok");
                return;
            }
            
        }

        public async Task<List<User>> GetUsers()
        {
            await Init();
           var userList = await _database.Table<User>().ToListAsync();
            return userList;
        }

        public async Task<User> GetUser(string userName)
        {
            var user = await _database.Table<User>().FirstOrDefaultAsync(u => u.userName == userName);
            return user;
            
        }
    }
}
