using ProiectVanzari.Clase;      
using ProiectVanzari.Formulare;  
using ProiectVanzari.Servicii; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;                 
using System.Linq;               
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectVanzari.Formulare 
{
    public partial class FormPrincipal : Form
    {
        private ManagerDate _managerDate;
        private List<Client> _clientiCachePentruFisier;
        private List<Produs> _produseCachePentruFisier;

        private Utilizator _utilizatorInitializat;

        public FormPrincipal(Utilizator utilizatorAutentificat)
        {
            InitializeComponent();
            _managerDate = new ManagerDate();
            _clientiCachePentruFisier = new List<Client>();
            _produseCachePentruFisier = new List<Produs>();
            _utilizatorInitializat = utilizatorAutentificat;

            if (_utilizatorInitializat == null && (SesiuneUtilizator.UtilizatorCurent == null || !SesiuneUtilizator.EsteLogat))
            {
                MessageBox.Show("Eroare critică: Nu s-a putut inițializa sesiunea utilizatorului pentru formularul principal.", "Eroare Inițializare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => Application.Exit();
                return;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated || this.IsDisposed) return;

            ActualizeazaStatusStrip();
            AplicaControlAccesPeBazaDeRol();
            AfiseazaFormularBunVenit();
        }

        private void AfiseazaFormularBunVenit()
        {
           FormBunVenit formExistent = Application.OpenForms.OfType<FormBunVenit>().FirstOrDefault(f => f.MdiParent == this);
            if (formExistent != null)
            {
                formExistent.Activate();
            }
            else
            {
                FormBunVenit formBunVenit = new FormBunVenit();
                formBunVenit.MdiParent = this;

                formBunVenit.FormBorderStyle = FormBorderStyle.None;
                formBunVenit.Dock = DockStyle.Fill;

                formBunVenit.Show();
            }
        }

        private void ActualizeazaStatusStrip()
        {
            if (SesiuneUtilizator.EsteLogat && SesiuneUtilizator.UtilizatorCurent != null)
            {
                toolStripStatusLabelInfo.Text = $"Utilizator: {SesiuneUtilizator.UtilizatorCurent.NumeUtilizator} | Rol: {SesiuneUtilizator.UtilizatorCurent.Rol}";
            }
            else
            {
                toolStripStatusLabelInfo.Text = "Niciun utilizator autentificat.";
            }
        }

        private void AplicaControlAccesPeBazaDeRol()
        {
            bool esteAdmin = SesiuneUtilizator.AreRol(RolUtilizator.Admin);
            bool esteOperator = SesiuneUtilizator.AreRol(RolUtilizator.Operator);
            bool esteLogat = SesiuneUtilizator.EsteLogat;

            clientiToolStripMenuItem.Enabled = (esteAdmin || esteOperator) && esteLogat;
            produseToolStripMenuItem.Enabled = (esteAdmin || esteOperator) && esteLogat;
            tranzactiiToolStripMenuItem.Enabled = (esteAdmin || esteOperator) && esteLogat;

           
            graficVanzariToolStripMenuItem.Enabled = (esteAdmin || esteOperator) && esteLogat;

            dateToolStripMenuItem.Enabled = esteAdmin && esteLogat;
         
            if (utilizatoriToolStripMenuItem != null)
            {
                utilizatoriToolStripMenuItem.Visible = esteAdmin && esteLogat;
            }

            ConfigureazaMeniuLogout(esteLogat);
        }

        private bool MeniuItemExista(ToolStripMenuItem parinte, string numeItemCautat)
        {
            if (parinte == null || !parinte.HasDropDownItems) return false;
            return parinte.DropDownItems.ContainsKey(numeItemCautat);
        }

        private void ConfigureazaMeniuLogout(bool adaugaLogout)
        {
            string numeItemLogout = "logoutToolStripMenuItemProg";
            string numeSeparatorInainteDeLogout = "separatorInainteDeLogoutProg";

            if (adaugaLogout)
            {
                if (!MeniuItemExista(fisierToolStripMenuItem, numeItemLogout))
                {
                    int indexIesire = fisierToolStripMenuItem.DropDownItems.IndexOf(iesireToolStripMenuItem);
                    bool separatorNecesar = true;
                    if (indexIesire > 0 && fisierToolStripMenuItem.DropDownItems[indexIesire - 1] is ToolStripSeparator)
                    {
                        separatorNecesar = false;
                    }
                    else if (indexIesire == -1 && fisierToolStripMenuItem.DropDownItems.Count > 0 &&
                             fisierToolStripMenuItem.DropDownItems[fisierToolStripMenuItem.DropDownItems.Count - 1] is ToolStripSeparator)
                    {
                        separatorNecesar = false;
                    }


                    ToolStripSeparator separator = null;
                    if (separatorNecesar)
                    {
                        separator = new ToolStripSeparator { Name = numeSeparatorInainteDeLogout };
                    }

                    ToolStripMenuItem logoutItem = new ToolStripMenuItem("&Logout")
                    {
                        Name = numeItemLogout,
                        ShortcutKeys = Keys.Control | Keys.L
                    };
                    logoutItem.Click += LogoutToolStripMenuItem_Click;

                    if (indexIesire != -1)
                    {
                        if (separator != null) fisierToolStripMenuItem.DropDownItems.Insert(indexIesire, separator);
                        fisierToolStripMenuItem.DropDownItems.Insert(separator != null ? indexIesire + 1 : indexIesire, logoutItem);
                    }
                    else
                    {
                        if (separator != null) fisierToolStripMenuItem.DropDownItems.Add(separator);
                        fisierToolStripMenuItem.DropDownItems.Add(logoutItem);
                    }
                }
            }
            else 
            {
                if (MeniuItemExista(fisierToolStripMenuItem, numeItemLogout))
                {
                    fisierToolStripMenuItem.DropDownItems.RemoveByKey(numeItemLogout);
                }
                if (MeniuItemExista(fisierToolStripMenuItem, numeSeparatorInainteDeLogout))
                {
                    fisierToolStripMenuItem.DropDownItems.RemoveByKey(numeSeparatorInainteDeLogout);
                }
            }
        }


        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SesiuneUtilizator.Logout();
            SesiuneUtilizator.DoresteRelogare = true;

            foreach (Form frm in this.MdiChildren.ToList())
            {
                frm.Close();
            }
            this.Close();
        }


        private void DeschideFormular<T>() where T : Form, new()
        {
            T formExistent = Application.OpenForms.OfType<T>().FirstOrDefault(f => f.MdiParent == this);
            if (formExistent != null)
            {
                formExistent.Activate();
            }
            else
            {
                T formularNou = new T
                {
                    MdiParent = this
                };
                formularNou.Show();
            }
        }

        private void DeschideFormularGestiuneUtilizatori()
        {
            if (SesiuneUtilizator.UtilizatorCurent == null || !SesiuneUtilizator.AreRol(RolUtilizator.Admin))
            {
                MessageBox.Show("Acces restricționat. Doar administratorii pot accesa această funcționalitate.", "Acces Nepermis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormUtilizatori formExistent = Application.OpenForms.OfType<FormUtilizatori>().FirstOrDefault(f => f.MdiParent == this);
            if (formExistent != null)
            {
                formExistent.Activate();
            }
            else
            {
                FormUtilizatori formNou = new FormUtilizatori(SesiuneUtilizator.UtilizatorCurent);
                formNou.MdiParent = this;
                formNou.Show();
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteți sigur că doriți să părăsiți aplicația?", "Confirmare Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SesiuneUtilizator.DoresteRelogare = false;
                Application.Exit();
            }
        }

        public void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeschideFormular<FormClienti>();
        }

        public void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeschideFormular<FormProduse>();
        }

        public void tranzactiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeschideFormular<FormTranzactii>();
        }

        private void graficVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeschideFormular<FormGraficVanzari>();
        }

        private void utilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeschideFormularGestiuneUtilizatori();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Aplicație Gestiune Vânzări\nVersiunea 1.1.0\nProiect Programarea Aplicațiilor Windows - C#\n\n© {DateTime.Now.Year} Miclescu Răzvan-Auxeniu",
                            "Despre Aplicație",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void salvareDateClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _clientiCachePentruFisier = _managerDate.IncarcaClientiDinDb();
                if (_clientiCachePentruFisier.Count == 0)
                {
                    MessageBox.Show("Nu există clienți de salvat în baza de date.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Fișiere date clienți (*.datc)|*.datc|Toate fișierele (*.*)|*.*",
                    Title = "Salvare date clienți",
                    DefaultExt = "datc",
                    AddExtension = true,
                    FileName = "clienti_backup.datc"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _managerDate.SalveazaClientiInFisier(_clientiCachePentruFisier, sfd.FileName);
                    MessageBox.Show("Datele clienților au fost salvate cu succes!", "Salvare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea datelor clienților: {ex.Message}", "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restaurareDateClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Fișiere date clienți (*.datc)|*.datc|Toate fișierele (*.*)|*.*",
                    Title = "Restaurare date clienți",
                    DefaultExt = "datc",
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var clientiRestaurati = _managerDate.RestaureazaClientiDinFisier(ofd.FileName);
                    if (clientiRestaurati != null && clientiRestaurati.Any())
                    {
                        FormClienti formClienti = Application.OpenForms.OfType<FormClienti>().FirstOrDefault(f => f.MdiParent == this);
                        if (formClienti != null && !formClienti.IsDisposed)
                        {
                            formClienti.IncarcaClientiDinLista(clientiRestaurati);
                            formClienti.Activate();
                        }
                        else
                        {
                            FormClienti newFormClienti = new FormClienti();
                            newFormClienti.MdiParent = this;
                            newFormClienti.Show();
                            newFormClienti.IncarcaClientiDinLista(clientiRestaurati);
                        }
                        MessageBox.Show($"{clientiRestaurati.Count} clienți restaurați din fișier.\nAceștia au fost încărcați în formularul de gestiune.\nPuteți decide acolo dacă îi adăugați în baza de date.", "Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nu s-au găsit date de clienți în fișierul selectat sau fișierul este corupt/gol.", "Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la restaurarea datelor clienților: {ex.Message}", "Eroare Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvareDateProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _produseCachePentruFisier = _managerDate.IncarcaProduseDinDb();
                if (_produseCachePentruFisier.Count == 0)
                {
                    MessageBox.Show("Nu există produse de salvat în baza de date.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Fișiere date produse (*.datp)|*.datp|Toate fișierele (*.*)|*.*",
                    Title = "Salvare date produse",
                    DefaultExt = "datp",
                    AddExtension = true,
                    FileName = "produse_backup.datp"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _managerDate.SalveazaProduseInFisier(_produseCachePentruFisier, sfd.FileName);
                    MessageBox.Show("Datele produselor au fost salvate cu succes!", "Salvare Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea datelor produselor: {ex.Message}", "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restaurareDateProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Fișiere date produse (*.datp)|*.datp|Toate fișierele (*.*)|*.*",
                    Title = "Restaurare date produse",
                    DefaultExt = "datp",
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var produseRestaurate = _managerDate.RestaureazaProduseDinFisier(ofd.FileName);
                    if (produseRestaurate != null && produseRestaurate.Any())
                    {
                        FormProduse formProduse = Application.OpenForms.OfType<FormProduse>().FirstOrDefault(f => f.MdiParent == this);
                        if (formProduse != null && !formProduse.IsDisposed)
                        {
                            formProduse.IncarcaProduseDinLista(produseRestaurate); 
                            formProduse.Activate();
                        }
                        else
                        {
                            FormProduse newFormProduse = new FormProduse();
                            newFormProduse.MdiParent = this;
                            newFormProduse.Show();
                            newFormProduse.IncarcaProduseDinLista(produseRestaurate);
                        }
                        MessageBox.Show($"{produseRestaurate.Count} produse restaurate din fișier.\nAceștia au fost încărcați în formularul de gestiune.\nPuteți decide acolo dacă îi adăugați în baza de date.", "Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nu s-au găsit date de produse în fișierul selectat sau fișierul este corupt/gol.", "Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la restaurarea datelor produselor: {ex.Message}", "Eroare Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}