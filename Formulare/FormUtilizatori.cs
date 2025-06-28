using ProiectVanzari.Clase;      
using ProiectVanzari.Servicii;   
using System;
using System.Collections.Generic;
using System.ComponentModel;      
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectVanzari.Formulare 
{
    
    public partial class FormUtilizatori : Form
    {
        private ManagerDate _managerDate;
        private List<Utilizator> _listaUtilizatori;
        private bool _modEditare = false;
        private Utilizator _utilizatorCurentLogat;

        public FormUtilizatori(Utilizator utilizatorLogat)
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            _listaUtilizatori = new List<Utilizator>();
            _utilizatorCurentLogat = utilizatorLogat;

            if (_utilizatorCurentLogat == null || _utilizatorCurentLogat.Rol != RolUtilizator.Admin)
            {
                MessageBox.Show("Acces neautorizat la gestiunea utilizatorilor.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
                return;
            }

            cmbRoluri.Items.Clear();
            cmbRoluri.Items.Add(RolUtilizator.Admin);
            cmbRoluri.Items.Add(RolUtilizator.Operator);
            cmbRoluri.Items.Add(RolUtilizator.Vizitator);
            
            txtNumeUtilizatorCrud.Validating += Camp_Validating;
            txtParolaCrud.Validating += Camp_Validating;
            txtConfirmareParolaCrud.Validating += Camp_Validating;
            cmbRoluri.Validating += Camp_Validating_ComboBox;
        }

        private void FormUtilizatori_Load(object sender, EventArgs e)
        {
            if (this.IsDisposed || !this.Visible) return;

            IncarcaUtilizatoriInListView();
          listViewUtilizatori.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ActualizeazaStareaControalelorEditare(false);
        }

        private void IncarcaUtilizatoriInListView()
        {
            try
            {
                _listaUtilizatori = _managerDate.IncarcaTotiUtilizatorii();
                listViewUtilizatori.Items.Clear();
                

                foreach (var user in _listaUtilizatori)
                {
                    ListViewItem item = new ListViewItem(user.NumeUtilizator);
                    item.SubItems.Add(user.Rol);
                    item.SubItems.Add(user.EsteActiv ? "Da" : "Nu");
                    item.Tag = user; 
                    listViewUtilizatori.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea listei de utilizatori: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaStareaControalelorEditare(bool editareActiva)
        {
            txtNumeUtilizatorCrud.Enabled = editareActiva;
            txtParolaCrud.Enabled = editareActiva;
            txtConfirmareParolaCrud.Enabled = editareActiva;
            cmbRoluri.Enabled = editareActiva;
            chkEsteActiv.Enabled = editareActiva;

            btnSalveazaUtilizator.Enabled = editareActiva;
            btnAnuleazaEditare.Enabled = editareActiva;

            btnAdaugaUtilizator.Enabled = !editareActiva;

            bool itemSelectat = listViewUtilizatori.SelectedItems.Count > 0;
            btnModificaUtilizator.Enabled = !editareActiva && itemSelectat;
            btnStergeUtilizator.Enabled = !editareActiva && itemSelectat;

            if (itemSelectat && !editareActiva)
            {
                Utilizator userSelectatDinLista = (Utilizator)listViewUtilizatori.SelectedItems[0].Tag;
                if (userSelectatDinLista.IdUtilizator == _utilizatorCurentLogat.IdUtilizator)
                {
                    btnStergeUtilizator.Enabled = false; 
                }
            }

            listViewUtilizatori.Enabled = !editareActiva;
        }

        private void GolesteCampuriDetalii()
        {
            lblIdUtilizatorEditat.Text = "0"; 
            txtNumeUtilizatorCrud.Clear();
            txtParolaCrud.Clear();
            txtConfirmareParolaCrud.Clear();
            cmbRoluri.SelectedIndex = -1; 
            chkEsteActiv.Checked = true;   
            errorProviderUtilizatori.Clear(); 
        }

        private void listViewUtilizatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUtilizatori.SelectedItems.Count > 0)
            {
                Utilizator userSelectat = (Utilizator)listViewUtilizatori.SelectedItems[0].Tag;
                lblIdUtilizatorEditat.Text = userSelectat.IdUtilizator.ToString();
                txtNumeUtilizatorCrud.Text = userSelectat.NumeUtilizator;
                cmbRoluri.SelectedItem = userSelectat.Rol; 
                chkEsteActiv.Checked = userSelectat.EsteActiv;
                txtParolaCrud.Clear();
                txtConfirmareParolaCrud.Clear();
            }
            else
            {
                GolesteCampuriDetalii();
            }
            ActualizeazaStareaControalelorEditare(false); 
        }

        private void btnAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            _modEditare = false; 
            GolesteCampuriDetalii();
            ActualizeazaStareaControalelorEditare(true);
            txtNumeUtilizatorCrud.Focus();
        }

        private void btnModificaUtilizator_Click(object sender, EventArgs e)
        {
            if (listViewUtilizatori.SelectedItems.Count > 0)
            {
                _modEditare = true; 
                ActualizeazaStareaControalelorEditare(true);
                txtNumeUtilizatorCrud.Focus();
                MessageBox.Show("Pentru a modifica parola, introduceți noua parolă. Lăsați câmpurile de parolă goale pentru a o păstra pe cea existentă.", "Modificare Parolă", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Vă rugăm selectați un utilizator din listă pentru a-l modifica.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStergeUtilizator_Click(object sender, EventArgs e)
        {
            if (listViewUtilizatori.SelectedItems.Count > 0)
            {
                Utilizator userSelectat = (Utilizator)listViewUtilizatori.SelectedItems[0].Tag;

                if (userSelectat.IdUtilizator == _utilizatorCurentLogat.IdUtilizator)
                {
                    MessageBox.Show("Nu vă puteți șterge propriul cont de administrator.", "Operație Nepermisă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Sunteți sigur că doriți să ștergeți utilizatorul '{userSelectat.NumeUtilizator}'?",
                                    "Confirmare Ștergere Utilizator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _managerDate.StergeUtilizator(userSelectat.IdUtilizator);
                        IncarcaUtilizatoriInListView(); 
                        GolesteCampuriDetalii();   
                        MessageBox.Show("Utilizatorul a fost șters cu succes.", "Ștergere Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidOperationException ioEx) 
                    {
                        MessageBox.Show(ioEx.Message, "Operație Nepermisă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la ștergerea utilizatorului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm selectați un utilizator din listă pentru a-l șterge.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Camp_Validating(object sender, CancelEventArgs e)
        {
            if (!((Control)sender).Enabled) return; 

            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (tb == txtNumeUtilizatorCrud && string.IsNullOrWhiteSpace(tb.Text))
                {
                    errorProviderUtilizatori.SetError(tb, "Numele de utilizator este obligatoriu.");
                }
                else if (tb == txtParolaCrud && !_modEditare && string.IsNullOrWhiteSpace(tb.Text)) 
                {
                    errorProviderUtilizatori.SetError(tb, "Parola este obligatorie la adăugare.");
                }
                else if (tb == txtConfirmareParolaCrud && !string.IsNullOrWhiteSpace(txtParolaCrud.Text) && txtParolaCrud.Text != tb.Text)
                {
                    errorProviderUtilizatori.SetError(tb, "Parolele nu se potrivesc.");
                }
                else
                {
                    errorProviderUtilizatori.SetError(tb, ""); 
                }
            }
        }
        private void Camp_Validating_ComboBox(object sender, CancelEventArgs e)
        {
            if (!((Control)sender).Enabled) return;
            ComboBox cb = sender as ComboBox;
            if (cb == cmbRoluri && cb.SelectedItem == null)
            {
                errorProviderUtilizatori.SetError(cb, "Rolul este obligatoriu.");
            }
            else
            {
                errorProviderUtilizatori.SetError(cb, "");
            }
        }


        private bool ValideazaToateDateleInainteDeSalvare()
        {
            bool esteValid = true;
            errorProviderUtilizatori.Clear(); 
            if (string.IsNullOrWhiteSpace(txtNumeUtilizatorCrud.Text))
            {
                errorProviderUtilizatori.SetError(txtNumeUtilizatorCrud, "Numele de utilizator este obligatoriu.");
                esteValid = false;
            }
            if (!_modEditare) 
            {
                if (string.IsNullOrWhiteSpace(txtParolaCrud.Text))
                {
                    errorProviderUtilizatori.SetError(txtParolaCrud, "Parola este obligatorie.");
                    esteValid = false;
                }
                else if (txtParolaCrud.Text.Length < 6) 
                {
                    errorProviderUtilizatori.SetError(txtParolaCrud, "Parola trebuie să conțină cel puțin 6 caractere.");
                    esteValid = false;
                }
                else if (txtParolaCrud.Text != txtConfirmareParolaCrud.Text)
                {
                    errorProviderUtilizatori.SetError(txtConfirmareParolaCrud, "Parolele nu se potrivesc.");
                    esteValid = false;
                }
            }
            else 
            {
                if (!string.IsNullOrWhiteSpace(txtParolaCrud.Text)) 
                {
                    if (txtParolaCrud.Text.Length < 6)
                    {
                        errorProviderUtilizatori.SetError(txtParolaCrud, "Noua parolă trebuie să conțină cel puțin 6 caractere.");
                        esteValid = false;
                    }
                    else if (txtParolaCrud.Text != txtConfirmareParolaCrud.Text)
                    {
                        errorProviderUtilizatori.SetError(txtConfirmareParolaCrud, "Parolele nu se potrivesc.");
                        esteValid = false;
                    }
                }
            }
            if (cmbRoluri.SelectedItem == null)
            {
                errorProviderUtilizatori.SetError(cmbRoluri, "Vă rugăm selectați un rol pentru utilizator.");
                esteValid = false;
            }

            return esteValid;
        }

        private void btnSalveazaUtilizator_Click(object sender, EventArgs e)
        {
            if (!ValideazaToateDateleInainteDeSalvare())
            {
                MessageBox.Show("Formularul conține erori. Vă rugăm corectați câmpurile marcate.", "Validare Eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Utilizator utilizatorPentruSalvare = new Utilizator
            {
                IdUtilizator = int.TryParse(lblIdUtilizatorEditat.Text, out int id) ? id : 0,
                NumeUtilizator = txtNumeUtilizatorCrud.Text.Trim(),
                Rol = cmbRoluri.SelectedItem.ToString(),
                EsteActiv = chkEsteActiv.Checked
            };

            string parolaDeSetat = null; 
            if (!_modEditare || !string.IsNullOrWhiteSpace(txtParolaCrud.Text)) 
            {
                parolaDeSetat = txtParolaCrud.Text;
            }

            try
            {
                if (_modEditare)
                {
                    if (utilizatorPentruSalvare.Rol != RolUtilizator.Admin || !utilizatorPentruSalvare.EsteActiv)
                    {
                        Utilizator userDinDb = _listaUtilizatori.FirstOrDefault(u => u.IdUtilizator == utilizatorPentruSalvare.IdUtilizator);
                        if (userDinDb != null && userDinDb.Rol == RolUtilizator.Admin && userDinDb.EsteActiv)
                        {
                            int numarAdminiActivi = _listaUtilizatori.Count(u => u.Rol == RolUtilizator.Admin && u.EsteActiv && u.IdUtilizator != utilizatorPentruSalvare.IdUtilizator);
                            if (numarAdminiActivi == 0)
                            {
                                MessageBox.Show("Nu puteți schimba rolul sau dezactiva ultimul administrator activ al sistemului.", "Operație Nepermisă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                listViewUtilizatori_SelectedIndexChanged(null, null); 
                                return;
                            }
                        }
                    }

                    _managerDate.ActualizeazaUtilizator(utilizatorPentruSalvare, parolaDeSetat);
                    MessageBox.Show("Datele utilizatorului au fost actualizate cu succes.", "Actualizare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    utilizatorPentruSalvare.IdUtilizator = _managerDate.AdaugaUtilizator(utilizatorPentruSalvare, parolaDeSetat); 
                    MessageBox.Show("Utilizatorul a fost adăugat cu succes.", "Adăugare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                IncarcaUtilizatoriInListView();
                SelecteazaUtilizatorInListView(utilizatorPentruSalvare.IdUtilizator); 
                ActualizeazaStareaControalelorEditare(false); 
            }
            catch (InvalidOperationException ioEx) 
            {
                MessageBox.Show(ioEx.Message, "Eroare Operațională", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException argEx) 
            {
                MessageBox.Show(argEx.Message, "Eroare Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la salvarea utilizatorului: {ex.Message}", "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelecteazaUtilizatorInListView(int idUtilizator)
        {
            foreach (ListViewItem item in listViewUtilizatori.Items)
            {
                Utilizator userDinItem = (Utilizator)item.Tag;
                if (userDinItem.IdUtilizator == idUtilizator)
                {
                    item.Selected = true;
                    item.Focused = true;
                    listViewUtilizatori.EnsureVisible(item.Index);
                    break;
                }
            }
        }


        private void btnAnuleazaEditare_Click(object sender, EventArgs e)
        {
            errorProviderUtilizatori.Clear();
            if (listViewUtilizatori.SelectedItems.Count > 0)
            {
                listViewUtilizatori_SelectedIndexChanged(sender, e);
            }
            else
            {
                GolesteCampuriDetalii();
            }
            ActualizeazaStareaControalelorEditare(false);
        }

        private void FormUtilizatori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S && btnSalveazaUtilizator.Enabled)
            {
                btnSalveazaUtilizator_Click(sender, e);
                e.SuppressKeyPress = true; 
            }
            else if (e.KeyCode == Keys.Escape && btnAnuleazaEditare.Enabled)
            {
                btnAnuleazaEditare_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.N && btnAdaugaUtilizator.Enabled)
            {
                btnAdaugaUtilizator_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}