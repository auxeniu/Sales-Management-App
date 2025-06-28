using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectVanzari.Clase
{
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;
        private bool isNumeric;

        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
            isNumeric = false;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal;
            string textX = ((ListViewItem)x).SubItems[col].Text;
            string textY = ((ListViewItem)y).SubItems[col].Text;
            returnVal = string.Compare(textX, textY);
            if (order == SortOrder.Descending)
                returnVal *= -1;

            return returnVal;
        }
    }
}
