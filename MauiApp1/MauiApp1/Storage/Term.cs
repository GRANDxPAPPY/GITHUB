using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MauiApp1.Storage
{
    public class Term
    {
        [PrimaryKey,AutoIncrement]
        public int termId { get; set; }
        public string termName { get; set; }
        public DateTime termStartDate { get; set; }
        public DateTime termEndDate { get; set; }
    }
}
