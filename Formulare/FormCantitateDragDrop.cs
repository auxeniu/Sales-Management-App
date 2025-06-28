using System;
using System.Windows.Forms;

namespace ProiectVanzari.Formulare
{
    public partial class FormCantitateDragDrop : Form
    {
        public int CantitateSelectata => (int)nudCantitateProdus.Value;

        public FormCantitateDragDrop(int stocMaxim)
        {
            InitializeComponent();
            nudCantitateProdus.Maximum = stocMaxim;
            nudCantitateProdus.Value = 1; 
        }
    }
}