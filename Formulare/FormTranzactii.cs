using ProiectVanzari.Clase;
using ProiectVanzari.Servicii;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ProiectVanzari.Formulare
{
    public partial class FormTranzactii : Form
    {
        private ManagerDate _managerDate;
        private List<Client> _listaClienti;
        private List<Produs> _listaProduseDisponibile; 
        private Tranzactie _tranzactieCurenta;
        private List<Tranzactie> _listaTranzactiiExistente;

        public FormTranzactii()
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            _listaClienti = new List<Client>();
            _listaProduseDisponibile = new List<Produs>();
            _tranzactieCurenta = new Tranzactie(); 
            _listaTranzactiiExistente = new List<Tranzactie>();
        }

        private void FormTranzactii_Load(object sender, EventArgs e)
        {
            IncarcaDateInitiale();
            AfiseazaTranzactiiExistente();
            ConfigureazaNouaTranzactie(); 
        }

        private void IncarcaDateInitiale()
        {
            try
            {
                _listaClienti = _managerDate.IncarcaClientiDinDb();
                cmbClienti.DataSource = null; 
                cmbClienti.DataSource = _listaClienti;
                cmbClienti.DisplayMember = "ToString"; 
                cmbClienti.ValueMember = "IdClient";
                cmbClienti.SelectedIndex = -1; 

                _listaProduseDisponibile = _managerDate.IncarcaProduseDinDb().Where(p => p.Stoc > 0).ToList(); 

                cmbProduseDisponibile.DataSource = null;
                cmbProduseDisponibile.DataSource = _listaProduseDisponibile;
                cmbProduseDisponibile.DisplayMember = "ToString"; 
                cmbProduseDisponibile.ValueMember = "IdProdus";
                cmbProduseDisponibile.SelectedIndex = -1;

                
                listBoxProduseSursaDragDrop.DataSource = null;
                listBoxProduseSursaDragDrop.DataSource = _listaProduseDisponibile.ToList(); 
                listBoxProduseSursaDragDrop.DisplayMember = "ToString";
                listBoxProduseSursaDragDrop.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea datelor inițiale: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureazaNouaTranzactie()
        {
            _tranzactieCurenta = new Tranzactie(); 
            dtpDataTranzactie.Value = DateTime.Now;
            cmbClienti.SelectedIndex = -1;
            cmbProduseDisponibile.SelectedIndex = -1;
            nudCantitate.Value = 1;
            listViewProduseTranzactie.Items.Clear();
            txtTotalGeneralTranzactie.Text = 0.ToString("C");
            btnStergeProdusDinTranzactie.Enabled = false;
            groupBoxTranzactieCurenta.Text = "Detalii Tranzacție Nouă";
            
            IncarcaDateInitiale();
        }

        private void cmbProduseDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduseDisponibile.SelectedItem is Produs produsSelectat)
            {
                nudCantitate.Maximum = produsSelectat.Stoc; 
                nudCantitate.Value = 1; 
            }
            else
            {
                nudCantitate.Maximum = 1000; 
            }
        }

        private void btnAdaugaProdusInTranzactie_Click(object sender, EventArgs e)
        {
            AdaugaProdusSelectatInTranzactie();
        }

        private void AdaugaProdusSelectatInTranzactie(Produs produsPrimit = null, int cantitatePrimita = 0)
        {
            Produs produsSelectat = produsPrimit ?? (cmbProduseDisponibile.SelectedItem as Produs);
            int cantitate = (cantitatePrimita > 0) ? cantitatePrimita : (int)nudCantitate.Value;

            if (produsSelectat == null)
            {
                MessageBox.Show("Selectați un produs.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantitate <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie mai mare decât zero.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantitate > produsSelectat.Stoc)
            {
                MessageBox.Show($"Cantitatea solicitată ({cantitate}) depășește stocul disponibil ({produsSelectat.Stoc}).", "Stoc insuficient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            ProdusVandut produsExistent = _tranzactieCurenta.ProduseVandute
                .FirstOrDefault(pv => pv.ProdusAsociat.IdProdus == produsSelectat.IdProdus);

            if (produsExistent != null)
            {
                
                if (produsExistent.Cantitate + cantitate > produsSelectat.Stoc)
                {
                    MessageBox.Show($"Cantitatea totală ({produsExistent.Cantitate + cantitate}) depășește stocul disponibil ({produsSelectat.Stoc}).", "Stoc insuficient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                produsExistent.Cantitate += cantitate;
            }
            else
            {
                
                _tranzactieCurenta.ProduseVandute.Add(new ProdusVandut(produsSelectat, cantitate, produsSelectat.Pret));
            }

            AfiseazaProduseInTranzactieCurenta();
            CalculeazaTotalGeneralTranzactie();
            
            cmbProduseDisponibile.SelectedIndex = -1;
            nudCantitate.Value = 1;
            cmbProduseDisponibile.Focus();
        }


        private void AfiseazaProduseInTranzactieCurenta()
        {
            listViewProduseTranzactie.Items.Clear();
            if (_tranzactieCurenta?.ProduseVandute == null) return;

            foreach (var pv in _tranzactieCurenta.ProduseVandute)
            {
                ListViewItem item = new ListViewItem(pv.ProdusAsociat.Denumire);
                item.SubItems.Add(pv.Cantitate.ToString());
                item.SubItems.Add(pv.PretUnitarLaVanzare.ToString("C"));
                item.SubItems.Add(pv.ValoareTotala.ToString("C"));
                item.Tag = pv; 
                listViewProduseTranzactie.Items.Add(item);
            }
        }

        private void CalculeazaTotalGeneralTranzactie()
        {
            txtTotalGeneralTranzactie.Text = _tranzactieCurenta.TotalGeneral.ToString("C");
        }

        private void listViewProduseTranzactie_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStergeProdusDinTranzactie.Enabled = listViewProduseTranzactie.SelectedItems.Count > 0;
        }

        private void btnStergeProdusDinTranzactie_Click(object sender, EventArgs e)
        {
            if (listViewProduseTranzactie.SelectedItems.Count > 0)
            {
                ProdusVandut pvSelectat = (ProdusVandut)listViewProduseTranzactie.SelectedItems[0].Tag;
                _tranzactieCurenta.ProduseVandute.Remove(pvSelectat);
                AfiseazaProduseInTranzactieCurenta();
                CalculeazaTotalGeneralTranzactie();
            }
        }

        private void btnAnuleazaTranzactieNoua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteți sigur că doriți să anulați tranzacția curentă? Toate produsele adăugate vor fi pierdute.",
                                "Confirmare Anulare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ConfigureazaNouaTranzactie();
            }
        }

        private void btnSalveazaTranzactie_Click(object sender, EventArgs e)
        {
            if (_tranzactieCurenta.ProduseVandute.Count == 0)
            {
                MessageBox.Show("Tranzacția nu conține niciun produs.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tranzactieCurenta.ClientAsociat = cmbClienti.SelectedItem as Client; 
            _tranzactieCurenta.DataTranzactie = dtpDataTranzactie.Value;
            

            try
            {
                _managerDate.AdaugaTranzactieInDb(_tranzactieCurenta);
                MessageBox.Show("Tranzacția a fost salvată cu succes!", "Salvare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AfiseazaTranzactiiExistente(); 
                ConfigureazaNouaTranzactie(); 
                IncarcaDateInitiale(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea tranzacției: {ex.Message}\n{ex.StackTrace}", "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void FormTranzactii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) 
            {
                btnSalveazaTranzactie_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        private void nudCantitate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdaugaProdusInTranzactie_Click(sender, e);
                e.SuppressKeyPress = true; 
            }
        }


        
        private void listBoxProduseSursaDragDrop_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxProduseSursaDragDrop.SelectedItem != null)
            {
                
                listBoxProduseSursaDragDrop.DoDragDrop(listBoxProduseSursaDragDrop.SelectedItem, DragDropEffects.Copy);
            }
        }

        private void listViewProduseTranzactie_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(typeof(Produs)))
            {
                e.Effect = DragDropEffects.Copy; 
            }
            else
            {
                e.Effect = DragDropEffects.None; 
            }
        }

        private void listViewProduseTranzactie_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Produs)))
            {
                Produs produsTras = (Produs)e.Data.GetData(typeof(Produs));
                using (FormCantitateDragDrop formCant = new FormCantitateDragDrop(produsTras.Stoc))
                {
                    if (formCant.ShowDialog(this) == DialogResult.OK)
                    {
                        int cantitateSelectata = formCant.CantitateSelectata;
                        AdaugaProdusSelectatInTranzactie(produsTras, cantitateSelectata);
                    }
                }
            }
        }
        private void AfiseazaTranzactiiExistente()
        {
            try
            {
                _listaTranzactiiExistente = _managerDate.IncarcaTranzactiiDinDb();
                listViewTranzactiiExistente.Items.Clear();

                foreach (var tr in _listaTranzactiiExistente)
                {
                    ListViewItem item = new ListViewItem(tr.IdTranzactie.ToString());
                    item.SubItems.Add(tr.DataTranzactie.ToString("dd/MM/yyyy HH:mm"));
                    item.SubItems.Add(tr.ClientAsociat?.ToString() ?? "Client Șters/Nespecificat");
                    item.SubItems.Add(tr.TotalGeneral.ToString("C"));
                    item.Tag = tr; 
                    listViewTranzactiiExistente.Items.Add(item);
                }
                btnStergeTranzactieSelectata.Enabled = false;
                btnTiparesteTranzactie.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea tranzacțiilor existente: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewTranzactiiExistente_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectat = listViewTranzactiiExistente.SelectedItems.Count > 0;
            btnStergeTranzactieSelectata.Enabled = selectat;
            btnTiparesteTranzactie.Enabled = selectat;

            if (selectat)
            {
            }
        }

        private void btnStergeTranzactieSelectata_Click(object sender, EventArgs e)
        {
            if (listViewTranzactiiExistente.SelectedItems.Count > 0)
            {
                Tranzactie trSelectata = (Tranzactie)listViewTranzactiiExistente.SelectedItems[0].Tag;
                if (MessageBox.Show($"Sunteți sigur că doriți să ștergeți tranzacția #{trSelectata.IdTranzactie}?\nATENȚIE: Stocurile produselor din această tranzacție vor fi refăcute (incrementate).",
                                    "Confirmare Ștergere Tranzacție", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _managerDate.StergeTranzactieDinDb(trSelectata.IdTranzactie);
                        MessageBox.Show("Tranzacția a fost ștearsă cu succes. Stocurile au fost actualizate.", "Ștergere Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfiseazaTranzactiiExistente(); 
                        IncarcaDateInitiale(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la ștergerea tranzacției: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private Tranzactie _tranzactieDeTiparit; 

        private void btnTiparesteTranzactie_Click(object sender, EventArgs e)
        {
            if (listViewTranzactiiExistente.SelectedItems.Count > 0)
            {
                _tranzactieDeTiparit = (Tranzactie)listViewTranzactiiExistente.SelectedItems[0].Tag;
                if (_tranzactieDeTiparit != null)
                {
                    printPreviewDialogTranzactie.Document = printDocumentTranzactie;
                    printPreviewDialogTranzactie.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Selectați o tranzacție pentru a o tipări.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocumentTranzactie_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (_tranzactieDeTiparit == null) return;

            Graphics g = e.Graphics;
            Font fontTitlu = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontText = new Font("Arial", 10);
            Font fontMic = new Font("Arial", 8);
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float lineHeight = fontText.GetHeight(g);
            float cellPadding = 5;
            string titlu = "FACTURĂ PROFORMĂ / BON DE VÂNZARE";
            SizeF titluSize = g.MeasureString(titlu, fontTitlu);
            g.DrawString(titlu, fontTitlu, Brushes.Black, leftMargin + (e.MarginBounds.Width - titluSize.Width) / 2, yPos);
            yPos += titluSize.Height + lineHeight * 2;

            
            g.DrawString($"Număr Tranzacție: {_tranzactieDeTiparit.IdTranzactie}", fontHeader, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString($"Data: {_tranzactieDeTiparit.DataTranzactie:dd/MM/yyyy HH:mm}", fontText, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 2;

            
            if (_tranzactieDeTiparit.ClientAsociat != null)
            {
                Client c = _tranzactieDeTiparit.ClientAsociat;
                g.DrawString("Client:", fontHeader, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
                g.DrawString($"{c.Nume} {c.Prenume ?? ""}", fontText, Brushes.Black, leftMargin + 20, yPos);
                yPos += lineHeight;
                if (!string.IsNullOrEmpty(c.Adresa))
                {
                    g.DrawString($"Adresă: {c.Adresa}", fontText, Brushes.Black, leftMargin + 20, yPos);
                    yPos += lineHeight;
                }
                if (!string.IsNullOrEmpty(c.Telefon))
                {
                    g.DrawString($"Telefon: {c.Telefon}", fontText, Brushes.Black, leftMargin + 20, yPos);
                    yPos += lineHeight;
                }
                if (!string.IsNullOrEmpty(c.Email))
                {
                    g.DrawString($"Email: {c.Email}", fontText, Brushes.Black, leftMargin + 20, yPos);
                    yPos += lineHeight;
                }
            }
            else
            {
                g.DrawString("Client: Nespecificat", fontText, Brushes.Black, leftMargin, yPos);
            }
            yPos += lineHeight * 2;

            
            g.DrawString("Produse Vândute:", fontHeader, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 1.5f;

            
            float[] colWidths = { (e.MarginBounds.Width * 0.40f), (e.MarginBounds.Width * 0.15f), (e.MarginBounds.Width * 0.20f), (e.MarginBounds.Width * 0.25f) };
            float currentX = leftMargin;

            g.FillRectangle(Brushes.LightGray, leftMargin, yPos, e.MarginBounds.Width, lineHeight + cellPadding / 2);
            g.DrawString("Denumire Produs", fontText, Brushes.Black, currentX + cellPadding / 2, yPos + cellPadding / 4);
            currentX += colWidths[0];
            g.DrawString("Cant.", fontText, Brushes.Black, currentX + cellPadding / 2, yPos + cellPadding / 4);
            currentX += colWidths[1];
            g.DrawString("Preț Unitar", fontText, Brushes.Black, currentX + cellPadding / 2, yPos + cellPadding / 4);
            currentX += colWidths[2];
            g.DrawString("Valoare", fontText, Brushes.Black, currentX + cellPadding / 2, yPos + cellPadding / 4);
            yPos += lineHeight + cellPadding / 2;

            
            foreach (var pv in _tranzactieDeTiparit.ProduseVandute)
            {
                if (yPos + lineHeight > e.MarginBounds.Bottom) 
                {
                    e.HasMorePages = true;
                    return;
                }
                currentX = leftMargin;
                g.DrawString(pv.ProdusAsociat.Denumire, fontText, Brushes.Black, new RectangleF(currentX + cellPadding / 2, yPos, colWidths[0] - cellPadding, lineHeight));
                currentX += colWidths[0];
                g.DrawString(pv.Cantitate.ToString(), fontText, Brushes.Black, new RectangleF(currentX + cellPadding / 2, yPos, colWidths[1] - cellPadding, lineHeight), new StringFormat { Alignment = StringAlignment.Far });
                currentX += colWidths[1];
                g.DrawString(pv.PretUnitarLaVanzare.ToString("C"), fontText, Brushes.Black, new RectangleF(currentX + cellPadding / 2, yPos, colWidths[2] - cellPadding, lineHeight), new StringFormat { Alignment = StringAlignment.Far });
                currentX += colWidths[2];
                g.DrawString(pv.ValoareTotala.ToString("C"), fontText, Brushes.Black, new RectangleF(currentX + cellPadding / 2, yPos, colWidths[3] - cellPadding, lineHeight), new StringFormat { Alignment = StringAlignment.Far });
                yPos += lineHeight;
                g.DrawLine(Pens.DarkGray, leftMargin, yPos, rightMargin, yPos); 
            }
            yPos += lineHeight;

            
            g.DrawString("Total General:", fontHeader, Brushes.Black, leftMargin + colWidths[0] + colWidths[1] + colWidths[2] - 100, yPos); 
            g.DrawString(_tranzactieDeTiparit.TotalGeneral.ToString("C"), fontHeader, Brushes.Black, rightMargin - g.MeasureString(_tranzactieDeTiparit.TotalGeneral.ToString("C"), fontHeader).Width, yPos);
            yPos += lineHeight * 2;

            
            string subsol = "Vă mulțumim!";
            SizeF subsolSize = g.MeasureString(subsol, fontMic);
            g.DrawString(subsol, fontMic, Brushes.Gray, leftMargin + (e.MarginBounds.Width - subsolSize.Width) / 2, e.MarginBounds.Bottom - subsolSize.Height);

            e.HasMorePages = false; 
        }
        
    }
}