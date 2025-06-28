using ProiectVanzari.Clase;
using ProiectVanzari.Clase.Exceptii;
using ProiectVanzari.Servicii;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProiectVanzari.Formulare
{
    public partial class FormClienti : Form
    {
        private ManagerDate _managerDate;
        private List<Client> _listaClienti;
        private bool _modEditare = false;
        private bool _dateDinFisierNesalvate = false;
        private int _sortColumn = -1;

        public FormClienti()
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            _listaClienti = new List<Client>();

            ltbNume.TextBoxInstance.Validating += Camp_Validating;
            ltbEmail.TextBoxInstance.Validating += Camp_Validating;
            ltbTelefon.TextBoxInstance.Validating += Camp_Validating;
        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            IncarcaClientiDinDbSiAfiseaza();
            ActualizeazaStareControaleEditare(false);
            btnSalveazaDateRestaurateInDB.Visible = false;
            btnSalveazaDateRestaurateInDB.Enabled = false;
        }

        private void IncarcaClientiDinDbSiAfiseaza()
        {
            try
            {
                _listaClienti = _managerDate.IncarcaClientiDinDb();
                AfiseazaClientiInListView();
                _dateDinFisierNesalvate = false;
                ActualizeazaVizibilitateButonSalvareRestaurate();
                GolesteCampuriDetalii();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea clienților din baza de date: {ex.Message}", "Eroare Încărcare DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IncarcaClientiDinLista(List<Client> clientiRestaurati)
        {
            _listaClienti = clientiRestaurati ?? new List<Client>();
            AfiseazaClientiInListView();

            if (clientiRestaurati != null && clientiRestaurati.Any())
            {
                _dateDinFisierNesalvate = true;
                MessageBox.Show("Clienții din fișier au fost încărcați în listă.\n" +
                                "Puteți să îi salvați în baza de date folosind butonul 'Salvare Date Restaurate în DB' " +
                                "sau să interacționați individual cu ei (Adaugă/Modifică) folosind câmpurile de detalii.",
                                "Clienți Restaurați", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _dateDinFisierNesalvate = false;
            }
            ActualizeazaVizibilitateButonSalvareRestaurate();
            ActualizeazaStareControaleEditare(false);
            GolesteCampuriDetalii();
        }

        private void AfiseazaClientiInListView()
        {
            listViewClienti.Items.Clear();
            if (_listaClienti == null) return;

            foreach (var client in _listaClienti)
            {
                ListViewItem item = new ListViewItem(client.Nume);
                item.SubItems.Add(client.Prenume ?? "");
                item.SubItems.Add(client.Telefon ?? "");
                item.SubItems.Add(client.Email ?? "");
                item.Tag = client;
                listViewClienti.Items.Add(item);
            }
        }

        private void ActualizeazaVizibilitateButonSalvareRestaurate()
        {
            bool suntDateDeSalvatDinFisier = _dateDinFisierNesalvate && _listaClienti != null && _listaClienti.Any();
            btnSalveazaDateRestaurateInDB.Visible = suntDateDeSalvatDinFisier;
            btnSalveazaDateRestaurateInDB.Enabled = suntDateDeSalvatDinFisier;
        }

        private void ActualizeazaStareControaleEditare(bool editareActiva)
        {
            ltbNume.ReadOnly = !editareActiva;
            ltbPrenume.ReadOnly = !editareActiva;
            ltbAdresa.ReadOnly = !editareActiva;
            ltbTelefon.ReadOnly = !editareActiva;
            ltbEmail.ReadOnly = !editareActiva;

            btnSalveaza.Enabled = editareActiva; 
            btnAnuleaza.Enabled = editareActiva;

            btnAdauga.Enabled = !editareActiva;

            bool itemSelectatInListView = listViewClienti.SelectedItems.Count > 0;
            btnModifica.Enabled = !editareActiva && itemSelectatInListView;
            btnSterge.Enabled = !editareActiva && itemSelectatInListView && !_dateDinFisierNesalvate; 

            listViewClienti.Enabled = !editareActiva;

        }

        private void GolesteCampuriDetalii()
        {
            lblIdClient.Text = "0";
            ltbNume.Text = "";
            ltbPrenume.Text = "";
            ltbAdresa.Text = "";
            ltbTelefon.Text = "";
            ltbEmail.Text = "";
            errorProvider.Clear();
        }

        private void listViewClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_modEditare) return;

            if (listViewClienti.SelectedItems.Count > 0)
            {
                Client clientSelectat = (Client)listViewClienti.SelectedItems[0].Tag;
                lblIdClient.Text = clientSelectat.IdClient.ToString();
                ltbNume.Text = clientSelectat.Nume;
                ltbPrenume.Text = clientSelectat.Prenume;
                ltbAdresa.Text = clientSelectat.Adresa;
                ltbTelefon.Text = clientSelectat.Telefon;
                ltbEmail.Text = clientSelectat.Email;
            }
            else
            {
                GolesteCampuriDetalii();
            }
            ActualizeazaStareControaleEditare(false);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            _modEditare = false;
            GolesteCampuriDetalii();
            ActualizeazaStareControaleEditare(true);
            ltbNume.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (listViewClienti.SelectedItems.Count > 0)
            {
                _modEditare = true;
                ActualizeazaStareControaleEditare(true);
                ltbNume.Focus();
            }
            else
            {
                MessageBox.Show("Selectați un client pentru a-l modifica.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (_dateDinFisierNesalvate)
            {
                MessageBox.Show("Această acțiune nu este permisă pentru datele încărcate din fișier și nesalvate.\n" +
                                "Salvați mai întâi datele în baza de date.", "Operație Nepermisă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listViewClienti.SelectedItems.Count > 0)
            {
                Client clientSelectat = (Client)listViewClienti.SelectedItems[0].Tag;
                if (clientSelectat.IdClient == 0)
                {
                    MessageBox.Show("Acest client nu pare a fi salvat în baza de date.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Sunteți sigur că doriți să ștergeți clientul '{clientSelectat.Nume} {clientSelectat.Prenume}'?",
                                    "Confirmare Ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _managerDate.StergeClientDinDb(clientSelectat.IdClient);
                        IncarcaClientiDinDbSiAfiseaza();
                        MessageBox.Show("Clientul a fost șters cu succes.", "Ștergere reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la ștergerea clientului: {ex.Message}", "Eroare Ștergere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectați un client pentru a-l șterge.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Camp_Validating(object sender, CancelEventArgs e)
        {
            Control controlValidat = sender as Control;
            if (sender is TextBox tbInsideLabeledTb)
            {
                controlValidat = tbInsideLabeledTb.Parent as ControaleUtilizator.LabeledTextBox;
            }


            if (controlValidat == null || !controlValidat.Enabled || (controlValidat is ControaleUtilizator.LabeledTextBox ltb && ltb.ReadOnly))
            {
                if (controlValidat != null) errorProvider.SetError(controlValidat, ""); 
                return;
            }

            if (sender == ltbNume.TextBoxInstance)
            {
                if (string.IsNullOrWhiteSpace(ltbNume.Text))
                    errorProvider.SetError(ltbNume, "Numele este obligatoriu.");
                else
                    errorProvider.SetError(ltbNume, "");
            }
            else if (sender == ltbEmail.TextBoxInstance)
            {
                if (!string.IsNullOrWhiteSpace(ltbEmail.Text) && !Regex.IsMatch(ltbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    errorProvider.SetError(ltbEmail, "Format email invalid.");
                else
                    errorProvider.SetError(ltbEmail, "");
            }
            else if (sender == ltbTelefon.TextBoxInstance)
            {
                if (!string.IsNullOrWhiteSpace(ltbTelefon.Text))
                {
                    string patternTelefonGeneral = @"^(\+?\d{1,3}[ -]?)?\(?\d{1,4}\)?[ -]?\d{1,4}[ -]?\d{1,4}[ -]?\d{1,9}$";
                    if (!Regex.IsMatch(ltbTelefon.Text, patternTelefonGeneral))
                        errorProvider.SetError(ltbTelefon, "Format telefon invalid.");
                    else
                        errorProvider.SetError(ltbTelefon, "");
                }
                else
                {
                    errorProvider.SetError(ltbTelefon, "");
                }
            }
        }

        private bool ValideazaDateInainteDeSalvare()
        {
            bool valid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(ltbNume.Text))
            {
                errorProvider.SetError(ltbNume, "Numele este obligatoriu.");
                valid = false;
            }
            if (!string.IsNullOrWhiteSpace(ltbEmail.Text) && !Regex.IsMatch(ltbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(ltbEmail, "Format email invalid.");
                valid = false;
            }

            if (!string.IsNullOrWhiteSpace(ltbTelefon.Text))
            {
                string patternTelefonGeneral = @"^(\+?\d{1,3}[ -]?)?\(?\d{1,4}\)?[ -]?\d{1,4}[ -]?\d{1,4}[ -]?\d{1,9}$";
                if (!Regex.IsMatch(ltbTelefon.Text, patternTelefonGeneral))
                {
                    errorProvider.SetError(ltbTelefon, "Formatul numărului de telefon este invalid.");
                    valid = false;
                }
            }
            return valid;
        }

        private string NormalizareTelefon(string telefonInput)
        {
            if (string.IsNullOrWhiteSpace(telefonInput)) return null;
            string tempTelefon = telefonInput;
            bool arePlus = tempTelefon.StartsWith("+");
            tempTelefon = Regex.Replace(tempTelefon, @"[^\d]", "");
            if (arePlus && !tempTelefon.StartsWith("+"))
            {
                return "+" + tempTelefon;
            }
            return string.IsNullOrEmpty(tempTelefon) ? null : tempTelefon;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!ValideazaDateInainteDeSalvare())
            {
                MessageBox.Show("Există erori în formular. Vă rugăm corectați-le.", "Validare Eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Client client = new Client
            {
                IdClient = int.TryParse(lblIdClient.Text, out int id) ? id : 0,
                Nume = ltbNume.Text.Trim(),
                Prenume = string.IsNullOrWhiteSpace(ltbPrenume.Text) ? null : ltbPrenume.Text.Trim(),
                Adresa = string.IsNullOrWhiteSpace(ltbAdresa.Text) ? null : ltbAdresa.Text.Trim(),
                Telefon = NormalizareTelefon(ltbTelefon.Text),
                Email = string.IsNullOrWhiteSpace(ltbEmail.Text) ? null : ltbEmail.Text.Trim().ToLowerInvariant() 
            };

            try
            {
                if (_modEditare)
                {
                    _managerDate.ActualizeazaClientInDb(client);
                    MessageBox.Show("Clientul a fost actualizat cu succes.", "Actualizare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    client.IdClient = _managerDate.AdaugaClientInDb(client);
                    MessageBox.Show("Clientul a fost adăugat cu succes.", "Adăugare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _modEditare = false;
                _dateDinFisierNesalvate = false;
                ActualizeazaVizibilitateButonSalvareRestaurate();
                IncarcaClientiDinDbSiAfiseaza();
                SelecteazaClientInListView(client.IdClient);
                ActualizeazaStareControaleEditare(false);
            }
            catch (InvalidOperationException ioEx)
            {
                MessageBox.Show(ioEx.Message, "Eroare de Unicitate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ltbEmail.Focus();
                ltbEmail.TextBoxInstance.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea clientului: {ex.Message}", "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalveazaDateRestaurateInDB_Click(object sender, EventArgs e)
        {
            if (!_dateDinFisierNesalvate || _listaClienti == null || !_listaClienti.Any())
            {
                MessageBox.Show("Nu există date restaurate din fișier pentru a fi salvate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Sunteți sigur că doriți să încercați salvarea celor {_listaClienti.Count} clienți încărcați din fișier în baza de date?\n" +
                                "Se va încerca adăugarea fiecărui client. Cei cu email deja existent în baza de date vor fi omiși.",
                                "Confirmare Salvare Date Restaurate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int clientiAdaugatiCuSucces = 0;
            int clientiOmitiSauCuEroare = 0;
            List<string> detaliiErori = new List<string>();

            foreach (Client clientDinFisier in _listaClienti)
            {
                try
                {
                    Client clientPentruDb = new Client
                    {
                        Nume = clientDinFisier.Nume,
                        Prenume = clientDinFisier.Prenume,
                        Adresa = clientDinFisier.Adresa,
                        Telefon = NormalizareTelefon(clientDinFisier.Telefon),
                        Email = string.IsNullOrWhiteSpace(clientDinFisier.Email) ? null : clientDinFisier.Email.Trim().ToLowerInvariant()
                    };

                    _managerDate.AdaugaClientInDb(clientPentruDb);
                    clientiAdaugatiCuSucces++;
                }
                catch (InvalidOperationException exUnicitate)
                {
                    clientiOmitiSauCuEroare++;
                    detaliiErori.Add($"Client '{clientDinFisier.Nume} {clientDinFisier.Prenume}' ({clientDinFisier.Email}): {exUnicitate.Message}");
                }
                catch (Exception ex)
                {
                    clientiOmitiSauCuEroare++;
                    detaliiErori.Add($"Eroare la salvarea clientului '{clientDinFisier.Nume} {clientDinFisier.Prenume}': {ex.Message}");
                }
            }

            string mesajFinal = $"Proces de salvare în masă finalizat.\n" +
                                $"Clienți noi adăugați în DB: {clientiAdaugatiCuSucces}\n" +
                                $"Clienți omiși (email existent) sau cu erori: {clientiOmitiSauCuEroare}\n";
            if (detaliiErori.Any())
            {
                mesajFinal += "\nDetalii erori/omiteri:\n" + string.Join("\n", detaliiErori);
                MessageBox.Show(mesajFinal, "Rezultat Salvare Date Restaurate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(mesajFinal, "Rezultat Salvare Date Restaurate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _dateDinFisierNesalvate = false;
            IncarcaClientiDinDbSiAfiseaza();
            ActualizeazaStareControaleEditare(false);
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            _modEditare = false;

            if (_dateDinFisierNesalvate)
            {
                GolesteCampuriDetalii();
            }
            else if (listViewClienti.SelectedItems.Count > 0)
            {
                listViewClienti_SelectedIndexChanged(sender, e);
            }
            else
            {
                GolesteCampuriDetalii();
            }
            ActualizeazaStareControaleEditare(false);
        }

        private void SelecteazaClientInListView(int idClient)
        {
            foreach (ListViewItem item in listViewClienti.Items)
            {
                if (item.Tag is Client clientDinItem && clientDinItem.IdClient == idClient)
                {
                    item.Selected = true;
                    item.Focused = true;
                    listViewClienti.EnsureVisible(item.Index);
                    break;
                }
            }
        }

         private void FormClienti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S && btnSalveaza.Enabled)
            {
                btnSalveaza_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.N && btnAdauga.Enabled)
            {
                btnAdauga_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape && btnAnuleaza.Enabled)
            {
                btnAnuleaza_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete && btnSterge.Enabled)
            {
                btnSterge_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void contextMenuClienti_Opening(object sender, CancelEventArgs e)
        {
            bool itemSelectat = listViewClienti.SelectedItems.Count > 0;
            modificaClientToolStripMenuItem.Enabled = itemSelectat && btnModifica.Enabled && !_dateDinFisierNesalvate;
            stergeClientToolStripMenuItem.Enabled = itemSelectat && btnSterge.Enabled && !_dateDinFisierNesalvate;

            if (_dateDinFisierNesalvate && itemSelectat)
            {
                e.Cancel = true;
                MessageBox.Show("Acțiunile contextuale sunt disponibile doar pentru datele din baza de date.\n" +
                                "Salvați mai întâi datele restaurate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listViewClienti_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _sortColumn)
            {
                listViewClienti.Sorting = (listViewClienti.Sorting == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                listViewClienti.Sorting = SortOrder.Ascending;
            }
            _sortColumn = e.Column;
            listViewClienti.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewClienti.Sorting);
            listViewClienti.Sort();
        }
    }

    public class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal;
            string textX = ((ListViewItem)x).SubItems[col].Text;
            string textY = ((ListViewItem)y).SubItems[col].Text;

            returnVal = string.Compare(textX, textY);

            if (order == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
}