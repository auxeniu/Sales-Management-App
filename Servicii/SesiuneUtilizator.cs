using ProiectVanzari.Clase; 
using System;

namespace ProiectVanzari.Servicii 
{
    public static class SesiuneUtilizator
    {
        private static Utilizator _utilizatorCurent;
        public static Utilizator UtilizatorCurent
        {
            get { return _utilizatorCurent; }
            private set { _utilizatorCurent = value; } 
        }
        public static bool EsteLogat { get; private set; } = false;
        public static bool DoresteRelogare { get; set; } = false;
        public static void Login(Utilizator utilizator)
        {
            if (utilizator == null)
            {
                throw new ArgumentNullException(nameof(utilizator), "Utilizatorul pentru login nu poate fi null.");
            }

            if (!utilizator.EsteActiv)
            {
                Logout(); 
                throw new InvalidOperationException("Contul acestui utilizator este inactiv.");
            }

            UtilizatorCurent = utilizator;
            EsteLogat = true;
            DoresteRelogare = false; 
        }
        public static void Logout()
        {
            UtilizatorCurent = null;
            EsteLogat = false;
        }
        public static bool AreRol(string rol)
        {
            if (EsteLogat && UtilizatorCurent != null)
            {
                return string.Equals(UtilizatorCurent.Rol, rol, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
        public static bool AreUnulDinRoluri(params string[] roluri)
        {
            if (EsteLogat && UtilizatorCurent != null && roluri != null)
            {
                foreach (string rol in roluri)
                {
                    if (string.Equals(UtilizatorCurent.Rol, rol, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void ResetareStareRelogare()
        {
            DoresteRelogare = false;
        }
    }
}