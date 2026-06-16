



using MauiApp1.Storage;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//before we do this submit part b in your repo
namespace MauiApp1.Services
{

    public class DataService
    {
        private SQLiteAsyncConnection _database;

        internal async Task Init()
        {
            if (_database != null) return;

            var path = Path.Combine(FileSystem.AppDataDirectory, "collegeApp.db");
            _database = new SQLiteAsyncConnection(path);

            await _database.CreateTablesAsync<Term, Course, Instructor, Appointment,Note>();
            await _database.CreateTablesAsync<Assesment,CourseInfo>();
            await TestingTerm();
        }

        private async Task TestingTerm()
        {
            var x = await _database.Table<Term>().CountAsync();
            if (x < 1) {
                var placeHolderTerm = new Term() { termName = "Term1", termStartDate = new DateTime(2026,02,03), termEndDate = new DateTime(2026, 11, 05) };
                var placeHolderInstructor = new Instructor() {Name = "Anika Patel", email= "anika.patel@strimeuniversity.edu", phone= "555-123-4567"};
                var placeHolderCourse = new Course() { courseName = "Science", courseStartDate = DateTime.Now, courseEndDate = new DateTime(2026, 11, 01), instructorId = 1, active=1,termId=1};
                
                var placeHolderNote = new Note() { courseId = 1, noteBody = "This will be my note body",noteName="Instructos Notes" };
                var placeHolderAssesment = new Assesment { courseId = 1, Name = "Math", assesmentType = "PA" , courseInfo ="This will text students critical thinking skills"};
                var placeHolderAssesment2 = new Assesment { courseId = 1, Name = "Math", assesmentType = "OA", courseInfo ="This test will cover common algorithims found in todays World." };
                var courseInfo = new CourseInfo() { CourseBody = "Place Holder Course Info", CourseId = 1 };
                
                await AddTerm(placeHolderTerm);
                await AddIstructor(placeHolderInstructor);
                await AddCourse(placeHolderCourse);
                
                await AddNotes(placeHolderNote);
                await AddAssesment(placeHolderAssesment);
                await AddAssesment(placeHolderAssesment2);
                await AddCourseInfo(courseInfo);
                
            }
        }
        //Courses 
        public async Task<bool> AddCourse(Course course)
        {
            try
            {
                await Init();
                await _database.InsertAsync(course);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task<bool> UpdateCourse(Course course)
        {
            try
            {
                await Init();
                await _database.UpdateAsync(course);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteCourse(Course course)
        {
            try
            {
                await Init();
                await _database.DeleteAsync(course);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<List<Course>> GetCourse()
        {
            await Init();
            var courseList = await _database.Table<Course>().ToListAsync();
            return courseList;
        }

        //Term
        public async Task<bool> AddTerm(Term term)
        {
            try
            {
                await Init();
                await _database.InsertAsync(term);
                return true;
            }
            catch (Exception)
            {
                Application.Current.MainPage.DisplayAlert("WARNING!", "Error entering data in Database", "yes");
                return false;
            }
        }
        public async Task<bool> UpdateTerm(Term term)
        {
            try
            {
                await Init();
                await _database.UpdateAsync(term);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteTerm(Term term)
        {
            try
            {
                await Init();
                await _database.DeleteAsync(term);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<Term>> GetTerms()
        {
            await Init();

            var termList = await _database.Table<Term>().ToListAsync();
            return termList;
        }



        //Instructors

        public async Task<bool> AddIstructor(Instructor instructor)
        {
            try
            {
                await Init();
                await _database.InsertAsync(instructor);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task<bool> UpdateInstructor(Instructor instructor)
        {
            try
            {
                await Init();
                await _database.UpdateAsync(instructor);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteInstructor(Instructor instructor)
        {
            try
            {
                await Init();
                await _database.DeleteAsync(instructor);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task<List<Instructor>> GetInstructor()
        {
                await Init();
                var returningList =await _database.Table<Instructor>().ToListAsync();
                return returningList;
        }
        public async Task<bool> AddNotes(Note notes)
        {
            try
            {
                await Init();
                await _database.InsertAsync(notes);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Notes
        public async Task<bool> UpdateNotes(Note notes)
        {
            try
            {
                await Init();
                await _database.UpdateAsync(notes);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteNotes(Note notes)
        {
            try
            {
                await Init();
                await _database.DeleteAsync(notes);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task<List<Note>> GetNotes()
        {
            await Init();
            var returningList = await _database.Table<Note>().ToListAsync();
            return returningList;
        }
        public async Task<List<Assesment>> GetAssesments()
        {
            await Init();
            var returningList = await _database.Table<Assesment>().ToListAsync();
            return returningList;
        }
        public async Task<bool> AddAssesment(Assesment assesment)
        {
            try
            {
                await Init();
                await _database.InsertAsync(assesment);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task UpdateAssesment(Assesment assesment)
        {
            await Init();
            await _database.UpdateAsync(assesment);
        }
        public async Task<List<CourseInfo>> GetCourseInfo()
        {
            await Init();
            var returningList = await _database.Table<CourseInfo>().ToListAsync();
            return returningList;
        }
        public async Task<bool> AddCourseInfo(CourseInfo courseInfo)
        {
            try
            {
                await Init();
                await _database.InsertAsync(courseInfo);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task UpdateCourseInfo(CourseInfo courseInfo)
        {
            await Init();
            await _database.UpdateAsync(courseInfo);
        }
        public async Task DeleteAssesment(Assesment assesment)
        {
            await _database.DeleteAsync(assesment);
        }
    }
}
