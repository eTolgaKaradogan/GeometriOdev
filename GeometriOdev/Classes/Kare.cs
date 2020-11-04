using System;
using GeometriOdev.Interfaces;
namespace GeometriOdev.Classes
{
    class Kare : IDortgen
    {
        public double Uzunkenar { get; set; }

        public double AlanHesapla()
        {
            return Math.Pow(Uzunkenar, 2);
        }

        public double CevreHesapla()
        {
            return Uzunkenar * 4;
        }
    }
}
