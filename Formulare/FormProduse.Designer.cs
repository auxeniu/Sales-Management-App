namespace ProiectVanzari.Formulare
{
    partial class FormProduse
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
            this.listViewProduse = new System.Windows.Forms.ListView();
            this.colDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuProduse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnSalveazaDateRestaurateProduseInDB = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdProdus = new System.Windows.Forms.Label();
            this.panelDetalii = new System.Windows.Forms.Panel();
            this.ltbStoc = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.ltbPret = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.ltbDenumire = new ProiectVanzari.ControaleUtilizator.LabeledTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuProduse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelDetalii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProduse
            // 
            this.listViewProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDenumire,
            this.colPret,
            this.colStoc});
            this.listViewProduse.ContextMenuStrip = this.contextMenuProduse;
            this.listViewProduse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduse.FullRowSelect = true;
            this.listViewProduse.GridLines = true;
            this.listViewProduse.HideSelection = false;
            this.listViewProduse.Location = new System.Drawing.Point(0, 0);
            this.listViewProduse.MultiSelect = false;
            this.listViewProduse.Name = "listViewProduse";
            this.listViewProduse.Size = new System.Drawing.Size(446, 346);
            this.listViewProduse.TabIndex = 0;
            this.listViewProduse.UseCompatibleStateImageBehavior = false;
            this.listViewProduse.View = System.Windows.Forms.View.Details;
            this.listViewProduse.SelectedIndexChanged += new System.EventHandler(this.listViewProduse_SelectedIndexChanged);
            // 
            // colDenumire
            // 
            this.colDenumire.Text = "Denumire Produs";
            this.colDenumire.Width = 220;
            // 
            // colPret
            // 
            this.colPret.Text = "Preț Unitar";
            this.colPret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPret.Width = 100;
            // 
            // colStoc
            // 
            this.colStoc.Text = "Stoc Disponibil";
            this.colStoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colStoc.Width = 100;
            // 
            // contextMenuProduse
            // 
            this.contextMenuProduse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaProdusToolStripMenuItem,
            this.stergeProdusToolStripMenuItem});
            this.contextMenuProduse.Name = "contextMenuProduse";
            this.contextMenuProduse.Size = new System.Drawing.Size(202, 48);
            this.contextMenuProduse.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuProduse_Opening);
            // 
            // modificaProdusToolStripMenuItem
            // 
            this.modificaProdusToolStripMenuItem.Name = "modificaProdusToolStripMenuItem";
            this.modificaProdusToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.modificaProdusToolStripMenuItem.Text = "Modifică produs selectat";
            this.modificaProdusToolStripMenuItem.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // stergeProdusToolStripMenuItem
            // 
            this.stergeProdusToolStripMenuItem.Name = "stergeProdusToolStripMenuItem";
            this.stergeProdusToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.stergeProdusToolStripMenuItem.Text = "Șterge produs selectat";
            this.stergeProdusToolStripMenuItem.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdauga.Location = new System.Drawing.Point(15, 155);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 4;
            this.btnAdauga.Text = "&Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(98, 155);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 5;
            this.btnModifica.Text = "&Modifică";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSterge.Enabled = false;
            this.btnSterge.Location = new System.Drawing.Point(181, 155);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Ște&rge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalveaza.Enabled = false;
            this.btnSalveaza.Location = new System.Drawing.Point(15, 185);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(158, 23);
            this.btnSalveaza.TabIndex = 7;
            this.btnSalveaza.Text = "&Salvează (Ctrl+S)";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuleaza.Enabled = false;
            this.btnAnuleaza.Location = new System.Drawing.Point(181, 185);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 8;
            this.btnAnuleaza.Text = "A&nulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnSalveazaDateRestaurateProduseInDB
            // 
            this.btnSalveazaDateRestaurateProduseInDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalveazaDateRestaurateProduseInDB.Location = new System.Drawing.Point(15, 215);
            this.btnSalveazaDateRestaurateProduseInDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.btnSalveazaDateRestaurateProduseInDB.Name = "btnSalveazaDateRestaurateProduseInDB";
            this.btnSalveazaDateRestaurateProduseInDB.Size = new System.Drawing.Size(241, 28);
            this.btnSalveazaDateRestaurateProduseInDB.TabIndex = 9;
            this.btnSalveazaDateRestaurateProduseInDB.Text = "Salvare Produse Restaurate în DB";
            this.btnSalveazaDateRestaurateProduseInDB.UseVisualStyleBackColor = true;
            this.btnSalveazaDateRestaurateProduseInDB.Visible = false;
            this.btnSalveazaDateRestaurateProduseInDB.Enabled = false;
            this.btnSalveazaDateRestaurateProduseInDB.Click += new System.EventHandler(this.btnSalveazaDateRestaurateProduseInDB_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblIdProdus
            // 
            this.lblIdProdus.AutoSize = true;
            this.lblIdProdus.Location = new System.Drawing.Point(12, 9);
            this.lblIdProdus.Name = "lblIdProdus";
            this.lblIdProdus.Size = new System.Drawing.Size(13, 13);
            this.lblIdProdus.TabIndex = 10;
            this.lblIdProdus.Text = "0";
            this.lblIdProdus.Visible = false;
            // 
            // panelDetalii
            // 
            this.panelDetalii.Controls.Add(this.ltbStoc);
            this.panelDetalii.Controls.Add(this.ltbPret);
            this.panelDetalii.Controls.Add(this.ltbDenumire);
            this.panelDetalii.Controls.Add(this.lblIdProdus);
            this.panelDetalii.Controls.Add(this.btnAdauga);
            this.panelDetalii.Controls.Add(this.btnAnuleaza);
            this.panelDetalii.Controls.Add(this.btnModifica);
            this.panelDetalii.Controls.Add(this.btnSalveaza);
            this.panelDetalii.Controls.Add(this.btnSterge);
            this.panelDetalii.Controls.Add(this.btnSalveazaDateRestaurateProduseInDB);
            this.panelDetalii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalii.Location = new System.Drawing.Point(0, 0);
            this.panelDetalii.MinimumSize = new System.Drawing.Size(270, 0);
            this.panelDetalii.Name = "panelDetalii";
            this.panelDetalii.Padding = new System.Windows.Forms.Padding(10);
            this.panelDetalii.Size = new System.Drawing.Size(280, 346);
            this.panelDetalii.TabIndex = 11;
            // 
            // ltbStoc
            // 
            this.ltbStoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbStoc.LabelText = "&Stoc:";
            this.ltbStoc.Location = new System.Drawing.Point(15, 110);
            this.ltbStoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbStoc.Multiline = false;
            this.ltbStoc.Name = "ltbStoc";
            this.ltbStoc.ReadOnly = true;
            this.ltbStoc.Size = new System.Drawing.Size(250, 28);
            this.ltbStoc.TabIndex = 3;
            // 
            // ltbPret
            // 
            this.ltbPret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbPret.LabelText = "&Preț:";
            this.ltbPret.Location = new System.Drawing.Point(15, 60);
            this.ltbPret.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbPret.Multiline = false;
            this.ltbPret.Name = "ltbPret";
            this.ltbPret.ReadOnly = true;
            this.ltbPret.Size = new System.Drawing.Size(250, 28);
            this.ltbPret.TabIndex = 2;
            // 
            // ltbDenumire
            // 
            this.ltbDenumire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbDenumire.LabelText = "&Denumire:";
            this.ltbDenumire.Location = new System.Drawing.Point(15, 10);
            this.ltbDenumire.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ltbDenumire.Multiline = false;
            this.ltbDenumire.Name = "ltbDenumire";
            this.ltbDenumire.ReadOnly = true;
            this.ltbDenumire.Size = new System.Drawing.Size(250, 28);
            this.ltbDenumire.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewProduse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelDetalii);
            this.splitContainer1.Panel2MinSize = 270;
            this.splitContainer1.Size = new System.Drawing.Size(764, 346);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 12;
            // 
            // FormProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 366);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FormProduse";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Gestiune Produse";
            this.Load += new System.EventHandler(this.FormProduse_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProduse_KeyDown);
            this.contextMenuProduse.ResumeLayout(false);
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

        private System.Windows.Forms.ListView listViewProduse;
        private System.Windows.Forms.ColumnHeader colDenumire;
        private System.Windows.Forms.ColumnHeader colPret;
        private System.Windows.Forms.ColumnHeader colStoc;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnSalveazaDateRestaurateProduseInDB;
        private ControaleUtilizator.LabeledTextBox ltbDenumire;
        private ControaleUtilizator.LabeledTextBox ltbPret;
        private ControaleUtilizator.LabeledTextBox ltbStoc;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuProduse;
        private System.Windows.Forms.ToolStripMenuItem modificaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeProdusToolStripMenuItem;
        private System.Windows.Forms.Label lblIdProdus;
        private System.Windows.Forms.Panel panelDetalii;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}