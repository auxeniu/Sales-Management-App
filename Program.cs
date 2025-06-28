using ProiectVanzari.Clase;      
using ProiectVanzari.Formulare;  
using ProiectVanzari.Servicii;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace ProiectVanzari { 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo culturaRomana = new CultureInfo("ro-RO");
            culturaRomana.NumberFormat.CurrencySymbol = "RON";
            Thread.CurrentThread.CurrentCulture = culturaRomana;
            Thread.CurrentThread.CurrentUICulture = culturaRomana;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ManagerDate managerDate = new ManagerDate();
            try
            {
                managerDate.AsiguraExistentaAdminDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare critică la inițializarea sistemului de utilizatori: {ex.Message}\nAplicația se va închide.",
                                "Eroare Inițializare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            bool doresteRelogare = true;
            while (doresteRelogare)
            {
                doresteRelogare = false;

                using (FormLogin formLogin = new FormLogin())
                {
                    DialogResult loginResult = formLogin.ShowDialog();

                    if (loginResult == DialogResult.OK)
                    {
                        if (SesiuneUtilizator.EsteLogat && SesiuneUtilizator.UtilizatorCurent != null)
                        {
                            using (FormPrincipal formPrincipal = new FormPrincipal(SesiuneUtilizator.UtilizatorCurent))
                            {
                                Application.Run(formPrincipal);
                                if (SesiuneUtilizator.DoresteRelogare)
                                {
                                    doresteRelogare = true;
                                    SesiuneUtilizator.ResetareStareRelogare();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Autentificare reușită, dar datele utilizatorului nu au putut fi încărcate.\nAplicația se va închide.",
                                            "Eroare Critică Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        break;
                    }
                } 
            }
        }
    }
}