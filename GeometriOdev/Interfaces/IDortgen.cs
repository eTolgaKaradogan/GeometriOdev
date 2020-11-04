using System;
namespace GeometriOdev.Interfaces
{
    interface IDortgen
    {
        public double Uzunkenar { get; set; }
        double CevreHesapla();
        double AlanHesapla();
    }
}
