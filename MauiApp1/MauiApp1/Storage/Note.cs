using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Storage
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int noteId { get; set; }
        public int courseId { get; set; }
        public string noteName { get; set; }
        public string submittedUser { get; set; }
        public string noteBody { get; set; }
    }
}
