namespace ProiectVanzari.Formulare
{
    partial class FormBunVenit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.Panel panelAntet;
        private System.Windows.Forms.PictureBox pictureBoxAntet;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblUtilizatorLogat;
        private System.Windows.Forms.Label lblTitluBunVenit;
        private System.Windows.Forms.Panel panelSumarDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTitluSumar; 
        private System.Windows.Forms.Label lblTitluSumar;
        private System.Windows.Forms.Button btnRefreshSumar;
        private System.Windows.Forms.Label lblInfoProduseActive;
        private System.Windows.Forms.Label lblInfoTranzactiiAzi;
        private System.Windows.Forms.Label lblInfoClientiTotal;
        private System.Windows.Forms.Panel panelActiuniRapide;
        private System.Windows.Forms.Button btnActiuneVeziProduse;
        private System.Windows.Forms.Button btnActiuneVeziClienti;
        private System.Windows.Forms.Button btnActiuneTranzactieNoua;
        private System.Windows.Forms.Panel panelSubsol;
        private System.Windows.Forms.Label lblDataOra;
        private System.Windows.Forms.Timer timerDataOra;
        private System.Windows.Forms.ToolTip toolTipBunVenit;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBunVenit));
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelAntet = new System.Windows.Forms.Panel();
            this.pictureBoxAntet = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblUtilizatorLogat = new System.Windows.Forms.Label();
            this.lblTitluBunVenit = new System.Windows.Forms.Label();
            this.panelSumarDate = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTitluSumar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshSumar = new System.Windows.Forms.Button();
            this.lblTitluSumar = new System.Windows.Forms.Label();
            this.lblInfoProduseActive = new System.Windows.Forms.Label();
            this.lblInfoTranzactiiAzi = new System.Windows.Forms.Label();
            this.lblInfoClientiTotal = new System.Windows.Forms.Label();
            this.panelActiuniRapide = new System.Windows.Forms.Panel();
            this.btnActiuneVeziProduse = new System.Windows.Forms.Button();
            this.btnActiuneVeziClienti = new System.Windows.Forms.Button();
            this.btnActiuneTranzactieNoua = new System.Windows.Forms.Button();
            this.panelSubsol = new System.Windows.Forms.Panel();
            this.lblDataOra = new System.Windows.Forms.Label();
            this.timerDataOra = new System.Windows.Forms.Timer(this.components);
            this.toolTipBunVenit = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.panelAntet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAntet)).BeginInit();
            this.panelSumarDate.SuspendLayout();
            this.flowLayoutPanelTitluSumar.SuspendLayout();
            this.panelActiuniRapide.SuspendLayout();
            this.panelSubsol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 1;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelAntet, 0, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelSumarDate, 0, 1);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelActiuniRapide, 0, 2);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelSubsol, 0, 4);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 5;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(1200, 922);
            this.tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // panelAntet
            // 
            this.panelAntet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelAntet.Controls.Add(this.pictureBoxAntet);
            this.panelAntet.Controls.Add(this.lblSlogan);
            this.panelAntet.Controls.Add(this.lblUtilizatorLogat);
            this.panelAntet.Controls.Add(this.lblTitluBunVenit);
            this.panelAntet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAntet.Location = new System.Drawing.Point(4, 5);
            this.panelAntet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAntet.Name = "panelAntet";
            this.panelAntet.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.panelAntet.Size = new System.Drawing.Size(1192, 178);
            this.panelAntet.TabIndex = 0;
            // 
            // pictureBoxAntet
            // 
            this.pictureBoxAntet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAntet.Location = new System.Drawing.Point(1015, 31);
            this.pictureBoxAntet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAntet.Name = "pictureBoxAntet";
            this.pictureBoxAntet.Size = new System.Drawing.Size(141, 115);
            this.pictureBoxAntet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAntet.TabIndex = 3;
            this.pictureBoxAntet.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlogan.Location = new System.Drawing.Point(35, 85);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(453, 30);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Soluția dumneavoastră pentru vânzări eficiente.";
            // 
            // lblUtilizatorLogat
            // 
            this.lblUtilizatorLogat.AutoSize = true;
            this.lblUtilizatorLogat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizatorLogat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUtilizatorLogat.Location = new System.Drawing.Point(36, 128);
            this.lblUtilizatorLogat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtilizatorLogat.Name = "lblUtilizatorLogat";
            this.lblUtilizatorLogat.Size = new System.Drawing.Size(123, 25);
            this.lblUtilizatorLogat.TabIndex = 1;
            this.lblUtilizatorLogat.Text = "Utilizator: N/A";
            // 
            // lblTitluBunVenit
            // 
            this.lblTitluBunVenit.AutoSize = true;
            this.lblTitluBunVenit.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluBunVenit.ForeColor = System.Drawing.Color.White;
            this.lblTitluBunVenit.Location = new System.Drawing.Point(30, 22);
            this.lblTitluBunVenit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitluBunVenit.Name = "lblTitluBunVenit";
            this.lblTitluBunVenit.Size = new System.Drawing.Size(236, 61);
            this.lblTitluBunVenit.TabIndex = 0;
            this.lblTitluBunVenit.Text = "Bun Venit!";
            // 
            // panelSumarDate
            // 
            this.panelSumarDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSumarDate.Controls.Add(this.flowLayoutPanelTitluSumar);
            this.panelSumarDate.Controls.Add(this.lblInfoProduseActive);
            this.panelSumarDate.Controls.Add(this.lblInfoTranzactiiAzi);
            this.panelSumarDate.Controls.Add(this.lblInfoClientiTotal);
            this.panelSumarDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSumarDate.Location = new System.Drawing.Point(4, 193);
            this.panelSumarDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSumarDate.Name = "panelSumarDate";
            this.panelSumarDate.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.panelSumarDate.Size = new System.Drawing.Size(1192, 140);
            this.panelSumarDate.TabIndex = 3;
            // 
            // flowLayoutPanelTitluSumar
            // 
            this.flowLayoutPanelTitluSumar.AutoSize = true;
            this.flowLayoutPanelTitluSumar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTitluSumar.Controls.Add(this.btnRefreshSumar);
            this.flowLayoutPanelTitluSumar.Controls.Add(this.lblTitluSumar);
            this.flowLayoutPanelTitluSumar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTitluSumar.Location = new System.Drawing.Point(30, 15);
            this.flowLayoutPanelTitluSumar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelTitluSumar.Name = "flowLayoutPanelTitluSumar";
            this.flowLayoutPanelTitluSumar.Size = new System.Drawing.Size(1132, 46);
            this.flowLayoutPanelTitluSumar.TabIndex = 5;
            this.flowLayoutPanelTitluSumar.WrapContents = false;
            // 
            // btnRefreshSumar
            // 
            this.btnRefreshSumar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefreshSumar.BackColor = System.Drawing.Color.Honeydew;
            this.btnRefreshSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshSumar.FlatAppearance.BorderSize = 0;
            this.btnRefreshSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSumar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshSumar.Image")));
            this.btnRefreshSumar.Location = new System.Drawing.Point(6, 4);
            this.btnRefreshSumar.Margin = new System.Windows.Forms.Padding(6, 4, 3, 4);
            this.btnRefreshSumar.Name = "btnRefreshSumar";
            this.btnRefreshSumar.Size = new System.Drawing.Size(34, 38);
            this.btnRefreshSumar.TabIndex = 1;
            this.toolTipBunVenit.SetToolTip(this.btnRefreshSumar, "Actualizează datele de sumar");
            this.btnRefreshSumar.UseVisualStyleBackColor = false;
            this.btnRefreshSumar.Click += new System.EventHandler(this.btnRefreshSumar_Click);
            // 
            // lblTitluSumar
            // 
            this.lblTitluSumar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitluSumar.AutoSize = true;
            this.lblTitluSumar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluSumar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitluSumar.Location = new System.Drawing.Point(47, 7);
            this.lblTitluSumar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitluSumar.Name = "lblTitluSumar";
            this.lblTitluSumar.Size = new System.Drawing.Size(143, 32);
            this.lblTitluSumar.TabIndex = 0;
            this.lblTitluSumar.Text = "Sumar Date";
            this.lblTitluSumar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoProduseActive
            // 
            this.lblInfoProduseActive.AutoSize = true;
            this.lblInfoProduseActive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProduseActive.Location = new System.Drawing.Point(551, 75);
            this.lblInfoProduseActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoProduseActive.Name = "lblInfoProduseActive";
            this.lblInfoProduseActive.Size = new System.Drawing.Size(170, 30);
            this.lblInfoProduseActive.TabIndex = 3;
            this.lblInfoProduseActive.Text = "Produse Active: -";
            // 
            // lblInfoTranzactiiAzi
            // 
            this.lblInfoTranzactiiAzi.AutoSize = true;
            this.lblInfoTranzactiiAzi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTranzactiiAzi.Location = new System.Drawing.Point(289, 75);
            this.lblInfoTranzactiiAzi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoTranzactiiAzi.Name = "lblInfoTranzactiiAzi";
            this.lblInfoTranzactiiAzi.Size = new System.Drawing.Size(154, 30);
            this.lblInfoTranzactiiAzi.TabIndex = 2;
            this.lblInfoTranzactiiAzi.Text = "Tranzacții Azi: -";
            // 
            // lblInfoClientiTotal
            // 
            this.lblInfoClientiTotal.AutoSize = true;
            this.lblInfoClientiTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoClientiTotal.Location = new System.Drawing.Point(35, 75);
            this.lblInfoClientiTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoClientiTotal.Name = "lblInfoClientiTotal";
            this.lblInfoClientiTotal.Size = new System.Drawing.Size(140, 30);
            this.lblInfoClientiTotal.TabIndex = 1;
            this.lblInfoClientiTotal.Text = "Total Clienți: -";
            // 
            // panelActiuniRapide
            // 
            this.panelActiuniRapide.Controls.Add(this.btnActiuneVeziProduse);
            this.panelActiuniRapide.Controls.Add(this.btnActiuneVeziClienti);
            this.panelActiuniRapide.Controls.Add(this.btnActiuneTranzactieNoua);
            this.panelActiuniRapide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiuniRapide.Location = new System.Drawing.Point(4, 343);
            this.panelActiuniRapide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelActiuniRapide.Name = "panelActiuniRapide";
            this.panelActiuniRapide.Padding = new System.Windows.Forms.Padding(75, 31, 75, 31);
            this.panelActiuniRapide.Size = new System.Drawing.Size(1192, 494);
            this.panelActiuniRapide.TabIndex = 1;
            // 
            // btnActiuneVeziProduse
            // 
            this.btnActiuneVeziProduse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActiuneVeziProduse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.btnActiuneVeziProduse.FlatAppearance.BorderSize = 0;
            this.btnActiuneVeziProduse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiuneVeziProduse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiuneVeziProduse.ForeColor = System.Drawing.Color.White;
            this.btnActiuneVeziProduse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActiuneVeziProduse.Location = new System.Drawing.Point(433, 310);
            this.btnActiuneVeziProduse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActiuneVeziProduse.Name = "btnActiuneVeziProduse";
            this.btnActiuneVeziProduse.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnActiuneVeziProduse.Size = new System.Drawing.Size(324, 92);
            this.btnActiuneVeziProduse.TabIndex = 2;
            this.btnActiuneVeziProduse.Text = "  Vizualizează Produse";
            this.btnActiuneVeziProduse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActiuneVeziProduse.UseVisualStyleBackColor = false;
            this.btnActiuneVeziProduse.Click += new System.EventHandler(this.btnActiuneVeziProduse_Click);
            // 
            // btnActiuneVeziClienti
            // 
            this.btnActiuneVeziClienti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActiuneVeziClienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActiuneVeziClienti.FlatAppearance.BorderSize = 0;
            this.btnActiuneVeziClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiuneVeziClienti.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiuneVeziClienti.ForeColor = System.Drawing.Color.White;
            this.btnActiuneVeziClienti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActiuneVeziClienti.Location = new System.Drawing.Point(433, 186);
            this.btnActiuneVeziClienti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActiuneVeziClienti.Name = "btnActiuneVeziClienti";
            this.btnActiuneVeziClienti.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnActiuneVeziClienti.Size = new System.Drawing.Size(324, 92);
            this.btnActiuneVeziClienti.TabIndex = 1;
            this.btnActiuneVeziClienti.Text = "  Gestionează Clienți";
            this.btnActiuneVeziClienti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActiuneVeziClienti.UseVisualStyleBackColor = false;
            this.btnActiuneVeziClienti.Click += new System.EventHandler(this.btnActiuneVeziClienti_Click);
            // 
            // btnActiuneTranzactieNoua
            // 
            this.btnActiuneTranzactieNoua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActiuneTranzactieNoua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(7)))));
            this.btnActiuneTranzactieNoua.FlatAppearance.BorderSize = 0;
            this.btnActiuneTranzactieNoua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiuneTranzactieNoua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiuneTranzactieNoua.ForeColor = System.Drawing.Color.White;
            this.btnActiuneTranzactieNoua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActiuneTranzactieNoua.Location = new System.Drawing.Point(433, 61);
            this.btnActiuneTranzactieNoua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActiuneTranzactieNoua.Name = "btnActiuneTranzactieNoua";
            this.btnActiuneTranzactieNoua.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnActiuneTranzactieNoua.Size = new System.Drawing.Size(324, 92);
            this.btnActiuneTranzactieNoua.TabIndex = 0;
            this.btnActiuneTranzactieNoua.Text = "  Tranzacție Nouă";
            this.btnActiuneTranzactieNoua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActiuneTranzactieNoua.UseVisualStyleBackColor = false;
            this.btnActiuneTranzactieNoua.Click += new System.EventHandler(this.btnActiuneTranzactieNoua_Click);
            // 
            // panelSubsol
            // 
            this.panelSubsol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelSubsol.Controls.Add(this.lblDataOra);
            this.panelSubsol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubsol.Location = new System.Drawing.Point(4, 878);
            this.panelSubsol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSubsol.Name = "panelSubsol";
            this.panelSubsol.Size = new System.Drawing.Size(1192, 39);
            this.panelSubsol.TabIndex = 2;
            // 
            // lblDataOra
            // 
            this.lblDataOra.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDataOra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataOra.Location = new System.Drawing.Point(686, 0);
            this.lblDataOra.Margin = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.lblDataOra.Name = "lblDataOra";
            this.lblDataOra.Size = new System.Drawing.Size(506, 39);
            this.lblDataOra.TabIndex = 0;
            this.lblDataOra.Text = "Data și Ora";
            this.lblDataOra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDataOra
            // 
            this.timerDataOra.Enabled = true;
            this.timerDataOra.Interval = 1000;
            this.timerDataOra.Tick += new System.EventHandler(this.timerDataOra_Tick);
            // 
            // FormBunVenit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 922);
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBunVenit";
            this.Text = "Bun Venit";
            this.Load += new System.EventHandler(this.FormBunVenit_Load);
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.panelAntet.ResumeLayout(false);
            this.panelAntet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAntet)).EndInit();
            this.panelSumarDate.ResumeLayout(false);
            this.panelSumarDate.PerformLayout();
            this.flowLayoutPanelTitluSumar.ResumeLayout(false);
            this.flowLayoutPanelTitluSumar.PerformLayout();
            this.panelActiuniRapide.ResumeLayout(false);
            this.panelSubsol.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}