
using SQLite;

namespace WatchTask
{
    public class WatchAssingnment {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [Indexed]
        public int WatchbillID { get; set; }

        [Indexed]
        public int PersonelID { get; set; }

        public DateOnly Date { get; set; }

        public String Time { get; set; }
        [MaxLength(100)]
        public string Position { get; set; }

    }
}