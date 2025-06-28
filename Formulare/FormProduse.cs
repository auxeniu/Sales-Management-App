using ProiectVanzari.Clase;
using ProiectVanzari.Servicii;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ProiectVanzari.Formulare
{
    public partial class FormProduse : Form
    {
        private ManagerDate _managerDate;
        private List<Produs> _listaProduse;
        private bool _modEditare = false;
        private bool _dateProduseDinFisierNesalvate = false;
        private int _sortColumnProduse = -1;

        public FormProduse()
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            _listaProduse = new List<Produs>();

            ltbDenumire.TextBoxInstance.Validating += CampValidatingProdus;
            ltbPret.TextBoxInstance.Validating += CampValidatingProdus;
            ltbStoc.TextBoxInstance.Validating += CampValidatingProdus;
        }

        private void FormProduse_Load(object sender, EventArgs e)
        {
            IncarcaProduseDinDbSiAfiseaza();
            ActualizeazaStareControaleEditare(false);
            btnSalveazaDateRestaurateProduseInDB.Visible = false;
            btnSalveazaDateRestaurateProduseInDB.Enabled = false;
        }

        private void IncarcaProduseDinDbSiAfiseaza()
        {
            try
            {
                _listaProduse = _managerDate.IncarcaProduseDinDb();
                AfiseazaProduseInListView();
                _dateProduseDinFisierNesalvate = false;
                ActualizeazaVizibilitateButonSalvareRestaurate();
                GolesteCampuriDetalii();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea produselor din baza de date: {ex.Message}", "Eroare Încărcare DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IncarcaProduseDinLista(List<Produs> produseRestaurate)
        {
            _listaProduse = produseRestaurate ?? new List<Produs>();
            AfiseazaProduseInListView();

            if (produseRestaurate != null && produseRestaurate.Any())
            {
                _dateProduseDinFisierNesalvate = true;
                MessageBox.Show("Produsele din fișier au fost încărcate în listă.\n" +
                                "Puteți să le salvați în baza de date folosind butonul 'Salvare Produse Restaurate în DB' " +
                                "sau să interacționați individual cu ele (Adaugă/Modifică).",
                                "Produse Restaurate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _dateProduseDinFisierNesalvate = false;
            }
            ActualizeazaVizibilitateButonSalvareRestaurate();
            ActualizeazaStareControaleEditare(false);
            GolesteCampuriDetalii();
        }

        private void AfiseazaProduseInListView()
        {
            listViewProduse.Items.Clear();
            if (_listaProduse == null) return;

            foreach (var produs in _listaProduse)
            {
                ListViewItem item = new ListViewItem(produs.Denumire);
                item.SubItems.Add(produs.Pret.ToString("N2", CultureInfo.InvariantCulture) + " RON");
                item.SubItems.Add(produs.Stoc.ToString());
                item.Tag = produs;
                listViewProduse.Items.Add(item);
            }
        }

        private void ActualizeazaVizibilitateButonSalvareRestaurate()
        {
            bool suntDateDeSalvat = _dateProduseDinFisierNesalvate && _listaProduse != null && _listaProduse.Any();
            btnSalveazaDateRestaurateProduseInDB.Visible = suntDateDeSalvat;
            btnSalveazaDateRestaurateProduseInDB.Enabled = suntDateDeSalvat;
        }

        private void ActualizeazaStareControaleEditare(bool editareActiva)
        {
            ltbDenumire.ReadOnly = !editareActiva;
            ltbPret.ReadOnly = !editareActiva;
            ltbStoc.ReadOnly = !editareActiva;

            btnSalveaza.Enabled = editareActiva;
            btnAnuleaza.Enabled = editareActiva;

            btnAdauga.Enabled = !editareActiva;

            bool itemSelectat = listViewProduse.SelectedItems.Count > 0;
            btnModifica.Enabled = !editareActiva && itemSelectat;
            btnSterge.Enabled = !editareActiva && itemSelectat && !_dateProduseDinFisierNesalvate;

            listViewProduse.Enabled = !editareActiva;
        }

        private void GolesteCampuriDetalii()
        {
            lblIdProdus.Text = "0";
            ltbDenumire.Text = "";
            ltbPret.Text = "";
            ltbStoc.Text = "";
            errorProvider.Clear();
        }

        private void listViewProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_modEditare) return;

            if (listViewProduse.SelectedItems.Count > 0)
            {
                Produs produsSelectat = (Produs)listViewProduse.SelectedItems[0].Tag;
                lblIdProdus.Text = produsSelectat.IdProdus.ToString();
                ltbDenumire.Text = produsSelectat.Denumire;
                ltbPret.Text = produsSelectat.Pret.ToString("F2", CultureInfo.InvariantCulture);
                ltbStoc.Text = produsSelectat.Stoc.ToString();
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
            ltbDenumire.TextBoxInstance.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (listViewProduse.SelectedItems.Count > 0)
            {
                _modEditare = true;
                ActualizeazaStareControaleEditare(true);
                ltbDenumire.TextBoxInstance.Focus();
            }
            else
            {
                MessageBox.Show("Selectați un produs pentru a-l modifica.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (_dateProduseDinFisierNesalvate)
            {
                MessageBox.Show("Această acțiune nu este permisă pentru datele încărcate din fișier și nesalvate.\n" +
                                "Salvați mai întâi datele în baza de date.", "Operație Nepermisă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listViewProduse.SelectedItems.Count > 0)
            {
                Produs produsSelectat = (Produs)listViewProduse.SelectedItems[0].Tag;
                if (produsSelectat.IdProdus == 0)
                {
                    MessageBox.Show("Acest produs nu pare a fi salvat în baza de date.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Sunteți sigur că doriți să ștergeți produsul '{produsSelectat.Denumire}'?\n" +
                                    "ATENȚIE: Produsul nu poate fi șters dacă este inclus în tranzacții existente.",
                                    "Confirmare Ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _managerDate.StergeProdusDinDb(produsSelectat.IdProdus);
                        IncarcaProduseDinDbSiAfiseaza();
                        MessageBox.Show("Produsul a fost șters cu succes.", "Ștergere Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidOperationException ioEx) 
                    {
                        MessageBox.Show(ioEx.Message, "Operație Nepermisă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la ștergerea produsului: {ex.Message}", "Eroare Ștergere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectați un produs pentru a-l șterge.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CampValidatingProdus(object sender, CancelEventArgs e)
        {
            Control controlValidat = sender as Control;
            if (sender is TextBox tbInLabeled)
            {
                controlValidat = tbInLabeled.Parent as ControaleUtilizator.LabeledTextBox;
            }

            if (controlValidat == null || !controlValidat.Enabled || (controlValidat is ControaleUtilizator.LabeledTextBox ltbC && ltbC.ReadOnly))
            {
                if (controlValidat != null) errorProvider.SetError(controlValidat, "");
                return;
            }

            if (sender == ltbDenumire.TextBoxInstance)
            {
                if (string.IsNullOrWhiteSpace(ltbDenumire.Text))
                    errorProvider.SetError(ltbDenumire, "Denumirea este obligatorie.");
                else
                    errorProvider.SetError(ltbDenumire, "");
            }
            else if (sender == ltbPret.TextBoxInstance)
            {
                if (string.IsNullOrWhiteSpace(ltbPret.Text))
                    errorProvider.SetError(ltbPret, "Prețul este obligatoriu.");
                else if (!decimal.TryParse(ltbPret.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal pret) || pret < 0)
                    errorProvider.SetError(ltbPret, "Prețul trebuie să fie un număr pozitiv.");
                else
                    errorProvider.SetError(ltbPret, "");
            }
            else if (sender == ltbStoc.TextBoxInstance)
            {
                if (string.IsNullOrWhiteSpace(ltbStoc.Text))
                    errorProvider.SetError(ltbStoc, "Stocul este obligatoriu.");
                else if (!int.TryParse(ltbStoc.Text, out int stoc) || stoc < 0)
                    errorProvider.SetError(ltbStoc, "Stocul trebuie să fie un număr întreg nenegativ.");
                else
                    errorProvider.SetError(ltbStoc, "");
            }
        }

        private bool ValideazaDateInainteDeSalvare()
        {
            bool valid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(ltbDenumire.Text))
            {
                errorProvider.SetError(ltbDenumire.TextBoxInstance, "Denumirea este obligatorie.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(ltbPret.Text))
            {
                errorProvider.SetError(ltbPret.TextBoxInstance, "Prețul este obligatoriu.");
                valid = false;
            }
            else if (!decimal.TryParse(ltbPret.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal pret) || pret < 0)
            {
                errorProvider.SetError(ltbPret.TextBoxInstance, "Prețul trebuie să fie un număr zecimal pozitiv.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(ltbStoc.Text))
            {
                errorProvider.SetError(ltbStoc.TextBoxInstance, "Stocul este obligatoriu.");
                valid = false;
            }
            else if (!int.TryParse(ltbStoc.Text, out int stoc) || stoc < 0)
            {
                errorProvider.SetError(ltbStoc.TextBoxInstance, "Stocul trebuie să fie un număr întreg nenegativ.");
                valid = false;
            }
            return valid;
        }
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!ValideazaDateInainteDeSalvare())
            {
                MessageBox.Show("Există erori în formular. Vă rugăm corectați-le.", "Validare Eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal pretProdus;
            if (!decimal.TryParse(ltbPret.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out pretProdus))
            {
                errorProvider.SetError(ltbPret.TextBoxInstance, "Format preț invalid.");
                return;
            }

            int stocProdus;
            if (!int.TryParse(ltbStoc.Text, out stocProdus))
            {
                errorProvider.SetError(ltbStoc.TextBoxInstance, "Format stoc invalid.");
                return;
            }


            Produs produs = new Produs
            {
                IdProdus = int.TryParse(lblIdProdus.Text, out int id) ? id : 0,
                Denumire = ltbDenumire.Text.Trim(),
                Pret = pretProdus,
                Stoc = stocProdus
            };

            try
            {
                if (_modEditare)
                {
                    _managerDate.ActualizeazaProdusInDb(produs);
                    MessageBox.Show("Produsul a fost actualizat cu succes.", "Actualizare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    produs.IdProdus = _managerDate.AdaugaProdusInDb(produs);
                    MessageBox.Show("Produsul a fost adăugat cu succes.", "Adăugare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _modEditare = false;
                _dateProduseDinFisierNesalvate = false;
                ActualizeazaVizibilitateButonSalvareRestaurate();
                IncarcaProduseDinDbSiAfiseaza();
                SelecteazaProdusInListView(produs.IdProdus);
                ActualizeazaStareControaleEditare(false);
            }
             catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea produsului: {ex.Message}", "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalveazaDateRestaurateProduseInDB_Click(object sender, EventArgs e)
        {
            if (!_dateProduseDinFisierNesalvate || _listaProduse == null || !_listaProduse.Any())
            {
                MessageBox.Show("Nu există date de produse restaurate din fișier pentru a fi salvate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Sunteți sigur că doriți să încercați salvarea celor {_listaProduse.Count} produse încărcate din fișier în baza de date?\n" +
                                "Se va încerca adăugarea fiecărui produs. Produsele cu denumire deja existentă (dacă ManagerDate verifică) vor fi omise.",
                                "Confirmare Salvare Produse Restaurate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int produseAdaugateCuSucces = 0;
            int produseOmitiseSauCuEroare = 0;
            List<string> detaliiErori = new List<string>();

            foreach (Produs produsDinFisier in _listaProduse)
            {
                try
                {
                    Produs produsPentruDb = new Produs
                    {
                        Denumire = produsDinFisier.Denumire,
                        Pret = produsDinFisier.Pret,
                        Stoc = produsDinFisier.Stoc
                    };
                    _managerDate.AdaugaProdusInDb(produsPentruDb);
                    produseAdaugateCuSucces++;
                }
                catch (InvalidOperationException exUnicitate)
                {
                    produseOmitiseSauCuEroare++;
                    detaliiErori.Add($"Produsul '{produsDinFisier.Denumire}': {exUnicitate.Message}");
                }
                catch (Exception ex)
                {
                    produseOmitiseSauCuEroare++;
                    detaliiErori.Add($"Eroare la salvarea produsului '{produsDinFisier.Denumire}': {ex.Message}");
                }
            }

            string mesajFinal = $"Proces de salvare în masă finalizat.\n" +
                                $"Produse noi adăugate în DB: {produseAdaugateCuSucces}\n" +
                                $"Produse omise (denumire existentă) sau cu erori: {produseOmitiseSauCuEroare}\n";
            if (detaliiErori.Any())
            {
                mesajFinal += "\nDetalii erori/omiteri:\n" + string.Join("\n", detaliiErori);
                MessageBox.Show(mesajFinal, "Rezultat Salvare Produse Restaurate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(mesajFinal, "Rezultat Salvare Produse Restaurate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _dateProduseDinFisierNesalvate = false;
            IncarcaProduseDinDbSiAfiseaza();
            ActualizeazaStareControaleEditare(false);
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            _modEditare = false;

            if (_dateProduseDinFisierNesalvate)
            {
                GolesteCampuriDetalii();
            }
            else if (listViewProduse.SelectedItems.Count > 0)
            {
                listViewProduse_SelectedIndexChanged(sender, e);
            }
            else
            {
                GolesteCampuriDetalii();
            }
            ActualizeazaStareControaleEditare(false);
        }

        private void SelecteazaProdusInListView(int idProdus)
        {
            foreach (ListViewItem item in listViewProduse.Items)
            {
                if (item.Tag is Produs produsDinItem && produsDinItem.IdProdus == idProdus)
                {
                    item.Selected = true;
                    item.Focused = true;
                    listViewProduse.EnsureVisible(item.Index);
                    break;
                }
            }
        }

       private void FormProduse_KeyDown(object sender, KeyEventArgs e)
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

        private void contextMenuProduse_Opening(object sender, CancelEventArgs e)
        {
            bool itemSelectat = listViewProduse.SelectedItems.Count > 0;
            modificaProdusToolStripMenuItem.Enabled = itemSelectat && btnModifica.Enabled && !_dateProduseDinFisierNesalvate;
            stergeProdusToolStripMenuItem.Enabled = itemSelectat && btnSterge.Enabled && !_dateProduseDinFisierNesalvate;

            if (_dateProduseDinFisierNesalvate && itemSelectat)
            {
                e.Cancel = true;
                MessageBox.Show("Acțiunile contextuale sunt disponibile doar pentru datele din baza de date.\n" +
                                "Salvați mai întâi datele restaurate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listViewProduse_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _sortColumnProduse)
            {
                listViewProduse.Sorting = (listViewProduse.Sorting == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                listViewProduse.Sorting = SortOrder.Ascending;
            }
            _sortColumnProduse = e.Column;
            listViewProduse.ListViewItemSorter = new ListViewItemComparerProduse(e.Column, listViewProduse.Sorting);
            listViewProduse.Sort();
        }
    }

    public class ListViewItemComparerProduse : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparerProduse(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal;
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            
            if (col == 1)
            {
                decimal valX, valY;
                string textPriceX = itemX.SubItems[col].Text.Replace(" RON", "").Trim().Replace(",", ".");
                string textPriceY = itemY.SubItems[col].Text.Replace(" RON", "").Trim().Replace(",", ".");

                if (decimal.TryParse(textPriceX, NumberStyles.Any, CultureInfo.InvariantCulture, out valX) &&
                    decimal.TryParse(textPriceY, NumberStyles.Any, CultureInfo.InvariantCulture, out valY))
                {
                    returnVal = decimal.Compare(valX, valY);
                }
                else
                {
                    returnVal = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text); 
                }
            }
            else if (col == 2)
            {
                int valX, valY;
                if (int.TryParse(itemX.SubItems[col].Text, out valX) && int.TryParse(itemY.SubItems[col].Text, out valY))
                {
                    returnVal = valX.CompareTo(valY);
                }
                else
                {
                    returnVal = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text); 
                }
            }
            else 
            {
                returnVal = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text);
            }

            if (order == SortOrder.Descending)
                returnVal *= -1;

            return returnVal;
        }
    }
}