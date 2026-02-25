using SQLite;
namespace MauiApp1.Personel
{
    public class Personel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Quals { get; set; }
    }
}