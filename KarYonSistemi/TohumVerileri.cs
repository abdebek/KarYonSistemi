using System.Collections.Generic;

namespace KarYonSistemi
{
    public static class TohumVerileri
    {
        public static void OrnekUrunleriEkle(List<Urun> urunler)
        {
            urunler.Add(new Urun(1, "Bilgisayar", 1000));
            urunler.Add(new Urun(2, "Ayakkabı", 500));
            urunler.Add(new Urun(3, "Tablet", 300));
            urunler.Add(new Urun(4, "Telefon", 200));
            urunler.Add(new Urun(5, "Kulaklık", 100));
            urunler.Add(new Urun(6, "Klavye", 50));
            urunler.Add(new Urun(7, "Mouse", 25));
            urunler.Add(new Urun(8, "Kablo", 10));
            urunler.Add(new Urun(9, "Kalem", 5));
            urunler.Add(new Urun(10, "Silgi", 2));
            urunler.Add(new Urun(11, "Defter", 1));
            urunler.Add(new Urun(12, "Kalemtraş", 0.5m));
            urunler.Add(new Urun(13, "Kurşun Kalem", 0.25m));
            urunler.Add(new Urun(14, "Kalem Ucu", 0.15m));
            urunler.Add(new Urun(15, "Kalem Kutusu", 0.5m));
            urunler.Add(new Urun(16, "Metal Kalem", 0.25m));
            urunler.Add(new Urun(17, "Kalem Silgisi", 0.25m));
            urunler.Add(new Urun(18, "Kalemtraş Silgisi", 0.75m));
            urunler.Add(new Urun(19, "Kalemtraş Açacağı", 0.75m));
            urunler.Add(new Urun(20, "Kalemtraş Kutusu", 0.75m));
            urunler.Add(new Urun(21, "Kamera", 0.75m));
            urunler.Add(new Urun(22, "Kitap", 75));
            urunler.Add(new Urun(23, "Kitap Açacağı", 5));
            urunler.Add(new Urun(24, "Masa", 175));
            urunler.Add(new Urun(25, "Sandalye", 75));
            urunler.Add(new Urun(26, "Koltuk", 275));
            urunler.Add(new Urun(27, "Koltuk Takımı", 1275));
        }

        public static void OrnekGonderileriEkle(List<Gonderi> gonderiler)
        {
            gonderiler.Add(new Gonderi(1, 1, 3, "Ali", "Ahmet"));
            gonderiler.Add(new Gonderi(2, 0, 2, "Adem", "Aslan"));
            gonderiler.Add(new Gonderi(3, 1, 1, "Ayşe", "Aysun"));
            gonderiler.Add(new Gonderi(4, 1, 6, "Bilal", "Berk"));
            gonderiler.Add(new Gonderi(6, 0, 4, "Cem", "Ceyda"));
            gonderiler.Add(new Gonderi(7, 1, 5, "Can", "Cemre"));
            gonderiler.Add(new Gonderi(8, 2, 8, "Derya", "Deniz"));
            gonderiler.Add(new Gonderi(9, 0, 7, "Dilek", "Dilan"));
            gonderiler.Add(new Gonderi(10, 1, 9, "Ece", "Ebru"));
            gonderiler.Add(new Gonderi(11, 2, 11, "Emre", "Eren"));
            gonderiler.Add(new Gonderi(12, 0, 10, "Fatma", "Ferhat"));
            gonderiler.Add(new Gonderi(14, 2, 14, "Gizem", "Gül"));
            gonderiler.Add(new Gonderi(15, 1, 13, "Gül", "Gülay"));
        }
    }
}