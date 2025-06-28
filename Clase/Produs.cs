using System;

namespace ProiectVanzari.Clase
{
    [Serializable]
    public class Produs
    {
        public int IdProdus { get; set; }
        public string Denumire { get; set; }
        public decimal Pret { get; set; }
        public int Stoc { get; set; }

        public Produs() { }

        public Produs(int idProdus, string denumire, decimal pret, int stoc)
        {
            IdProdus = idProdus;
            Denumire = denumire;
            Pret = pret;
            Stoc = stoc;
        }
        public override string ToString()
        {
            return $"{Denumire} - {Pret:C} (Stoc: {Stoc})";
        }
    }
}