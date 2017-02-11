using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carrent
{
    class Clear
    {
        public void Cleartb1(TextBox tb)
        {
            tb.Clear();
        }
        public void Cleartb2(TextBox tb1, TextBox tb2)
        {
            tb1.Clear();tb2.Clear();
        }
        public void Cleartb3(TextBox tb1,TextBox tb2,TextBox tb3)
        {
            tb1.Clear();tb2.Clear();tb3.Clear();
        }
        public void Cleartb4(TextBox tb1,TextBox tb2,TextBox tb3,TextBox tb4)
        {
            tb1.Clear();tb2.Clear();tb3.Clear();tb4.Clear();
        }
        public void Clearcb(ComboBox cb)
        {
            cb.ResetText();
        }
        public void Clearmtb(MaskedTextBox mtb)
        {
            mtb.Clear();
        }

    }
}
