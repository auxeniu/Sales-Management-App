namespace ProiectVanzari.Formulare
{
    partial class FormTranzactii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTranzactii));
            this.groupBoxTranzactieCurenta = new System.Windows.Forms.GroupBox();
            this.btnAnuleazaTranzactieNoua = new System.Windows.Forms.Button();
            this.btnSalveazaTranzactie = new System.Windows.Forms.Button();
            this.txtTotalGeneralTranzactie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewProduseTranzactie = new System.Windows.Forms.ListView();
            this.colProdDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdCantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdPretUnitar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdValoareTotala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAdaugareProdus = new System.Windows.Forms.GroupBox();
            this.btnStergeProdusDinTranzactie = new System.Windows.Forms.Button();
            this.btnAdaugaProdusInTranzactie = new System.Windows.Forms.Button();
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProduseDisponibile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataTranzactie = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTranzactiiInregistrate = new System.Windows.Forms.GroupBox();
            this.btnTiparesteTranzactie = new System.Windows.Forms.Button();
            this.btnStergeTranzactieSelectata = new System.Windows.Forms.Button();
            this.listViewTranzactiiExistente = new System.Windows.Forms.ListView();
            this.colTrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxProduseSursaDragDrop = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocumentTranzactie = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogTranzactie = new System.Windows.Forms.PrintPreviewDialog();
            this.splitContainerPrincipal = new System.Windows.Forms.SplitContainer();
            this.panelDreaptaSus = new System.Windows.Forms.Panel();
            this.groupBoxTranzactieCurenta.SuspendLayout();
            this.groupBoxAdaugareProdus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            this.groupBoxTranzactiiInregistrate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).BeginInit();
            this.splitContainerPrincipal.Panel1.SuspendLayout();
            this.splitContainerPrincipal.Panel2.SuspendLayout();
            this.splitContainerPrincipal.SuspendLayout();
            this.panelDreaptaSus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTranzactieCurenta
            // 
            this.groupBoxTranzactieCurenta.Controls.Add(this.btnAnuleazaTranzactieNoua);
            this.groupBoxTranzactieCurenta.Controls.Add(this.btnSalveazaTranzactie);
            this.groupBoxTranzactieCurenta.Controls.Add(this.txtTotalGeneralTranzactie);
            this.groupBoxTranzactieCurenta.Controls.Add(this.label5);
            this.groupBoxTranzactieCurenta.Controls.Add(this.listViewProduseTranzactie);
            this.groupBoxTranzactieCurenta.Controls.Add(this.groupBoxAdaugareProdus);
            this.groupBoxTranzactieCurenta.Controls.Add(this.dtpDataTranzactie);
            this.groupBoxTranzactieCurenta.Controls.Add(this.label2);
            this.groupBoxTranzactieCurenta.Controls.Add(this.cmbClienti);
            this.groupBoxTranzactieCurenta.Controls.Add(this.label1);
            this.groupBoxTranzactieCurenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTranzactieCurenta.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTranzactieCurenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTranzactieCurenta.Name = "groupBoxTranzactieCurenta";
            this.groupBoxTranzactieCurenta.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxTranzactieCurenta.Size = new System.Drawing.Size(931, 596);
            this.groupBoxTranzactieCurenta.TabIndex = 0;
            this.groupBoxTranzactieCurenta.TabStop = false;
            this.groupBoxTranzactieCurenta.Text = "Detalii Tranzacție Nouă / Editare";
            // 
            // btnAnuleazaTranzactieNoua
            // 
            this.btnAnuleazaTranzactieNoua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuleazaTranzactieNoua.Location = new System.Drawing.Point(715, 556);
            this.btnAnuleazaTranzactieNoua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuleazaTranzactieNoua.Name = "btnAnuleazaTranzactieNoua";
            this.btnAnuleazaTranzactieNoua.Size = new System.Drawing.Size(195, 35);
            this.btnAnuleazaTranzactieNoua.TabIndex = 9;
            this.btnAnuleazaTranzactieNoua.Text = "A&nulează Tranzacția";
            this.btnAnuleazaTranzactieNoua.UseVisualStyleBackColor = true;
            this.btnAnuleazaTranzactieNoua.Click += new System.EventHandler(this.btnAnuleazaTranzactieNoua_Click);
            // 
            // btnSalveazaTranzactie
            // 
            this.btnSalveazaTranzactie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalveazaTranzactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaTranzactie.Location = new System.Drawing.Point(553, 556);
            this.btnSalveazaTranzactie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalveazaTranzactie.Name = "btnSalveazaTranzactie";
            this.btnSalveazaTranzactie.Size = new System.Drawing.Size(156, 35);
            this.btnSalveazaTranzactie.TabIndex = 8;
            this.btnSalveazaTranzactie.Text = "&Salvează Tranzacția";
            this.btnSalveazaTranzactie.UseVisualStyleBackColor = true;
            this.btnSalveazaTranzactie.Click += new System.EventHandler(this.btnSalveazaTranzactie_Click);
            // 
            // txtTotalGeneralTranzactie
            // 
            this.txtTotalGeneralTranzactie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalGeneralTranzactie.Location = new System.Drawing.Point(206, 519);
            this.txtTotalGeneralTranzactie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalGeneralTranzactie.Name = "txtTotalGeneralTranzactie";
            this.txtTotalGeneralTranzactie.ReadOnly = true;
            this.txtTotalGeneralTranzactie.Size = new System.Drawing.Size(280, 26);
            this.txtTotalGeneralTranzactie.TabIndex = 7;
            this.txtTotalGeneralTranzactie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 519);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total General Tranzacție:";
            // 
            // listViewProduseTranzactie
            // 
            this.listViewProduseTranzactie.AllowDrop = true;
            this.listViewProduseTranzactie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProduseTranzactie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProdDenumire,
            this.colProdCantitate,
            this.colProdPretUnitar,
            this.colProdValoareTotala});
            this.listViewProduseTranzactie.FullRowSelect = true;
            this.listViewProduseTranzactie.GridLines = true;
            this.listViewProduseTranzactie.HideSelection = false;
            this.listViewProduseTranzactie.Location = new System.Drawing.Point(15, 285);
            this.listViewProduseTranzactie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewProduseTranzactie.MultiSelect = false;
            this.listViewProduseTranzactie.Name = "listViewProduseTranzactie";
            this.listViewProduseTranzactie.Size = new System.Drawing.Size(895, 222);
            this.listViewProduseTranzactie.TabIndex = 5;
            this.listViewProduseTranzactie.UseCompatibleStateImageBehavior = false;
            this.listViewProduseTranzactie.View = System.Windows.Forms.View.Details;
            this.listViewProduseTranzactie.SelectedIndexChanged += new System.EventHandler(this.listViewProduseTranzactie_SelectedIndexChanged);
            this.listViewProduseTranzactie.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewProduseTranzactie_DragDrop);
            this.listViewProduseTranzactie.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewProduseTranzactie_DragEnter);
            // 
            // colProdDenumire
            // 
            this.colProdDenumire.Text = "Denumire Produs";
            this.colProdDenumire.Width = 220;
            // 
            // colProdCantitate
            // 
            this.colProdCantitate.Text = "Cantitate";
            this.colProdCantitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colProdCantitate.Width = 70;
            // 
            // colProdPretUnitar
            // 
            this.colProdPretUnitar.Text = "Preț Unitar";
            this.colProdPretUnitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colProdPretUnitar.Width = 100;
            // 
            // colProdValoareTotala
            // 
            this.colProdValoareTotala.Text = "Valoare Totală";
            this.colProdValoareTotala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colProdValoareTotala.Width = 120;
            // 
            // groupBoxAdaugareProdus
            // 
            this.groupBoxAdaugareProdus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdaugareProdus.Controls.Add(this.btnStergeProdusDinTranzactie);
            this.groupBoxAdaugareProdus.Controls.Add(this.btnAdaugaProdusInTranzactie);
            this.groupBoxAdaugareProdus.Controls.Add(this.nudCantitate);
            this.groupBoxAdaugareProdus.Controls.Add(this.label4);
            this.groupBoxAdaugareProdus.Controls.Add(this.cmbProduseDisponibile);
            this.groupBoxAdaugareProdus.Controls.Add(this.label3);
            this.groupBoxAdaugareProdus.Location = new System.Drawing.Point(15, 92);
            this.groupBoxAdaugareProdus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAdaugareProdus.Name = "groupBoxAdaugareProdus";
            this.groupBoxAdaugareProdus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAdaugareProdus.Size = new System.Drawing.Size(897, 177);
            this.groupBoxAdaugareProdus.TabIndex = 4;
            this.groupBoxAdaugareProdus.TabStop = false;
            this.groupBoxAdaugareProdus.Text = "Adăugare Produs în Tranzacție";
            // 
            // btnStergeProdusDinTranzactie
            // 
            this.btnStergeProdusDinTranzactie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStergeProdusDinTranzactie.Enabled = false;
            this.btnStergeProdusDinTranzactie.Location = new System.Drawing.Point(623, 115);
            this.btnStergeProdusDinTranzactie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStergeProdusDinTranzactie.Name = "btnStergeProdusDinTranzactie";
            this.btnStergeProdusDinTranzactie.Size = new System.Drawing.Size(255, 35);
            this.btnStergeProdusDinTranzactie.TabIndex = 5;
            this.btnStergeProdusDinTranzactie.Text = "Șterge Produs Selectat";
            this.btnStergeProdusDinTranzactie.UseVisualStyleBackColor = true;
            this.btnStergeProdusDinTranzactie.Click += new System.EventHandler(this.btnStergeProdusDinTranzactie_Click);
            // 
            // btnAdaugaProdusInTranzactie
            // 
            this.btnAdaugaProdusInTranzactie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdaugaProdusInTranzactie.Location = new System.Drawing.Point(353, 115);
            this.btnAdaugaProdusInTranzactie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdaugaProdusInTranzactie.Name = "btnAdaugaProdusInTranzactie";
            this.btnAdaugaProdusInTranzactie.Size = new System.Drawing.Size(255, 35);
            this.btnAdaugaProdusInTranzactie.TabIndex = 4;
            this.btnAdaugaProdusInTranzactie.Text = "Adaugă Produs (&Enter)";
            this.btnAdaugaProdusInTranzactie.UseVisualStyleBackColor = true;
            this.btnAdaugaProdusInTranzactie.Click += new System.EventHandler(this.btnAdaugaProdusInTranzactie_Click);
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(105, 84);
            this.nudCantitate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantitate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(135, 26);
            this.nudCantitate.TabIndex = 3;
            this.nudCantitate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantitate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudCantitate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Cantitate:";
            // 
            // cmbProduseDisponibile
            // 
            this.cmbProduseDisponibile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProduseDisponibile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduseDisponibile.FormattingEnabled = true;
            this.cmbProduseDisponibile.Location = new System.Drawing.Point(105, 46);
            this.cmbProduseDisponibile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProduseDisponibile.Name = "cmbProduseDisponibile";
            this.cmbProduseDisponibile.Size = new System.Drawing.Size(771, 28);
            this.cmbProduseDisponibile.TabIndex = 1;
            this.cmbProduseDisponibile.SelectedIndexChanged += new System.EventHandler(this.cmbProduseDisponibile_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pr&odus:";
            // 
            // dtpDataTranzactie
            // 
            this.dtpDataTranzactie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataTranzactie.Location = new System.Drawing.Point(657, 38);
            this.dtpDataTranzactie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataTranzactie.Name = "dtpDataTranzactie";
            this.dtpDataTranzactie.Size = new System.Drawing.Size(270, 26);
            this.dtpDataTranzactie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "D&ată Tranzacție:";
            // 
            // cmbClienti
            // 
            this.cmbClienti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClienti.FormattingEnabled = true;
            this.cmbClienti.Location = new System.Drawing.Point(105, 38);
            this.cmbClienti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClienti.Name = "cmbClienti";
            this.cmbClienti.Size = new System.Drawing.Size(409, 28);
            this.cmbClienti.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Client:";
            // 
            // groupBoxTranzactiiInregistrate
            // 
            this.groupBoxTranzactiiInregistrate.Controls.Add(this.btnTiparesteTranzactie);
            this.groupBoxTranzactiiInregistrate.Controls.Add(this.btnStergeTranzactieSelectata);
            this.groupBoxTranzactiiInregistrate.Controls.Add(this.listViewTranzactiiExistente);
            this.groupBoxTranzactiiInregistrate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTranzactiiInregistrate.Location = new System.Drawing.Point(15, 611);
            this.groupBoxTranzactiiInregistrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTranzactiiInregistrate.Name = "groupBoxTranzactiiInregistrate";
            this.groupBoxTranzactiiInregistrate.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxTranzactiiInregistrate.Size = new System.Drawing.Size(1146, 308);
            this.groupBoxTranzactiiInregistrate.TabIndex = 1;
            this.groupBoxTranzactiiInregistrate.TabStop = false;
            this.groupBoxTranzactiiInregistrate.Text = "Tranzacții Înregistrate";
            // 
            // btnTiparesteTranzactie
            // 
            this.btnTiparesteTranzactie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiparesteTranzactie.Enabled = false;
            this.btnTiparesteTranzactie.Location = new System.Drawing.Point(736, 29);
            this.btnTiparesteTranzactie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTiparesteTranzactie.Name = "btnTiparesteTranzactie";
            this.btnTiparesteTranzactie.Size = new System.Drawing.Size(180, 35);
            this.btnTiparesteTranzactie.TabIndex = 2;
            this.btnTiparesteTranzactie.Text = "&Tipărește";
            this.btnTiparesteTranzactie.UseVisualStyleBackColor = true;
            this.btnTiparesteTranzactie.Click += new System.EventHandler(this.btnTiparesteTranzactie_Click);
            // 
            // btnStergeTranzactieSelectata
            // 
            this.btnStergeTranzactieSelectata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStergeTranzactieSelectata.Enabled = false;
            this.btnStergeTranzactieSelectata.Location = new System.Drawing.Point(932, 29);
            this.btnStergeTranzactieSelectata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStergeTranzactieSelectata.Name = "btnStergeTranzactieSelectata";
            this.btnStergeTranzactieSelectata.Size = new System.Drawing.Size(195, 35);
            this.btnStergeTranzactieSelectata.TabIndex = 1;
            this.btnStergeTranzactieSelectata.Text = "Ș&terge Tranzacția";
            this.btnStergeTranzactieSelectata.UseVisualStyleBackColor = true;
            this.btnStergeTranzactieSelectata.Click += new System.EventHandler(this.btnStergeTranzactieSelectata_Click);
            // 
            // listViewTranzactiiExistente
            // 
            this.listViewTranzactiiExistente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTranzactiiExistente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrId,
            this.colTrData,
            this.colTrClient,
            this.colTrTotal});
            this.listViewTranzactiiExistente.FullRowSelect = true;
            this.listViewTranzactiiExistente.GridLines = true;
            this.listViewTranzactiiExistente.HideSelection = false;
            this.listViewTranzactiiExistente.Location = new System.Drawing.Point(20, 78);
            this.listViewTranzactiiExistente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewTranzactiiExistente.MultiSelect = false;
            this.listViewTranzactiiExistente.Name = "listViewTranzactiiExistente";
            this.listViewTranzactiiExistente.Size = new System.Drawing.Size(1105, 207);
            this.listViewTranzactiiExistente.TabIndex = 0;
            this.listViewTranzactiiExistente.UseCompatibleStateImageBehavior = false;
            this.listViewTranzactiiExistente.View = System.Windows.Forms.View.Details;
            this.listViewTranzactiiExistente.SelectedIndexChanged += new System.EventHandler(this.listViewTranzactiiExistente_SelectedIndexChanged);
            // 
            // colTrId
            // 
            this.colTrId.Text = "ID Tranz.";
            this.colTrId.Width = 70;
            // 
            // colTrData
            // 
            this.colTrData.Text = "Data";
            this.colTrData.Width = 120;
            // 
            // colTrClient
            // 
            this.colTrClient.Text = "Client";
            this.colTrClient.Width = 250;
            // 
            // colTrTotal
            // 
            this.colTrTotal.Text = "Total General";
            this.colTrTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colTrTotal.Width = 150;
            // 
            // listBoxProduseSursaDragDrop
            // 
            this.listBoxProduseSursaDragDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProduseSursaDragDrop.FormattingEnabled = true;
            this.listBoxProduseSursaDragDrop.IntegralHeight = false;
            this.listBoxProduseSursaDragDrop.ItemHeight = 20;
            this.listBoxProduseSursaDragDrop.Location = new System.Drawing.Point(0, 31);
            this.listBoxProduseSursaDragDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxProduseSursaDragDrop.Name = "listBoxProduseSursaDragDrop";
            this.listBoxProduseSursaDragDrop.Size = new System.Drawing.Size(209, 565);
            this.listBoxProduseSursaDragDrop.TabIndex = 2;
            this.listBoxProduseSursaDragDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxProduseSursaDragDrop_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.label6.Size = new System.Drawing.Size(245, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Produse disponibile (Drag&&Drop):";
            // 
            // printDocumentTranzactie
            // 
            this.printDocumentTranzactie.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTranzactie_PrintPage);
            // 
            // printPreviewDialogTranzactie
            // 
            this.printPreviewDialogTranzactie.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTranzactie.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTranzactie.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogTranzactie.Document = this.printDocumentTranzactie;
            this.printPreviewDialogTranzactie.Enabled = true;
            this.printPreviewDialogTranzactie.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogTranzactie.Icon")));
            this.printPreviewDialogTranzactie.Name = "printPreviewDialogTranzactie";
            this.printPreviewDialogTranzactie.Visible = false;
            // 
            // splitContainerPrincipal
            // 
            this.splitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerPrincipal.Location = new System.Drawing.Point(15, 15);
            this.splitContainerPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerPrincipal.Name = "splitContainerPrincipal";
            // 
            // splitContainerPrincipal.Panel1
            // 
            this.splitContainerPrincipal.Panel1.Controls.Add(this.groupBoxTranzactieCurenta);
            this.splitContainerPrincipal.Panel1MinSize = 400;
            // 
            // splitContainerPrincipal.Panel2
            // 
            this.splitContainerPrincipal.Panel2.Controls.Add(this.panelDreaptaSus);
            this.splitContainerPrincipal.Panel2MinSize = 200;
            this.splitContainerPrincipal.Size = new System.Drawing.Size(1146, 596);
            this.splitContainerPrincipal.SplitterDistance = 931;
            this.splitContainerPrincipal.SplitterWidth = 6;
            this.splitContainerPrincipal.TabIndex = 4;
            // 
            // panelDreaptaSus
            // 
            this.panelDreaptaSus.Controls.Add(this.listBoxProduseSursaDragDrop);
            this.panelDreaptaSus.Controls.Add(this.label6);
            this.panelDreaptaSus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDreaptaSus.Location = new System.Drawing.Point(0, 0);
            this.panelDreaptaSus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDreaptaSus.Name = "panelDreaptaSus";
            this.panelDreaptaSus.Size = new System.Drawing.Size(209, 596);
            this.panelDreaptaSus.TabIndex = 4;
            // 
            // FormTranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 934);
            this.Controls.Add(this.splitContainerPrincipal);
            this.Controls.Add(this.groupBoxTranzactiiInregistrate);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1189, 893);
            this.Name = "FormTranzactii";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Gestiune Tranzacții";
            this.Load += new System.EventHandler(this.FormTranzactii_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTranzactii_KeyDown);
            this.groupBoxTranzactieCurenta.ResumeLayout(false);
            this.groupBoxTranzactieCurenta.PerformLayout();
            this.groupBoxAdaugareProdus.ResumeLayout(false);
            this.groupBoxAdaugareProdus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            this.groupBoxTranzactiiInregistrate.ResumeLayout(false);
            this.splitContainerPrincipal.Panel1.ResumeLayout(false);
            this.splitContainerPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).EndInit();
            this.splitContainerPrincipal.ResumeLayout(false);
            this.panelDreaptaSus.ResumeLayout(false);
            this.panelDreaptaSus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTranzactieCurenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClienti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataTranzactie;
        private System.Windows.Forms.GroupBox groupBoxAdaugareProdus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProduseDisponibile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCantitate;
        private System.Windows.Forms.Button btnAdaugaProdusInTranzactie;
        private System.Windows.Forms.ListView listViewProduseTranzactie;
        private System.Windows.Forms.ColumnHeader colProdDenumire;
        private System.Windows.Forms.ColumnHeader colProdCantitate;
        private System.Windows.Forms.ColumnHeader colProdPretUnitar;
        private System.Windows.Forms.ColumnHeader colProdValoareTotala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalGeneralTranzactie;
        private System.Windows.Forms.Button btnSalveazaTranzactie;
        private System.Windows.Forms.Button btnAnuleazaTranzactieNoua;
        private System.Windows.Forms.GroupBox groupBoxTranzactiiInregistrate;
        private System.Windows.Forms.ListView listViewTranzactiiExistente;
        private System.Windows.Forms.ColumnHeader colTrId;
        private System.Windows.Forms.ColumnHeader colTrData;
        private System.Windows.Forms.ColumnHeader colTrClient;
        private System.Windows.Forms.ColumnHeader colTrTotal;
        private System.Windows.Forms.Button btnStergeTranzactieSelectata;
        private System.Windows.Forms.ListBox listBoxProduseSursaDragDrop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStergeProdusDinTranzactie;
        private System.Windows.Forms.Button btnTiparesteTranzactie;
        private System.Drawing.Printing.PrintDocument printDocumentTranzactie;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogTranzactie;
        private System.Windows.Forms.SplitContainer splitContainerPrincipal;
        private System.Windows.Forms.Panel panelDreaptaSus;
    }
}