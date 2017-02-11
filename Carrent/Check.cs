using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Carrent
{
    class Check
    {
        Database db = new Database();
       // public const string mailformat = @"^([a-zA-Z0-9_\-.]+)@([a-zA-Z0-9\-]+)\.[a-zA-Z0-9\-.]$"; //в начале строки мб любая буква или цифра кроме спец символов повтор несколько раз (^[a-zA-Z0-9_\-.]+)
        public const string mailformat =
        	@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        // check date (dtp2>dtp1)
        public bool checkdate(DateTimePicker dtp1, DateTimePicker dtp2)
        {
            if (dtp2.Value.Year > dtp1.Value.Year)
                return true;
            else if (dtp2.Value.Month > dtp1.Value.Month)
                return true;
            else if (dtp2.Value.Day >= dtp1.Value.Day)
                return true;
            else return false;
        }

        //check id from table and current
        public bool checkid(string tablen, TextBox tb)
        {
            int checkid,checkidv=0;
            string query = "SELECT COUNT(1) FROM  \"Carrent\"." + tablen;
            checkid = db.countstrdatabasereturn(query);
            if (checkidtype(tb) == true)
             checkidv = Convert.ToInt32(tb.Text);
            if (checkidv <= checkid)
                return true;
            else return false;
        }


        public bool checkprice(TextBox tb)
        {
            int checkprice;
                checkprice = Convert.ToInt32(tb.Text);
            if (checkprice >= 0)
                return true;
            else return false;
        }


        //check id type
        public bool checkidtype(TextBox tb)
        {
            int result;
            if (int.TryParse(tb.Text, out result))
                return true;
            else return false;
        }

        //in cb must be text
        public bool checkcb(ComboBox cb)
        { 
            if (cb.Text == "")
                return false;
            else return true;
        }


        //check: have i got a driving license
        public bool checkdl(string str)
        {
            string Query = "select COUNT(1) from \"Carrent\".clients c where c.client_id = "+ str + " AND c.drivinglicense = true";
            int check = 0;
            check = db.countstrdatabasereturn(Query);
            if (check == 1) return true;
            else return false;
        }

        //check: email format
        public bool checkemail(TextBox tb)
        {
            string email = tb.Text;
            if (email != null) return Regex.IsMatch(email, mailformat);
            else return false;
        }

        //check: can i rent a car
        public bool checkrent(TextBox tb)
        {
            string Query = "SELECT COUNT(*)  FROM \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE " + System.Convert.ToInt16(tb.Text) +" = l1.cars_id AND  c1.cars_id = l1.cars_id AND (NOW() BETWEEN l1.data_start and l1.data_end)";
            string query = "SELECT COUNT(*)  FROM \"Carrent\".cars c1, \"Carrent\".leaseagreement l1, \"Carrent\".accident a WHERE   a.leaseagreement_id = l1.leaseagreement_id AND c1.cars_id = l1.cars_id AND (NOW() <= a.end_date) AND l1.cars_id = " + System.Convert.ToInt16(tb.Text);
            int check = 0;
            check = db.countstrdatabasereturn(Query);
            if (check == 0 )
            check = db.countstrdatabasereturn(query);
            if (check == 0) return true;
            else return false;
        }

        //text in tb?
        public bool checkisfreetb (TextBox tb)
        {
            int n;
            n = tb.Text.Length;
            if (n > 0) return true;
            else
            {
               MessageBox.Show("Enter text.");
               return false;
            }
        }

        //check no int type
        public bool checknointtype(TextBox tb)
        {
            int result;
            if (int.TryParse(tb.Text, out result))
                return false;
            else return true;
        }


    }
}
