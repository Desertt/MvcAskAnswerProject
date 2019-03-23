using MvcAskAnswerProject.Entities;
using System;
using System.Data.Entity;
using FakeData;

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
            
            for (int i = 0; i < FakeData.NumberData.GetNumber(5,10); i++)
            {
                Kategori kategori;
                if (i%2==0)
                {
                    kategori = new Kategori
                    {
                        Baslik = FakeData.TextData.GetSentences(1),
                        Aciklama=FakeData.PlaceData.GetAddress(),
                        AktifMi = true,
                        EklemeTarihi = DateTime.Now,
                        EkleyenKullanici = kullanici.KullaniciAdi,
                        Kullanici=kullanici,
                        DuzenlemeTarihi = DateTime.Now,
                        DuzenleyenKullanici = kullanici.KullaniciAdi
                        
                    };
                    context.Kategoriler.Add(kategori);
                }
            }

            context.SaveChanges();


        }
    }
}
