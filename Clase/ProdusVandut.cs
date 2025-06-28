using System;

namespace ProiectVanzari.Clase
{
    [Serializable]
    public class ProdusVandut
    {
        public Produs ProdusAsociat { get; set; } 
        public int Cantitate { get; set; }
        public decimal PretUnitarLaVanzare { get; set; } 

        public decimal ValoareTotala => Cantitate * PretUnitarLaVanzare;

        public ProdusVandut() { }

        public ProdusVandut(Produs produs, int cantitate, decimal pretUnitarLaVanzare)
        {
            ProdusAsociat = produs;
            Cantitate = cantitate;
            PretUnitarLaVanzare = pretUnitarLaVanzare;
        }

        public override string ToString()
        {
            return $"{ProdusAsociat.Denumire} x {Cantitate} @ {PretUnitarLaVanzare:C} = {ValoareTotala:C}";
        }
    }
}