using System;
using GeometriOdev.Interfaces;
namespace GeometriOdev.Classes
{
    class Dikdortgen : IDortgen
    {
        public double Uzunkenar { get; set; }
        public double KisaKenar { get; set; }

        public double AlanHesapla()
        {
            return Uzunkenar * KisaKenar;
        }

        public double CevreHesapla()
        {
            return (Uzunkenar + KisaKenar) * 2;
        }
    }
}
