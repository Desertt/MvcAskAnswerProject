using MvcAskAnswerProject.Entities;
using System.Data.Entity;

namespace MvcAskAnswerProject.DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Soru> Sorular { get; set; }
        public DbSet<Cevap> Cevaplar { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer (new ExampleData());
        }


    }
}
