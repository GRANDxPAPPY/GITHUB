
using SQLite;
using System.Diagnostics.CodeAnalysis;
namespace MauiApp1.Personel
{
    public class Personel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Quals { get; set; }
        public int Lib { get; set; }

        [AllowNull]
        public int WatchbillID { get; set; }
    }
}