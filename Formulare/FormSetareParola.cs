using ProiectVanzari.Clase;      
using ProiectVanzari.Servicii;   
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProiectVanzari.Formulare
{
    public partial class FormSetareParola : Form
    {
        private ManagerDate _managerDate;
        private Utilizator _utilizatorDeModificat; 

        
        public FormSetareParola(Utilizator utilizatorTarget)
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            _utilizatorDeModificat = utilizatorTarget;

            if (_utilizatorDeModificat == null)
            {
                MessageBox.Show("Utilizatorul pentru care se setează parola nu a fost specificat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close(); 
                return;
            }
            this.Text = $"Setare Parolă pentru {(_utilizatorDeModificat.NumeUtilizator ?? "Utilizator Necunoscut")}";
            lblInfoUtilizator.Text = $"Setați o nouă parolă pentru utilizatorul: {_utilizatorDeModificat.NumeUtilizator}";
        }

        
        /*
        public FormSetareParola(int idUtilizatorTarget)
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            try
            {
                
                
                
                
                _utilizatorDeModificat = _managerDate.GetUtilizatorById(idUtilizatorTarget); 

                if (_utilizatorDeModificat == null)
                {
                    MessageBox.Show("Utilizatorul specificat nu a fost găsit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Load += (s, e) => this.Close();
                    return;
                }
                this.Text = $"Setare Parolă pentru {_utilizatorDeModificat.NumeUtilizator}";
                lblInfoUtilizator.Text = $"Setați o nouă parolă pentru utilizatorul: {_utilizatorDeModificat.NumeUtilizator}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea datelor utilizatorului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
            }
        }
        */


        private bool ValideazaParola()
        {
            bool esteValid = true;
            errorProviderParola.Clear();

            if (string.IsNullOrWhiteSpace(txtParolaNoua.Text))
            {
                errorProviderParola.SetError(txtParolaNoua, "Noua parolă este obligatorie.");
                esteValid = false;
            }
            else if (txtParolaNoua.Text.Length < 6)
            {
                errorProviderParola.SetError(txtParolaNoua, "Parola trebuie să conțină cel puțin 6 caractere.");
                esteValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmareParolaNoua.Text))
            {
                errorProviderParola.SetError(txtConfirmareParolaNoua, "Confirmarea parolei este obligatorie.");
                esteValid = false;
            }
            else if (txtParolaNoua.Text != txtConfirmareParolaNoua.Text)
            {
                errorProviderParola.SetError(txtConfirmareParolaNoua, "Parolele nu se potrivesc.");
                esteValid = false;
            }
            return esteValid;
        }

        private void btnSalveazaParola_Click(object sender, EventArgs e)
        {
            if (_utilizatorDeModificat == null) 
            {
                MessageBox.Show("Eroare internă: Utilizatorul țintă nu este disponibil.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }

            if (!ValideazaParola())
            {
                MessageBox.Show("Vă rugăm corectați erorile din formular.", "Validare Eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                
                
                _managerDate.ActualizeazaUtilizator(_utilizatorDeModificat, txtParolaNoua.Text);

                MessageBox.Show($"Parola pentru utilizatorul '{_utilizatorDeModificat.NumeUtilizator}' a fost schimbată cu succes.",
                                "Parolă Modificată", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea noii parole: {ex.Message}", "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort; 
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}