using MvcAskAnswerProject.Entities;
using System;
using System.Data.Entity;

namespace MvcAskAnswerProject.DataAccessLayer
{
    public class ExampleData : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Kullanici kullanici = new Kullanici
            {
                KullaniciAdi = "KazımMirac",
                Ad = "Kazım Miraç",
                Soyad = "Dağtekin",
                Email = "kazimmirac@gmail.com",
                Sifre = "123456",
                ProfilResim = "yeniUye.png",
                AdminMi = true,
                AktifMi = true,
                DuzenleyenKullanici = "kazimmirac",
                EkleyenKullanici = "System",
                EklemeTarihi = DateTime.Now,
                DuzenlemeTarihi = DateTime.Now

            };

            Kullanici kullanici2 = new Kullanici
            {
                KullaniciAdi = "KazımMirac",
                Ad = "Kazım Miraç",
                Soyad = "Dağtekin",
                Email = "kazimmirac@gmail.com",
                Sifre = "123456",
                ProfilResim = "yeniUye.png",
                AdminMi = true,
                AktifMi = true,
                DuzenleyenKullanici = "kazimmirac",
                EkleyenKullanici = "System",
                EklemeTarihi = DateTime.Now,
                DuzenlemeTarihi = DateTime.Now

            };

            context.Kullanicilar.Add(kullanici);
            context.Kullanicilar.Add(kullanici2);
            context.SaveChanges();




        }
    }
}
