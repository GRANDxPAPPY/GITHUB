using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
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

            await _database.CreateTablesAsync<Quals, Section, User, SectionLeader>();
            await TestingSection();
        }

        private async Task TestingSection()
        {
            var holdingUserList = await GetUsers();
            if (holdingUserList.Count() < 1)
            {
                var placeHolderUser = new User() { userName = "a", userPassword = "a", role = "WBC", sailorName = "cape", sectionId = 1 };
                var placeHolderSection = new Section() { sectionName = "1" }; 
                var placeHolderSectionLeader = new SectionLeader() { };
                var placeHolderQuals = new Quals() { };
                await AddSection(placeHolderSection);
                await AddUser(placeHolderUser);
                
            }


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
        public async Task<User> GetUserById(int userId)
        {
            var user = await _database.Table<User>().FirstOrDefaultAsync(u => u.userId == userId);
            return user;

        }


        public async Task EditUser(User user)
        {
            try
            {
                await Init();
                await _database.UpdateAsync(user);
            }
            catch (Exception)
            {
                await Application.Current.Windows[0].Page.DisplayAlertAsync("Warning", "Error Updating User in Database", "ok");
                return;

            }
        }
        public async Task DeleteUser(User user)
        {
            try
            {
                await Init();
                await _database.DeleteAsync(user);
            }
            catch (Exception)
            {
                await Application.Current.Windows[0].Page.DisplayAlertAsync("Warning", "Error Updating User in Database", "ok");
                return;

            }
        }

        //Section
        public async Task AddSection(Section section)
        {
            try
            {
                await Init();
                await _database.InsertAsync(section);
            }
            catch (Exception)
            {

                await Application.Current.Windows[0].Page.DisplayAlertAsync("Warning", "Error Entering Section in Database", "ok");
                return;
            }
        }

        public async Task EditSection(Section section)
        {
            try
            {
                await Init();
                await _database.UpdateAsync(section);
            }
            catch (Exception)
            {

                await Application.Current.Windows[0].Page.DisplayAlertAsync("Warning", "Error Updating Section in Database", "ok");
                return;
            }
        }

        public async Task DeleteSection(Section section)
        {
            try
            {
                await Init();
                await _database.DeleteAsync(section);
            }
            catch (Exception)
            {

                await Application.Current.Windows[0].Page.DisplayAlertAsync("Warning", "Error Deleting Section in Database", "ok");
                return;
            }
        }

        public async Task<List<Section>> GetSections()
        {


            await Init();
            var sectionList = await _database.Table<Section>().ToListAsync();
            return sectionList;


        }
        
        public async Task<Section> GetSectionById(int sectionId)
        {


            await Init();
            var chosenSection = await _database.Table<Section>().FirstOrDefaultAsync(s => s.sectionId == sectionId);
            return chosenSection;

        }
        
        

    }
}
