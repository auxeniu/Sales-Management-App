namespace ProiectVanzari.Formulare
{
    partial class FormClienti
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
            this.components = new System.ComponentModel.Container();
            this.listViewClienti = new System.Windows.Forms.ListView();
            this.colNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuClienti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnSalveazaDateRestaurateInDB = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdClient = new System.Windows.Forms.Label();
            this.panelDetalii = new System.Windows.Forms.Panel();
            this.ltbEmail = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.ltbTelefon = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.ltbAdresa = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.ltbPrenume = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.ltbNume = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelDetalii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClienti
            // 
            this.listViewClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNume,
            this.colPrenume,
            this.colTelefon,
            this.colEmail});
            this.listViewClienti.ContextMenuStrip = this.contextMenuClienti;
            this.listViewClienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClienti.FullRowSelect = true;
            this.listViewClienti.GridLines = true;
            this.listViewClienti.HideSelection = false;
            this.listViewClienti.Location = new System.Drawing.Point(0, 0);
            this.listViewClienti.MultiSelect = false;
            this.listViewClienti.Name = "listViewClienti";
            this.listViewClienti.Size = new System.Drawing.Size(446, 396);
            this.listViewClienti.TabIndex = 0;
            this.listViewClienti.UseCompatibleStateImageBehavior = false;
            this.listViewClienti.View = System.Windows.Forms.View.Details;
            this.listViewClienti.SelectedIndexChanged += new System.EventHandler(this.listViewClienti_SelectedIndexChanged);
            // 
            // colNume
            // 
            this.colNume.Text = "Nume";
            this.colNume.Width = 120;
            // 
            // colPrenume
            // 
            this.colPrenume.Text = "Prenume";
            this.colPrenume.Width = 120;
            // 
            // colTelefon
            // 
            this.colTelefon.Text = "Telefon";
            this.colTelefon.Width = 100;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 150;
            // 
            // contextMenuClienti
            // 
            this.contextMenuClienti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaClientToolStripMenuItem,
            this.stergeClientToolStripMenuItem});
            this.contextMenuClienti.Name = "contextMenuClienti";
            this.contextMenuClienti.Size = new System.Drawing.Size(199, 48);
            this.contextMenuClienti.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuClienti_Opening);
            // 
            // modificaClientToolStripMenuItem
            // 
            this.modificaClientToolStripMenuItem.Name = "modificaClientToolStripMenuItem";
            this.modificaClientToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.modificaClientToolStripMenuItem.Text = "Modifică client selectat";
            this.modificaClientToolStripMenuItem.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // stergeClientToolStripMenuItem
            // 
            this.stergeClientToolStripMenuItem.Name = "stergeClientToolStripMenuItem";
            this.stergeClientToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.stergeClientToolStripMenuItem.Text = "Șterge client selectat";
            this.stergeClientToolStripMenuItem.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdauga.Location = new System.Drawing.Point(15, 230);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "&Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(98, 230);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 7;
            this.btnModifica.Text = "&Modifică";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSterge.Enabled = false;
            this.btnSterge.Location = new System.Drawing.Point(181, 230);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 8;
            this.btnSterge.Text = "Ște&rge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalveaza.Enabled = false;
            this.btnSalveaza.Location = new System.Drawing.Point(15, 260);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(158, 23);
            this.btnSalveaza.TabIndex = 9;
            this.btnSalveaza.Text = "&Salvează (Ctrl+S)";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuleaza.Enabled = false;
            this.btnAnuleaza.Location = new System.Drawing.Point(181, 260);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 10;
            this.btnAnuleaza.Text = "A&nulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // 
            // btnSalveazaDateRestaurateInDB
            // 
            this.btnSalveazaDateRestaurateInDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalveazaDateRestaurateInDB.Location = new System.Drawing.Point(15, 290);
            this.btnSalveazaDateRestaurateInDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.btnSalveazaDateRestaurateInDB.Name = "btnSalveazaDateRestaurateInDB";
            this.btnSalveazaDateRestaurateInDB.Size = new System.Drawing.Size(241, 28);
            this.btnSalveazaDateRestaurateInDB.TabIndex = 11;
            this.btnSalveazaDateRestaurateInDB.Text = "Salvare Date Restaurate în DB";
            this.btnSalveazaDateRestaurateInDB.UseVisualStyleBackColor = true;
            this.btnSalveazaDateRestaurateInDB.Visible = false;
            this.btnSalveazaDateRestaurateInDB.Enabled = false;
            this.btnSalveazaDateRestaurateInDB.Click += new System.EventHandler(this.btnSalveazaDateRestaurateInDB_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Location = new System.Drawing.Point(12, 9);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(13, 13);
            this.lblIdClient.TabIndex = 12;
            this.lblIdClient.Text = "0";
            this.lblIdClient.Visible = false;
            // 
            // panelDetalii
            // 
            this.panelDetalii.Controls.Add(this.ltbEmail);
            this.panelDetalii.Controls.Add(this.ltbTelefon);
            this.panelDetalii.Controls.Add(this.ltbAdresa);
            this.panelDetalii.Controls.Add(this.ltbPrenume);
            this.panelDetalii.Controls.Add(this.ltbNume);
            this.panelDetalii.Controls.Add(this.lblIdClient);
            this.panelDetalii.Controls.Add(this.btnAdauga);
            this.panelDetalii.Controls.Add(this.btnAnuleaza);
            this.panelDetalii.Controls.Add(this.btnModifica);
            this.panelDetalii.Controls.Add(this.btnSalveaza);
            this.panelDetalii.Controls.Add(this.btnSterge);
            this.panelDetalii.Controls.Add(this.btnSalveazaDateRestaurateInDB);
            this.panelDetalii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalii.Location = new System.Drawing.Point(0, 0);
            this.panelDetalii.MinimumSize = new System.Drawing.Size(270, 0);
            this.panelDetalii.Name = "panelDetalii";
            this.panelDetalii.Padding = new System.Windows.Forms.Padding(10);
            this.panelDetalii.Size = new System.Drawing.Size(280, 396);
            this.panelDetalii.TabIndex = 13;
            // 
            // ltbEmail
            // 
            this.ltbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbEmail.LabelText = "&Email:";
            this.ltbEmail.Location = new System.Drawing.Point(15, 185);
            this.ltbEmail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbEmail.Multiline = false;
            this.ltbEmail.Name = "ltbEmail";
            this.ltbEmail.ReadOnly = true;
            this.ltbEmail.Size = new System.Drawing.Size(250, 28);
            this.ltbEmail.TabIndex = 5;
            // 
            // ltbTelefon
            // 
            this.ltbTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbTelefon.LabelText = "Tele&fon:";
            this.ltbTelefon.Location = new System.Drawing.Point(15, 150);
            this.ltbTelefon.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbTelefon.Multiline = false;
            this.ltbTelefon.Name = "ltbTelefon";
            this.ltbTelefon.ReadOnly = true;
            this.ltbTelefon.Size = new System.Drawing.Size(250, 28);
            this.ltbTelefon.TabIndex = 4;
            // 
            // ltbAdresa
            // 
            this.ltbAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbAdresa.LabelText = "&Adresă:";
            this.ltbAdresa.Location = new System.Drawing.Point(15, 80);
            this.ltbAdresa.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbAdresa.Multiline = true;
            this.ltbAdresa.Name = "ltbAdresa";
            this.ltbAdresa.ReadOnly = true;
            this.ltbAdresa.Size = new System.Drawing.Size(250, 60);
            this.ltbAdresa.TabIndex = 3;
            // 
            // ltbPrenume
            // 
            this.ltbPrenume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbPrenume.LabelText = "&Prenume:";
            this.ltbPrenume.Location = new System.Drawing.Point(15, 45);
            this.ltbPrenume.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbPrenume.Multiline = false;
            this.ltbPrenume.Name = "ltbPrenume";
            this.ltbPrenume.ReadOnly = true;
            this.ltbPrenume.Size = new System.Drawing.Size(250, 28);
            this.ltbPrenume.TabIndex = 2;
            // 
            // ltbNume
            // 
            this.ltbNume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbNume.LabelText = "&Nume:";
            this.ltbNume.Location = new System.Drawing.Point(15, 10);
            this.ltbNume.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbNume.Multiline = false;
            this.ltbNume.Name = "ltbNume";
            this.ltbNume.ReadOnly = true;
            this.ltbNume.Size = new System.Drawing.Size(250, 28);
            this.ltbNume.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewClienti);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelDetalii);
            this.splitContainer1.Panel2MinSize = 270;
            this.splitContainer1.Size = new System.Drawing.Size(764, 396);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 14;
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 416);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FormClienti";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Gestiune Clienți";
            this.Load += new System.EventHandler(this.FormClienti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClienti_KeyDown);
            this.contextMenuClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelDetalii.ResumeLayout(false);
            this.panelDetalii.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClienti;
        private System.Windows.Forms.ColumnHeader colNume;
        private System.Windows.Forms.ColumnHeader colPrenume;
        private System.Windows.Forms.ColumnHeader colTelefon;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private ControaleUtilizator.LabeledTextBox ltbNume;
        private ControaleUtilizator.LabeledTextBox ltbPrenume;
        private ControaleUtilizator.LabeledTextBox ltbAdresa;
        private ControaleUtilizator.LabeledTextBox ltbTelefon;
        private ControaleUtilizator.LabeledTextBox ltbEmail;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuClienti;
        private System.Windows.Forms.ToolStripMenuItem modificaClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeClientToolStripMenuItem;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.Panel panelDetalii;
        private System.Windows.Forms.Button btnSalveazaDateRestaurateInDB;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}