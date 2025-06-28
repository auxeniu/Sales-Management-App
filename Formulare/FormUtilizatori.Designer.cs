namespace ProiectVanzari.Formulare
{
    partial class FormUtilizatori
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
            this.listViewUtilizatori = new System.Windows.Forms.ListView();
            this.colNumeUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRolUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colActivUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxDetaliiUser = new System.Windows.Forms.GroupBox();
            this.lblIdUtilizatorEditat = new System.Windows.Forms.Label();
            this.btnAnuleazaEditare = new System.Windows.Forms.Button();
            this.btnSalveazaUtilizator = new System.Windows.Forms.Button();
            this.btnStergeUtilizator = new System.Windows.Forms.Button();
            this.btnModificaUtilizator = new System.Windows.Forms.Button();
            this.btnAdaugaUtilizator = new System.Windows.Forms.Button();
            this.chkEsteActiv = new System.Windows.Forms.CheckBox();
            this.cmbRoluri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmareParolaCrud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParolaCrud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeUtilizatorCrud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderUtilizatori = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainerUtilizatori = new System.Windows.Forms.SplitContainer();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxDetaliiUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUtilizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUtilizatori)).BeginInit();
            this.splitContainerUtilizatori.Panel1.SuspendLayout();
            this.splitContainerUtilizatori.Panel2.SuspendLayout();
            this.splitContainerUtilizatori.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewUtilizatori
            // 
            this.listViewUtilizatori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumeUser,
            this.colRolUser,
            this.colActivUser});
            this.listViewUtilizatori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUtilizatori.FullRowSelect = true;
            this.listViewUtilizatori.GridLines = true;
            this.listViewUtilizatori.HideSelection = false;
            this.listViewUtilizatori.Location = new System.Drawing.Point(0, 0);
            this.listViewUtilizatori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewUtilizatori.MultiSelect = false;
            this.listViewUtilizatori.Name = "listViewUtilizatori";
            this.listViewUtilizatori.Size = new System.Drawing.Size(775, 609);
            this.listViewUtilizatori.TabIndex = 0;
            this.listViewUtilizatori.UseCompatibleStateImageBehavior = false;
            this.listViewUtilizatori.View = System.Windows.Forms.View.Details;
            this.listViewUtilizatori.SelectedIndexChanged += new System.EventHandler(this.listViewUtilizatori_SelectedIndexChanged);
            // 
            // colNumeUser
            // 
            this.colNumeUser.Text = "Nume Utilizator";
            this.colNumeUser.Width = 300;
            // 
            // colRolUser
            // 
            this.colRolUser.Text = "Rol";
            this.colRolUser.Width = 120;
            // 
            // colActivUser
            // 
            this.colActivUser.Text = "Activ";
            this.colActivUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colActivUser.Width = 70;
            // 
            // groupBoxDetaliiUser
            // 
            this.groupBoxDetaliiUser.Controls.Add(this.lblIdUtilizatorEditat);
            this.groupBoxDetaliiUser.Controls.Add(this.btnAnuleazaEditare);
            this.groupBoxDetaliiUser.Controls.Add(this.btnSalveazaUtilizator);
            this.groupBoxDetaliiUser.Controls.Add(this.btnStergeUtilizator);
            this.groupBoxDetaliiUser.Controls.Add(this.btnModificaUtilizator);
            this.groupBoxDetaliiUser.Controls.Add(this.btnAdaugaUtilizator);
            this.groupBoxDetaliiUser.Controls.Add(this.chkEsteActiv);
            this.groupBoxDetaliiUser.Controls.Add(this.cmbRoluri);
            this.groupBoxDetaliiUser.Controls.Add(this.label4);
            this.groupBoxDetaliiUser.Controls.Add(this.txtConfirmareParolaCrud);
            this.groupBoxDetaliiUser.Controls.Add(this.label3);
            this.groupBoxDetaliiUser.Controls.Add(this.txtParolaCrud);
            this.groupBoxDetaliiUser.Controls.Add(this.label2);
            this.groupBoxDetaliiUser.Controls.Add(this.txtNumeUtilizatorCrud);
            this.groupBoxDetaliiUser.Controls.Add(this.label1);
            this.groupBoxDetaliiUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetaliiUser.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetaliiUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDetaliiUser.Name = "groupBoxDetaliiUser";
            this.groupBoxDetaliiUser.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.groupBoxDetaliiUser.Size = new System.Drawing.Size(365, 609);
            this.groupBoxDetaliiUser.TabIndex = 1;
            this.groupBoxDetaliiUser.TabStop = false;
            this.groupBoxDetaliiUser.Text = "Detalii Utilizator";
            // 
            // lblIdUtilizatorEditat
            // 
            this.lblIdUtilizatorEditat.AutoSize = true;
            this.lblIdUtilizatorEditat.Location = new System.Drawing.Point(19, 315);
            this.lblIdUtilizatorEditat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdUtilizatorEditat.Name = "lblIdUtilizatorEditat";
            this.lblIdUtilizatorEditat.Size = new System.Drawing.Size(18, 20);
            this.lblIdUtilizatorEditat.TabIndex = 14;
            this.lblIdUtilizatorEditat.Text = "0";
            this.lblIdUtilizatorEditat.Visible = false;
            // 
            // btnAnuleazaEditare
            // 
            this.btnAnuleazaEditare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuleazaEditare.Enabled = false;
            this.btnAnuleazaEditare.Location = new System.Drawing.Point(408, 399);
            this.btnAnuleazaEditare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuleazaEditare.Name = "btnAnuleazaEditare";
            this.btnAnuleazaEditare.Size = new System.Drawing.Size(112, 35);
            this.btnAnuleazaEditare.TabIndex = 13;
            this.btnAnuleazaEditare.Text = "A&nulează";
            this.toolTipInfo.SetToolTip(this.btnAnuleazaEditare, "Anulează editarea curentă (Escape)");
            this.btnAnuleazaEditare.UseVisualStyleBackColor = true;
            this.btnAnuleazaEditare.Click += new System.EventHandler(this.btnAnuleazaEditare_Click);
            // 
            // btnSalveazaUtilizator
            // 
            this.btnSalveazaUtilizator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalveazaUtilizator.Enabled = false;
            this.btnSalveazaUtilizator.Location = new System.Drawing.Point(19, 399);
            this.btnSalveazaUtilizator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalveazaUtilizator.Name = "btnSalveazaUtilizator";
            this.btnSalveazaUtilizator.Size = new System.Drawing.Size(380, 35);
            this.btnSalveazaUtilizator.TabIndex = 12;
            this.btnSalveazaUtilizator.Text = "&Salvează (Ctrl+S)";
            this.toolTipInfo.SetToolTip(this.btnSalveazaUtilizator, "Salvează modificările (Ctrl+S)");
            this.btnSalveazaUtilizator.UseVisualStyleBackColor = true;
            this.btnSalveazaUtilizator.Click += new System.EventHandler(this.btnSalveazaUtilizator_Click);
            // 
            // btnStergeUtilizator
            // 
            this.btnStergeUtilizator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStergeUtilizator.Enabled = false;
            this.btnStergeUtilizator.Location = new System.Drawing.Point(408, 354);
            this.btnStergeUtilizator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStergeUtilizator.Name = "btnStergeUtilizator";
            this.btnStergeUtilizator.Size = new System.Drawing.Size(112, 35);
            this.btnStergeUtilizator.TabIndex = 11;
            this.btnStergeUtilizator.Text = "Ște&rge";
            this.toolTipInfo.SetToolTip(this.btnStergeUtilizator, "Șterge utilizatorul selectat");
            this.btnStergeUtilizator.UseVisualStyleBackColor = true;
            this.btnStergeUtilizator.Click += new System.EventHandler(this.btnStergeUtilizator_Click);
            // 
            // btnModificaUtilizator
            // 
            this.btnModificaUtilizator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificaUtilizator.Enabled = false;
            this.btnModificaUtilizator.Location = new System.Drawing.Point(213, 354);
            this.btnModificaUtilizator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificaUtilizator.Name = "btnModificaUtilizator";
            this.btnModificaUtilizator.Size = new System.Drawing.Size(116, 35);
            this.btnModificaUtilizator.TabIndex = 10;
            this.btnModificaUtilizator.Text = "&Modifică";
            this.toolTipInfo.SetToolTip(this.btnModificaUtilizator, "Modifică utilizatorul selectat");
            this.btnModificaUtilizator.UseVisualStyleBackColor = true;
            this.btnModificaUtilizator.Click += new System.EventHandler(this.btnModificaUtilizator_Click);
            // 
            // btnAdaugaUtilizator
            // 
            this.btnAdaugaUtilizator.Location = new System.Drawing.Point(19, 354);
            this.btnAdaugaUtilizator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdaugaUtilizator.Name = "btnAdaugaUtilizator";
            this.btnAdaugaUtilizator.Size = new System.Drawing.Size(116, 35);
            this.btnAdaugaUtilizator.TabIndex = 9;
            this.btnAdaugaUtilizator.Text = "&Adaugă";
            this.toolTipInfo.SetToolTip(this.btnAdaugaUtilizator, "Adaugă un utilizator nou (Ctrl+N)");
            this.btnAdaugaUtilizator.UseVisualStyleBackColor = true;
            this.btnAdaugaUtilizator.Click += new System.EventHandler(this.btnAdaugaUtilizator_Click);
            // 
            // chkEsteActiv
            // 
            this.chkEsteActiv.AutoSize = true;
            this.chkEsteActiv.Checked = true;
            this.chkEsteActiv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEsteActiv.Enabled = false;
            this.chkEsteActiv.Location = new System.Drawing.Point(192, 272);
            this.chkEsteActiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEsteActiv.Name = "chkEsteActiv";
            this.chkEsteActiv.Size = new System.Drawing.Size(69, 24);
            this.chkEsteActiv.TabIndex = 8;
            this.chkEsteActiv.Text = "Activ";
            this.chkEsteActiv.UseVisualStyleBackColor = true;
            // 
            // cmbRoluri
            // 
            this.cmbRoluri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoluri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoluri.Enabled = false;
            this.cmbRoluri.FormattingEnabled = true;
            this.cmbRoluri.Location = new System.Drawing.Point(192, 215);
            this.cmbRoluri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRoluri.Name = "cmbRoluri";
            this.cmbRoluri.Size = new System.Drawing.Size(327, 28);
            this.cmbRoluri.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rol:";
            // 
            // txtConfirmareParolaCrud
            // 
            this.txtConfirmareParolaCrud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmareParolaCrud.Enabled = false;
            this.txtConfirmareParolaCrud.Location = new System.Drawing.Point(192, 154);
            this.txtConfirmareParolaCrud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmareParolaCrud.Name = "txtConfirmareParolaCrud";
            this.txtConfirmareParolaCrud.PasswordChar = '*';
            this.txtConfirmareParolaCrud.Size = new System.Drawing.Size(327, 26);
            this.txtConfirmareParolaCrud.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmare Parolă:";
            // 
            // txtParolaCrud
            // 
            this.txtParolaCrud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParolaCrud.Enabled = false;
            this.txtParolaCrud.Location = new System.Drawing.Point(192, 100);
            this.txtParolaCrud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParolaCrud.Name = "txtParolaCrud";
            this.txtParolaCrud.PasswordChar = '*';
            this.txtParolaCrud.Size = new System.Drawing.Size(327, 26);
            this.txtParolaCrud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parolă:";
            // 
            // txtNumeUtilizatorCrud
            // 
            this.txtNumeUtilizatorCrud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeUtilizatorCrud.Enabled = false;
            this.txtNumeUtilizatorCrud.Location = new System.Drawing.Point(192, 46);
            this.txtNumeUtilizatorCrud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeUtilizatorCrud.Name = "txtNumeUtilizatorCrud";
            this.txtNumeUtilizatorCrud.Size = new System.Drawing.Size(327, 26);
            this.txtNumeUtilizatorCrud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Utilizator:";
            // 
            // errorProviderUtilizatori
            // 
            this.errorProviderUtilizatori.ContainerControl = this;
            // 
            // splitContainerUtilizatori
            // 
            this.splitContainerUtilizatori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUtilizatori.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerUtilizatori.Location = new System.Drawing.Point(13, 12);
            this.splitContainerUtilizatori.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerUtilizatori.Name = "splitContainerUtilizatori";
            // 
            // splitContainerUtilizatori.Panel1 
            // 
            this.splitContainerUtilizatori.Panel1.Controls.Add(this.listViewUtilizatori);
            // 
            // splitContainerUtilizatori.Panel2
            // 
            this.splitContainerUtilizatori.Panel2.Controls.Add(this.groupBoxDetaliiUser);
            this.splitContainerUtilizatori.Panel2MinSize = 380;
            this.splitContainerUtilizatori.Size = new System.Drawing.Size(1019, 487);
            this.splitContainerUtilizatori.SplitterDistance = 634; 
            this.splitContainerUtilizatori.SplitterWidth = 5;
            this.splitContainerUtilizatori.TabIndex = 2;
            //
            // FormUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 639);
            this.Controls.Add(this.splitContainerUtilizatori);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(897, 511);
            this.Name = "FormUtilizatori";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.Text = "Gestiune Utilizatori";
            this.Load += new System.EventHandler(this.FormUtilizatori_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormUtilizatori_KeyDown);
            this.groupBoxDetaliiUser.ResumeLayout(false);
            this.groupBoxDetaliiUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUtilizatori)).EndInit();
            this.splitContainerUtilizatori.Panel1.ResumeLayout(false);
            this.splitContainerUtilizatori.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUtilizatori)).EndInit();
            this.splitContainerUtilizatori.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUtilizatori;
        private System.Windows.Forms.ColumnHeader colNumeUser;
        private System.Windows.Forms.ColumnHeader colRolUser;
        private System.Windows.Forms.ColumnHeader colActivUser;
        private System.Windows.Forms.GroupBox groupBoxDetaliiUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeUtilizatorCrud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParolaCrud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmareParolaCrud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRoluri;
        private System.Windows.Forms.CheckBox chkEsteActiv;
        private System.Windows.Forms.Button btnAdaugaUtilizator;
        private System.Windows.Forms.Button btnModificaUtilizator;
        private System.Windows.Forms.Button btnStergeUtilizator;
        private System.Windows.Forms.Button btnSalveazaUtilizator;
        private System.Windows.Forms.Button btnAnuleazaEditare;
        private System.Windows.Forms.ErrorProvider errorProviderUtilizatori;
        private System.Windows.Forms.Label lblIdUtilizatorEditat;
        private System.Windows.Forms.SplitContainer splitContainerUtilizatori;
        private System.Windows.Forms.ToolTip toolTipInfo;
    }
}