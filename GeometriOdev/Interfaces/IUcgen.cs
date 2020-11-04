using System;
namespace GeometriOdev.Interfaces
{
    interface IUcgen
    {
        public double TabanKenar { get; set; }
        double AlanHesapla();
        double CevreHesapla();
    }
}
