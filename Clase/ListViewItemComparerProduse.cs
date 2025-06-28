using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectVanzari.Clase
{
    public class ListViewItemComparerProduse : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparerProduse(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal;
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            if (col == 1) 
            {
                decimal valX, valY;
                string textPriceX = itemX.SubItems[col].Text.Replace(" RON", "").Replace(" Lei", "").Replace(",", "."); 
                string textPriceY = itemY.SubItems[col].Text.Replace(" RON", "").Replace(" Lei", "").Replace(",", ".");

                if (decimal.TryParse(textPriceX, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out valX) &&
                    decimal.TryParse(textPriceY, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out valY))
                {
                    returnVal = decimal.Compare(valX, valY);
                }
                else
                {
                    returnVal = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text); 
                }
            }
            else if (col == 2) 
            {
                int valX, valY;
                if (int.TryParse(itemX.SubItems[col].Text, out valX) && int.TryParse(itemY.SubItems[col].Text, out valY))
                {
                    returnVal = valX.CompareTo(valY);
                }
                else
                {
                    returnVal = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text); 
                }
            }
            else 
            {
                returnVal = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text);
            }

            if (order == SortOrder.Descending)
                returnVal *= -1;

            return returnVal;
        }
    }
}
