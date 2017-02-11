using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carrent
{
    class Initialization
    {
        public void setdate(DateTimePicker dtp)
        {
            dtp.Value = DateTime.Now;
        }
        public void setdate2(DateTimePicker dtp, DateTimePicker dtp2)
        {
            dtp.Value = DateTime.Now;
            dtp2.Value = DateTime.Now;
        }

        public void countprice(DateTimePicker dtp1, DateTimePicker dtp2, TextBox tb, int priceofday)
        {
            int year = dtp2.Value.Year - dtp1.Value.Year;
            int month = dtp2.Value.Month - dtp1.Value.Month;
            int day = dtp2.Value.Day - dtp1.Value.Day;
            int days = year * 365 + month * 30 + day ;
            if (days == 0) days = 1;
            int count = days * priceofday;
            tb.Text = count.ToString();
        }

        public string returncountprice(DateTimePicker dtp1, DateTimePicker dtp2, int priceofday)
        {
            int year = dtp2.Value.Year - dtp1.Value.Year;
            int month = dtp2.Value.Month - dtp1.Value.Month;
            int day = dtp2.Value.Day - dtp1.Value.Day;
            int days = year * 365 + month * 30 + day;
            if (days == 0) days = 1;
            int count = days * priceofday;
            return count.ToString();
        }

    }
}
