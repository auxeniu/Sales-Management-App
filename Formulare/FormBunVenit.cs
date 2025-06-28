using ProiectVanzari.Servicii;
using System;
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;
using ProiectVanzari.Clase;
using ProiectVanzari.Formulare;

namespace ProiectVanzari.Formulare
{
    public partial class FormBunVenit : Form
    {
        private ManagerDate _managerDate;

        public FormBunVenit()
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            this.Dock = DockStyle.Fill;
        }

        private void FormBunVenit_Load(object sender, EventArgs e)
        {
            if (SesiuneUtilizator.EsteLogat && SesiuneUtilizator.UtilizatorCurent != null)
            {
                lblUtilizatorLogat.Text = $"Autentificat ca: {SesiuneUtilizator.UtilizatorCurent.NumeUtilizator} ({SesiuneUtilizator.UtilizatorCurent.Rol})";
            }
            else
            {
                lblUtilizatorLogat.Text = "Niciun utilizator autentificat.";
            }

            timerDataOra_Tick(null, null);
            timerDataOra.Start();
            this.btnRefreshSumar.Visible = true;

            IncarcaDateSumar(); 
            AplicaStiluriButoane();
        }

        private void timerDataOra_Tick(object sender, EventArgs e)
        {
            lblDataOra.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy, HH:mm:ss");
        }

        private void IncarcaDateSumar()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor; 
                btnRefreshSumar.Enabled = false;
                var clienti = _managerDate.IncarcaClientiDinDb();
                lblInfoClientiTotal.Text = $"Total Clienți: {clienti.Count}";

                var produse = _managerDate.IncarcaProduseDinDb();
                lblInfoProduseActive.Text = $"Produse în stoc: {produse.Count(p => p.Stoc > 0)} / {produse.Count}";

                var tranzactii = _managerDate.IncarcaTranzactiiDinDb();
                lblInfoTranzactiiAzi.Text = $"Tranzacții Azi: {tranzactii.Count(t => t.DataTranzactie.Date == DateTime.Today)}";
                lblDataOra.Text += " (Actualizat)";
            }
            catch (Exception ex)
            {
                lblInfoClientiTotal.Text = "Total Clienți: N/A";
                lblInfoProduseActive.Text = "Produse Active: N/A";
                lblInfoTranzactiiAzi.Text = "Tranzacții Azi: N/A";
                Console.WriteLine($"Eroare la încărcarea datelor de sumar: {ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnRefreshSumar.Enabled = true;
            }
        }

        private void AplicaStiluriButoane()
        {
            foreach (Control ctrl in panelActiuniRapide.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += (s, ev) => { btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, btn.BackColor); };
                    btn.MouseLeave += (s, ev) => { btn.FlatAppearance.MouseOverBackColor = btn.BackColor; };
                }
            }
        }


        private void btnActiuneTranzactieNoua_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is FormPrincipal formPrincipal)
            {
                formPrincipal.tranzactiiToolStripMenuItem_Click(sender, e);
            }
        }

        private void btnRefreshSumar_Click(object sender, EventArgs e)
        {
            IncarcaDateSumar();
        }

        private void btnActiuneVeziClienti_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is FormPrincipal formPrincipal)
            {
                formPrincipal.clientiToolStripMenuItem_Click(sender, e);
            }
        }

        private void btnActiuneVeziProduse_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is FormPrincipal formPrincipal)
            {
                formPrincipal.produseToolStripMenuItem_Click(sender, e);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timerDataOra.Stop();
            base.OnFormClosing(e);
        }
    }
}