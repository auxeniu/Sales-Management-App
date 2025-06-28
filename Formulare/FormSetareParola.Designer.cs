namespace ProiectVanzari.Formulare
{
    partial class FormSetareParola
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
            this.lblInfoUtilizator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParolaNoua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmareParolaNoua = new System.Windows.Forms.TextBox();
            this.btnSalveazaParola = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProviderParola = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParola)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoUtilizator
            // 
            this.lblInfoUtilizator.AutoSize = true;
            this.lblInfoUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoUtilizator.Location = new System.Drawing.Point(25, 25);
            this.lblInfoUtilizator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoUtilizator.Name = "lblInfoUtilizator";
            this.lblInfoUtilizator.Size = new System.Drawing.Size(209, 18);
            this.lblInfoUtilizator.TabIndex = 0;
            this.lblInfoUtilizator.Text = "Setați parola pentru utilizatorul: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parolă nouă:";
            // 
            // txtParolaNoua
            // 
            this.txtParolaNoua.Location = new System.Drawing.Point(170, 67);
            this.txtParolaNoua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParolaNoua.Name = "txtParolaNoua";
            this.txtParolaNoua.PasswordChar = '*';
            this.txtParolaNoua.Size = new System.Drawing.Size(230, 22);
            this.txtParolaNoua.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmare Parolă:";
            // 
            // txtConfirmareParolaNoua
            // 
            this.txtConfirmareParolaNoua.Location = new System.Drawing.Point(170, 107);
            this.txtConfirmareParolaNoua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmareParolaNoua.Name = "txtConfirmareParolaNoua";
            this.txtConfirmareParolaNoua.PasswordChar = '*';
            this.txtConfirmareParolaNoua.Size = new System.Drawing.Size(230, 22);
            this.txtConfirmareParolaNoua.TabIndex = 1;
            // 
            // btnSalveazaParola
            // 
            this.btnSalveazaParola.Location = new System.Drawing.Point(170, 155);
            this.btnSalveazaParola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalveazaParola.Name = "btnSalveazaParola";
            this.btnSalveazaParola.Size = new System.Drawing.Size(110, 28);
            this.btnSalveazaParola.TabIndex = 2;
            this.btnSalveazaParola.Text = "Salvează";
            this.btnSalveazaParola.UseVisualStyleBackColor = true;
            this.btnSalveazaParola.Click += new System.EventHandler(this.btnSalveazaParola_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(290, 155);
            this.btnAnuleaza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(110, 28);
            this.btnAnuleaza.TabIndex = 3;
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // errorProviderParola
            // 
            this.errorProviderParola.ContainerControl = this;
            // 
            // FormSetareParola
            // 
            this.AcceptButton = this.btnSalveazaParola;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(432, 203);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveazaParola);
            this.Controls.Add(this.txtConfirmareParolaNoua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParolaNoua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfoUtilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetareParola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setare Parolă Utilizator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoUtilizator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParolaNoua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmareParolaNoua;
        private System.Windows.Forms.Button btnSalveazaParola;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProviderParola;
    }
}