using ProiectVanzari.Clase;      
using ProiectVanzari.Servicii;   
using System;
using System.Drawing; 
using System.Windows.Forms;

namespace ProiectVanzari.Formulare 
{
    public partial class FormLogin : Form
    {
        private ManagerDate _managerDate;

        
        

        public FormLogin()
        {
            InitializeComponent();
            _managerDate = new ManagerDate();

            
            
            
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            string numeUtilizator = txtNumeUtilizator.Text.Trim();
            string parola = txtParola.Text; 

            
            lblMesajEroare.Visible = false;
            lblMesajEroare.Text = "";

            
            if (string.IsNullOrWhiteSpace(numeUtilizator))
            {
                lblMesajEroare.Text = "Numele de utilizator este obligatoriu.";
                lblMesajEroare.Visible = true;
                txtNumeUtilizator.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(parola))
            {
                lblMesajEroare.Text = "Parola este obligatorie.";
                lblMesajEroare.Visible = true;
                txtParola.Focus();
                return;
            }

            try
            {
                
                
                
                Utilizator utilizatorValidat = _managerDate.VerificaUtilizator(numeUtilizator, parola);

                if (utilizatorValidat != null)
                {
                    
                    SesiuneUtilizator.Login(utilizatorValidat); 

                    this.DialogResult = DialogResult.OK; 
                    this.Close(); 
                }
                else
                {
                    
                    SesiuneUtilizator.Logout(); 
                    lblMesajEroare.Text = "Nume de utilizator sau parolă incorectă, sau contul este inactiv.";
                    lblMesajEroare.Visible = true;
                    txtParola.Clear();        
                    txtParola.Focus();        
                }
            }
            catch (Exception ex)
            {
                
                SesiuneUtilizator.Logout(); 
                lblMesajEroare.Text = $"Eroare la autentificare: {ex.Message}";
                lblMesajEroare.Visible = true;
                
            }
        }

        
        private void btnLogin_Click(object sender, EventArgs e) 
        {
            
            string numeUtilizator = txtNumeUtilizator.Text.Trim();
            string parola = txtParola.Text;

            
            lblMesajEroare.Visible = false;
            lblMesajEroare.Text = "";

            if (string.IsNullOrWhiteSpace(numeUtilizator) || string.IsNullOrWhiteSpace(parola))
            {
                lblMesajEroare.Text = "Numele de utilizator și parola sunt obligatorii.";
                lblMesajEroare.Visible = true;
                return;
            }

            try
            {
                Utilizator utilizatorValidat = _managerDate.VerificaUtilizator(numeUtilizator, parola);

                if (utilizatorValidat != null)
                {
                    SesiuneUtilizator.Login(utilizatorValidat);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    SesiuneUtilizator.Logout();
                    lblMesajEroare.Text = "Nume de utilizator sau parolă incorectă, sau contul este inactiv.";
                    lblMesajEroare.Visible = true;
                    txtParola.Clear();
                    txtParola.Focus();
                }
            }
            catch (Exception ex)
            {
                SesiuneUtilizator.Logout();
                lblMesajEroare.Text = $"Eroare la autentificare: {ex.Message}";
                lblMesajEroare.Visible = true;
            }
        }

        
        
        

        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtNumeUtilizator.Clear();
            txtParola.Clear();
            lblMesajEroare.Visible = false;
            txtNumeUtilizator.Focus(); 
        }
    }
}