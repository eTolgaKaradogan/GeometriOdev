using System;
namespace GeometriOdev.Classes
{
    class Daire
    {
        public double YariCap { get; set; }
        public double AlanHesapla()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }
        public double CevreHesapla()
        {
            return 2 * Math.PI * YariCap;
        }
    }
}
