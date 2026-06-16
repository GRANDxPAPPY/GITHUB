using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Storage
{
    public class Appointment
    {
        [PrimaryKey,AutoIncrement]
        public int appointmentId { get; set; }
        public int courseId { get; set; }
        
        public string type { get; set; }
    }
}
