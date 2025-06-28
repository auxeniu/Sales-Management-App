using System;
using System.Collections.Generic;

namespace ProiectVanzari.Clase
{
    [Serializable] 
    public class Client
    {
        public int IdClient { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public Client() { }

        public Client(int idClient, string nume, string prenume, string adresa, string telefon, string email)
        {
            IdClient = idClient;
            Nume = nume;
            Prenume = prenume;
            Adresa = adresa;
            Telefon = telefon;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nume} {Prenume ?? ""}".Trim();
        }
    }
}