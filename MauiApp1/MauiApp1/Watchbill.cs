
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchModel{
    public class Watchbill()
    {
        [PrimaryKey,AutoIncrement]
        public int WatchbillID { get; set; }
        public string Name { get; set; }
    }

}


