using System;
using GeometriOdev.Classes;

namespace GeometriOdev
{
    class Program
    {
        private static bool girilenYanlisDeger;
        private static string alanVeyaCevre;

        static void Main(string[] args)
        {
            Kare kare;
            Dikdortgen dikdortgen;
            DikUcgen dikUcgen;
            EskenarUcgen eskenarUcgen;
            Daire daire;
            string girilenSekil;
            Console.WriteLine("Lütfen işlem yapmak istediğiniz şekili giriniz(Kare, Dikdörtgen, Dik Üçgen, Eşkenar Üçgen, Daire):");
            girilenSekil = Console.ReadLine();
            if (girilenSekil == "Kare")
            {
                kare = new Kare();
                Console.Write("Kenar uzunluğu: ");
                kare.Uzunkenar = Convert.ToDouble(Console.ReadLine());
                KareHesapla(kare, alanVeyaCevre);
            }
            else if (girilenSekil == "Dikdörtgen")
            {
                dikdortgen = new Dikdortgen();
                Console.Write("Kısa Kenar: ");
                dikdortgen.KisaKenar = Convert.ToDouble(Console.ReadLine());
                Console.Write("Uzun Kenar: ");
                dikdortgen.Uzunkenar = Convert.ToDouble(Console.ReadLine());
                DikdortgenHesapla(dikdortgen, alanVeyaCevre);
            }
            else if (girilenSekil == "Dik Üçgen")
            {
                dikUcgen = new DikUcgen();
                Console.Write("Taban Kenar: ");
                dikUcgen.TabanKenar = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yükseklik: ");
                dikUcgen.Yukseklik = Convert.ToDouble(Console.ReadLine());
                DikUcgenHesapla(dikUcgen, alanVeyaCevre);
            }
            else if (girilenSekil == "Eşkenar Üçgen")
            {
                eskenarUcgen = new EskenarUcgen();
                Console.Write("Taban Kenar: ");
                eskenarUcgen.TabanKenar = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yükseklik: ");
                eskenarUcgen.Yukseklik = Convert.ToDouble(Console.ReadLine());
                EskenarUcgenHesapla(eskenarUcgen, alanVeyaCevre);
            }
            else if (girilenSekil == "Daire")
            {
                daire = new Daire();
                Console.Write("Yarı çap: ");
                daire.YariCap = Convert.ToDouble(Console.ReadLine());
                DaireHesapla(daire, alanVeyaCevre);
            }
        }

        private static void DaireHesapla(Daire daire, string alanVeyaCevre)
        {
            Console.WriteLine("Alan Hesaplama için 'a' Çevre Hesaplama için 'ç' giriniz.");
            alanVeyaCevre = Console.ReadLine();
            if (alanVeyaCevre == "a")
            {
                Console.WriteLine(daire.AlanHesapla());
            }
            else if (alanVeyaCevre == "ç")
            {
                Console.WriteLine(daire.CevreHesapla());
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                DaireHesapla(daire, alanVeyaCevre);
            }
        }

        private static void EskenarUcgenHesapla(EskenarUcgen eskenarUcgen, string alanVeyaCevre)
        {
            Console.WriteLine("Alan Hesaplama için 'a' Çevre Hesaplama için 'ç' giriniz.");
            alanVeyaCevre = Console.ReadLine();
            if (alanVeyaCevre == "a")
            {
                Console.Write(eskenarUcgen.AlanHesapla());
            }
            else if (alanVeyaCevre == "ç")
            {
                Console.WriteLine(eskenarUcgen.CevreHesapla());
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                EskenarUcgenHesapla(eskenarUcgen, alanVeyaCevre);
            }
        }

        private static void DikUcgenHesapla(DikUcgen dikUcgen, string alanVeyaCevre)
        {
            Console.WriteLine("Alan Hesaplama için 'a' Çevre Hesaplama için 'ç' giriniz.");
            alanVeyaCevre = Console.ReadLine();
            if (alanVeyaCevre == "a")
            {
                Console.WriteLine(dikUcgen.AlanHesapla());
            }
            else if (alanVeyaCevre == "ç")
            {
                Console.WriteLine(dikUcgen.CevreHesapla());
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                DikUcgenHesapla(dikUcgen, alanVeyaCevre);
            }
        }

        private static void DikdortgenHesapla(Dikdortgen dikdortgen, string alanVeyaCevre)
        {
            Console.WriteLine("Alan Hesaplama için 'a' Çevre Hesaplama için 'ç' giriniz.");
            alanVeyaCevre = Console.ReadLine();
            if (alanVeyaCevre == "a")
            {
                Console.WriteLine(dikdortgen.AlanHesapla());
            }
            else if (alanVeyaCevre == "ç")
            {
                Console.WriteLine(dikdortgen.CevreHesapla());
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                DikdortgenHesapla(dikdortgen, alanVeyaCevre);
            }
        }

        private static void KareHesapla(Kare kare, string alanVeyaCevre)
        {
            Console.WriteLine("Alan Hesaplama için 'a' Çevre Hesaplama için 'ç' giriniz.");
            alanVeyaCevre = Console.ReadLine();
            if (alanVeyaCevre == "a")
            {
                Console.WriteLine(kare.AlanHesapla());
            }
            else if (alanVeyaCevre == "ç")
            {
                Console.WriteLine(kare.CevreHesapla());
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                KareHesapla(kare, alanVeyaCevre);
            }
        }
    }
}
