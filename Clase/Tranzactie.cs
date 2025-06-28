using System;
using System.Collections.Generic;
using System.Linq;

namespace ProiectVanzari.Clase
{
    [Serializable]
    public class Tranzactie
    {
        public int IdTranzactie { get; set; }
        public Client ClientAsociat { get; set; } 
        public DateTime DataTranzactie { get; set; }
        public List<ProdusVandut> ProduseVandute { get; set; }

        public decimal TotalGeneral
        {
            get
            {
                return ProduseVandute?.Sum(pv => pv.ValoareTotala) ?? 0;
            }
        }

        public Tranzactie()
        {
            ProduseVandute = new List<ProdusVandut>();
            DataTranzactie = DateTime.Now;
        }

        public Tranzactie(int idTranzactie, Client client, DateTime data) : this()
        {
            IdTranzactie = idTranzactie;
            ClientAsociat = client;
            DataTranzactie = data;
        }

        public override string ToString()
        {
            return $"Tranzacție #{IdTranzactie} - {ClientAsociat?.ToString() ?? "N/A"} - {DataTranzactie:dd/MM/yyyy} - Total: {TotalGeneral:C}";
        }
    }
}