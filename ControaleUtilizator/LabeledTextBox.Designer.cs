namespace ProiectVanzari.ControaleUtilizator
{
    partial class LabeledTextBox
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelControl;
        private System.Windows.Forms.TextBox textBoxControl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelControl = new System.Windows.Forms.Label();
            this.textBoxControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.Location = new System.Drawing.Point(3, 6);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(35, 13);
            this.labelControl.TabIndex = 0;
            this.labelControl.Text = "Eticheta";
            // 
            // textBoxControl
            // 
            this.textBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxControl.Location = new System.Drawing.Point(80, 3);
            this.textBoxControl.Name = "textBoxControl";
            this.textBoxControl.Size = new System.Drawing.Size(150, 20);
            this.textBoxControl.TabIndex = 1;
            // 
            // LabeledTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxControl);
            this.Controls.Add(this.labelControl);
            this.Name = "LabeledTextBox";
            this.Size = new System.Drawing.Size(235, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}