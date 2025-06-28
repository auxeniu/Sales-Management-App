namespace ProiectVanzari.Formulare
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareDateClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvareDateProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareDateProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorAdmin = new System.Windows.Forms.ToolStripSeparator();
            this.utilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripPrincipal.SuspendLayout();
            this.statusStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.gestiuneToolStripMenuItem,
            this.rapoarteToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1200, 36);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem,
            this.toolStripSeparator2,
            this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.fisierToolStripMenuItem.Text = "&Fișier";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareDateClientiToolStripMenuItem,
            this.restaurareDateClientiToolStripMenuItem,
            this.toolStripSeparator1,
            this.salvareDateProduseToolStripMenuItem,
            this.restaurareDateProduseToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.dateToolStripMenuItem.Text = "&Date";
            // 
            // salvareDateClientiToolStripMenuItem
            // 
            this.salvareDateClientiToolStripMenuItem.Name = "salvareDateClientiToolStripMenuItem";
            this.salvareDateClientiToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.salvareDateClientiToolStripMenuItem.Text = "&Salvare Date Clienți...";
            this.salvareDateClientiToolStripMenuItem.Click += new System.EventHandler(this.salvareDateClientiToolStripMenuItem_Click);
            // 
            // restaurareDateClientiToolStripMenuItem
            // 
            this.restaurareDateClientiToolStripMenuItem.Name = "restaurareDateClientiToolStripMenuItem";
            this.restaurareDateClientiToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.restaurareDateClientiToolStripMenuItem.Text = "&Restaurare Date Clienți...";
            this.restaurareDateClientiToolStripMenuItem.Click += new System.EventHandler(this.restaurareDateClientiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(317, 6);
            // 
            // salvareDateProduseToolStripMenuItem
            // 
            this.salvareDateProduseToolStripMenuItem.Name = "salvareDateProduseToolStripMenuItem";
            this.salvareDateProduseToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.salvareDateProduseToolStripMenuItem.Text = "S&alvare Date Produse...";
            this.salvareDateProduseToolStripMenuItem.Click += new System.EventHandler(this.salvareDateProduseToolStripMenuItem_Click);
            // 
            // restaurareDateProduseToolStripMenuItem
            // 
            this.restaurareDateProduseToolStripMenuItem.Name = "restaurareDateProduseToolStripMenuItem";
            this.restaurareDateProduseToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.restaurareDateProduseToolStripMenuItem.Text = "R&estaurare Date Produse...";
            this.restaurareDateProduseToolStripMenuItem.Click += new System.EventHandler(this.restaurareDateProduseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.iesireToolStripMenuItem.Text = "&Ieșire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // gestiuneToolStripMenuItem
            // 
            this.gestiuneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.tranzactiiToolStripMenuItem,
            this.toolStripSeparatorAdmin,
            this.utilizatoriToolStripMenuItem});
            this.gestiuneToolStripMenuItem.Name = "gestiuneToolStripMenuItem";
            this.gestiuneToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.gestiuneToolStripMenuItem.Text = "&Gestiune";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.clientiToolStripMenuItem.Text = "&Clienți";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.produseToolStripMenuItem.Text = "&Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // tranzactiiToolStripMenuItem
            // 
            this.tranzactiiToolStripMenuItem.Name = "tranzactiiToolStripMenuItem";
            this.tranzactiiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tranzactiiToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.tranzactiiToolStripMenuItem.Text = "&Tranzacții";
            this.tranzactiiToolStripMenuItem.Click += new System.EventHandler(this.tranzactiiToolStripMenuItem_Click);
            // 
            // toolStripSeparatorAdmin
            // 
            this.toolStripSeparatorAdmin.Name = "toolStripSeparatorAdmin";
            this.toolStripSeparatorAdmin.Size = new System.Drawing.Size(248, 6);
            this.toolStripSeparatorAdmin.Visible = false;
            // 
            // utilizatoriToolStripMenuItem
            // 
            this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            this.utilizatoriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.utilizatoriToolStripMenuItem.Text = "&Utilizatori";
            this.utilizatoriToolStripMenuItem.Visible = false;
            this.utilizatoriToolStripMenuItem.Click += new System.EventHandler(this.utilizatoriToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficVanzariToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.rapoarteToolStripMenuItem.Text = "&Rapoarte";
            // 
            // graficVanzariToolStripMenuItem
            // 
            this.graficVanzariToolStripMenuItem.Name = "graficVanzariToolStripMenuItem";
            this.graficVanzariToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.graficVanzariToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.graficVanzariToolStripMenuItem.Text = "&Grafice Vânzări";
            this.graficVanzariToolStripMenuItem.Click += new System.EventHandler(this.graficVanzariToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem});
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.ajutorToolStripMenuItem.Text = "A&jutor";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.despreToolStripMenuItem.Text = "&Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 660);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStripPrincipal.Size = new System.Drawing.Size(1200, 32);
            this.statusStripPrincipal.TabIndex = 2;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(52, 25);
            this.toolStripStatusLabelInfo.Text = "Gata.";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Gestiune Vânzări - Proiect PAW";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficVanzariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareDateClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salvareDateProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareDateProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem; // Declarația pentru noul item
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorAdmin; // Declarația pentru separatorul de admin
    }
}