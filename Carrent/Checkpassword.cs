using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Carrent
{
    class Checkpassword
    {
        public const string passwordformat = @"^([a-zA-Z0-9]+)$";

        public bool checkpassword (TextBox tb)
        {
            string s = DateTime.Now.ToString("yyyyMMdd");
           string stb = tb.Text;
           if (s == stb) return true;
           else
           {
               MessageBox.Show("Error in password");
               return false;
           }
        }
    public bool checkregistrationpassword (TextBox tb, TextBox tbv)
        {
           string stb = tb.Text;
           string s = tbv.Text;
           if ((s == stb))
          {
               /*if (stb != null) { return Regex.IsMatch(stb, passwordformat); }
               else {
                   MessageBox.Show("Error in password");
                   return false;
               }*/
               if (Regex.IsMatch(stb, passwordformat) == true)
                   return true;
               else return false;
          }
           else
           {
              MessageBox.Show("Error in password");
              return false;
           }
        }


    public bool checkphone(MaskedTextBox mtb)
    {
        if (mtb.Text.Length == 13) return true;
        else
        {
            MessageBox.Show("Error in phone format.");
            return false;
        }
    }
    }
}
