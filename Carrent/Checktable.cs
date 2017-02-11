using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Carrent
{
    class Checktable
    {
        Check check = new Check();

        public bool checktablea(DateTimePicker dtpaaccident, DateTimePicker dtpaend,TextBox tb2, TextBox tb5)
        {
            int Flags = 0;
            if (check.checkdate(dtpaaccident, dtpaend) == true)
                Flags++;
            else MessageBox.Show("Error in date");
                if ((check.checkisfreetb(tb2) && check.checkisfreetb(tb5)) == true)
                    Flags++;
                else MessageBox.Show("Error. Add text.");
                if (check.checkidtype(tb2) == true)
                    Flags++;
                else MessageBox.Show("Error in type lease agreement id.");
                if (check.checkid("leaseagreement", tb2) == true) 
                    Flags ++; 
                else MessageBox.Show("Error in id value");

            if (Flags == 4) return true;
            else {return false; }
        }

        public bool checktablem(ComboBox cb, TextBox tb2, TextBox tb5)
        {
            int Flags = 0;
            if ((check.checkisfreetb(tb2) && check.checkisfreetb(tb5)) == true)
                Flags++;
            else MessageBox.Show("Error. Add text.");
            if ((check.checknointtype(tb2) && check.checknointtype(tb5))  == true)
                Flags++;
            else MessageBox.Show("Error in type, write string.");
            if (check.checkcb(cb) == true)
                Flags++;
            else MessageBox.Show("Error. Select class.");

            if (Flags == 3) return true;
            else { return false; }
        }


        public bool checktablec(TextBox tb1, TextBox tb2, TextBox tb3)
        {
            int Flags = 0;
            if ((check.checkisfreetb(tb1) && check.checkisfreetb(tb2) && check.checkisfreetb(tb3)) == true)
                Flags++;
            else MessageBox.Show("Error. Add text.");
            if ((check.checknointtype(tb2) && check.checknointtype(tb3)) == true)
                Flags++;
            else MessageBox.Show("Error in type, write string.");
            if ((check.checkidtype(tb1)) == true)
                Flags++;
            else MessageBox.Show("Error type in ID model.");
            if (check.checkid("models", tb1) == true)
                Flags++;
            else MessageBox.Show("Error in value id model");

            if (Flags == 4) return true;
            else { return false; }
        }

        public bool checktableownerc(TextBox tb2, TextBox tb3)
        {
            int Flags = 0;
            if (( check.checkisfreetb(tb2) && check.checkisfreetb(tb3)) == true)
                Flags++;
            else MessageBox.Show("Error. Add text.");
            if ((check.checknointtype(tb2) && check.checknointtype(tb3)) == true)
                Flags++;
            else MessageBox.Show("Error in type, write string.");

            if (Flags == 2) return true;
            else { return false; }
        }

        public bool checktablela(DateTimePicker dtpstart , DateTimePicker dtpend,TextBox tbclientid, TextBox tbcarid, TextBox tbprice, TextBox tbcountry, TextBox tbcity)
        {
            int Flags = 0;
            if (check.checkdl(tbclientid.Text) == true) Flags++;
            else MessageBox.Show("You can not rent a car, because you have not driving license. You can rent a car with driver.");
            if (check.checkrent(tbcarid) == true) Flags++;
            else MessageBox.Show("You can not rent this car");
            if (check.checkdate(dtpstart,dtpend) == true) Flags ++;
            else MessageBox.Show("Error in date, end date must be > start date");
            if (check.checkid("clients", tbclientid) == true) Flags ++; 
                else MessageBox.Show("Error in id value");
            if (check.checkid("cars", tbcarid) == true) Flags ++; 
                else MessageBox.Show("Error in id value");
             if (check.checkidtype(tbclientid) == true) Flags ++; 
                else MessageBox.Show("Error in id type");
            if (check.checkidtype(tbcarid) == true) Flags ++; 
                else MessageBox.Show("Error in id type");
             if (check.checkidtype(tbprice) == true) Flags ++; 
                else MessageBox.Show("Error in id type,price must be integer");
            if (check.checknointtype(tbcountry) == true) Flags ++; 
                else MessageBox.Show("Error in type, write string");
             if (check.checknointtype(tbcity) == true) Flags ++; 
                else MessageBox.Show("Error in type, write string");
             if (check.checkprice(tbprice) == true) Flags++;
             else MessageBox.Show("Enter price >= 0");
             if ((check.checkisfreetb(tbclientid) && check.checkisfreetb(tbcarid) && check.checkisfreetb(tbprice) && check.checkisfreetb(tbcountry) && check.checkisfreetb(tbcity)) == true)
                 Flags++;

             if (Flags == 12) return true;
             else { return false; }
        }

        public bool checkownerowner(TextBox tbpoid, TextBox tbponame, TextBox tbposurname, MaskedTextBox mtbpophone, TextBox tbpoemail, TextBox tbpocarid, TextBox tbpocountry, TextBox tbpocity, TextBox tb3, TextBox tb4, ComboBox cb, TextBox tb3m, TextBox tb4m)
        {
            int flag = 0;
            if (checktableownerpo(tbponame, tbposurname, mtbpophone, tbpoemail, tbpocountry, tbpocity) == true) flag++;
            if (checktableownerc(tb3, tb4) == true) flag++;
            if (checktablem(cb, tb3m, tb4m) == true) flag++;
            if (flag == 3)
                return true;
            else return false;
        }

        public bool checktableclient(TextBox tbname, TextBox tbsurname, TextBox tbpassport,MaskedTextBox mtb)
        {
            int Flags = 0;

            if (check.checknointtype(tbname) && check.checknointtype(tbsurname) && check.checknointtype(tbpassport) == true) Flags++;
            else MessageBox.Show("Error in type, write string");
            if (check.checkisfreetb(tbname) && check.checkisfreetb(tbsurname) && check.checkisfreetb(tbpassport)  == true) Flags++;
            if (mtb.Text.Length == 13) Flags++;
            else MessageBox.Show("Error in phone format.");

            if (Flags == 3) return true;
            else { return false; }
        }

        public bool checktablepo(TextBox tbname, TextBox tbsurname, MaskedTextBox mtb, TextBox tbemail, TextBox tbcarid, TextBox tbcountry, TextBox tbcity)
        {
            int Flags = 0;

            if (check.checknointtype(tbname) && check.checknointtype(tbsurname) && check.checknointtype(tbemail) && check.checknointtype(tbcountry) && check.checknointtype(tbcity)  == true) Flags++;
            else MessageBox.Show("Error in type, write string");
            if (check.checkisfreetb(tbname) && check.checkisfreetb(tbsurname) && check.checkisfreetb(tbemail) && check.checkisfreetb(tbcountry) && check.checkisfreetb(tbcity) && check.checkisfreetb(tbcarid) == true) Flags++;
            if (mtb.Text.Length == 13) Flags++;
            else MessageBox.Show("Error in phone format.");
            if (check.checkid("cars", tbcarid) == true) Flags++;
            else MessageBox.Show("error in id type");
            if (check.checkemail(tbemail) == true) Flags++;
            else MessageBox.Show("error in email");

            if (Flags == 5) return true;
            else { return false; }
        }

        public bool checktableownerpo(TextBox tbname, TextBox tbsurname, MaskedTextBox mtb, TextBox tbemail, TextBox tbcountry, TextBox tbcity)
        {
            int Flags = 0;

            if (check.checknointtype(tbname) && check.checknointtype(tbsurname) && check.checknointtype(tbemail) && check.checknointtype(tbcountry) && check.checknointtype(tbcity) == true) Flags++;
            else MessageBox.Show("Error in type, write string");
            if (check.checkisfreetb(tbname) && check.checkisfreetb(tbsurname) && check.checkisfreetb(tbemail) && check.checkisfreetb(tbcountry) && check.checkisfreetb(tbcity) == true) Flags++;
            if (mtb.Text.Length == 13) Flags++;
            else MessageBox.Show("Error in phone format.");
            if (check.checkemail(tbemail) == true) Flags++;
            else MessageBox.Show("error in email");

            if (Flags == 4) return true;
            else { return false; }
        }

    }
}
