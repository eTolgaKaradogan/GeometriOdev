using System;
using GeometriOdev.Interfaces;
namespace GeometriOdev.Classes
{
    class DikUcgen : IUcgen
    {
        public double TabanKenar { get; set; }
        public double Yukseklik { get; set; }

        public double AlanHesapla()
        {
            return (TabanKenar * Yukseklik) / 2;
        }

        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(TabanKenar, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + TabanKenar + Yukseklik;
        }
    }
}
