using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProiectVanzari.ControaleUtilizator
{
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [Description("Textul afișat în etichetă.")]
        public string LabelText
        {
            get { return labelControl.Text; }
            set { labelControl.Text = value; }
        }

        [Category("Appearance")]
        [Description("Textul din caseta de text.")]
        public override string Text 
        {
            get { return textBoxControl.Text; }
            set { textBoxControl.Text = value; }
        }

        [Category("Behavior")]
        [Description("Indică dacă TextBox-ul este multiline.")]
        public bool Multiline
        {
            get { return textBoxControl.Multiline; }
            set
            {
                textBoxControl.Multiline = value;
                if (value)
                {
                    textBoxControl.ScrollBars = ScrollBars.Vertical;
                    
                    this.Height = Math.Max(this.Height, textBoxControl.PreferredHeight + labelControl.Height + 10);
                    textBoxControl.Height = this.Height - labelControl.Top - labelControl.Height - 5; 
                }
                else
                {
                    textBoxControl.ScrollBars = ScrollBars.None;
                    
                    this.Height = labelControl.Height + textBoxControl.Height + 6;
                    textBoxControl.Height = 20; 
                }
            }
        }

        [Category("Behavior")]
        [Description("Indică dacă TextBox-ul este read-only.")]
        public bool ReadOnly
        {
            get { return textBoxControl.ReadOnly; }
            set { textBoxControl.ReadOnly = value; }
        }

        
        public TextBox TextBoxInstance => textBoxControl;
    }
}