using System;
using GeometriOdev.Interfaces;
namespace GeometriOdev.Classes
{
    class EskenarUcgen : IUcgen
    {
        public double TabanKenar { get; set; }
        public double Yukseklik { get; set; }

        public double AlanHesapla()
        {
            return (TabanKenar * TabanKenar) * Math.Sqrt(3) / 4;
        }

        public double CevreHesapla()
        {
            return TabanKenar * 3;
        }
    }
}
