using System; 

namespace ProiectVanzari.Clase 
{
    
    

    [Serializable] 
    public class Utilizator
    {
        public int IdUtilizator { get; set; }
        public string NumeUtilizator { get; set; }

        public string ParolaHash { get; set; }

        public string Rol { get; set; } 
        public bool EsteActiv { get; set; }

        
        public Utilizator()
        {
            EsteActiv = true; 
        }

        
        public Utilizator(int id, string nume, string rol, bool activ = true, string parolaHash = null)
        {
            IdUtilizator = id;
            NumeUtilizator = nume;
            Rol = rol;
            EsteActiv = activ;
            ParolaHash = parolaHash; 
        }

        
        public override string ToString()
        {
            return $"{NumeUtilizator} ({Rol}){(EsteActiv ? "" : " - INACTIV")}";
        }
    }
}