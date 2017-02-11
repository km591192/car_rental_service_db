using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Carrent
{
    class registration
    {
        Checkpassword checkpassword = new Checkpassword();
        Database db = new Database();
        FS fs = new FS();
        GSstring gsstring = new GSstring();
        Crypto crypto = new Crypto();
        //openformcontrol ofc = new openformcontrol();

        public bool checkpasswordandphone(CheckBox cbc, CheckBox cbpo, MaskedTextBox mtb, TextBox tb)
        {
            int flags = 0;
            if (cbc.Checked == true)
            {
                if (fs.checkpasswdfromfile("passc", mtb, tb) == true)
                    flags = 1;
            }
            if (cbpo.Checked == true)
            {
                if (fs.checkpasswdfromfile("passpo", mtb, tb) == true)
                    flags = 1;
            }

            if (flags == 1)
                return true;
            else return false;
        }

        public bool regestration(TextBox tb, TextBox tbv, MaskedTextBox mtb)
        {
            int Flags = 0;
            if (checkpassword.checkregistrationpassword(tb, tbv) == true) Flags++;
            else MessageBox.Show("Error in password");
            if (checkpassword.checkphone(mtb) == true) Flags++;
            else MessageBox.Show("Error in phone number");

            if (Flags == 2) return true; 
            else return false;

        }

        public void checkboxchecked(CheckBox cbcporeg, Label label3, TextBox textBox2)
        {
            if (cbcporeg.Checked == true)
            {
                label3.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox2.Visible = false;
            }
        }

        public void checkboxcheckedcpo(CheckBox cc, CheckBox cpo)
        {
            if (cc.Checked == true)
            {
                cpo.Visible = false;
            }
            if (cpo.Checked == true)
            {
                cc.Visible = false;
            }
            if (cc.Checked == false)
            {
                cpo.Visible = true;
            }
            if (cpo.Checked == false)
            {
                cc.Visible = true;
            } 
        }
        public int countid(string str)
        {
            string Query = "select COUNT(1) from \"Carrent\"." + str;
            int check = 0;
            check = db.countstrdatabasereturn(Query) + 1;
            return check;
        }

        public void stringtofile(MaskedTextBox mtb, TextBox tb, CheckBox cc, CheckBox cpo)
        {
            string s = "";
            string stmp = "";
            string id;
            if (cc.Checked == true)
            {
                id = countid("clients").ToString();
                fs.writenum(id);
                string hash = crypto.getMd5Hash(tb.Text);
                s = mtb.Text + " " + /*tb.Text*/hash + "\n";
                stmp = countid("clients").ToString() + "\n";
                fs.writeclient(s);
                fs.writeclient(stmp);
               // ofc.f4show();
                Form4 f4 = new Form4();
                f4.Show();
            }
            if (cpo.Checked == true)
            {
                id = countid("privateowner").ToString();
                fs.writenum(id);
                string hash = crypto.getMd5Hash(tb.Text);
                s =  mtb.Text + " " + /*tb.Text*/hash + "\n";
                stmp = countid("privateowner").ToString() + "\n";
                fs.writepo(s);
                fs.writepo(stmp);
               // ofc.f5show();
                Form5 f5 = new Form5();
                f5.Show();
            }
        }

        public bool checkcorpo(CheckBox c1, CheckBox c2, CheckBox c3)
        {
            if (c1.Checked == true && c2.Checked == true) { MessageBox.Show("Welcome to car rent service client"); return true; }
            if (c1.Checked == true && c3.Checked == true) { MessageBox.Show("Welcome to car rent service owner"); return true; }
            else return false;
        }

        public bool ischeckcpo(CheckBox c1, CheckBox c2)
        {
            if (c1.Checked == true) { MessageBox.Show("Welcome to car rent service client"); return true; }
            if (c2.Checked == true) { MessageBox.Show("Welcome to car rent service owner"); return true; }
            else return false;
        }


    }
}
