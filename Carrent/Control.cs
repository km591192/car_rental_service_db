using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Carrent
{
   public class Controler
    {
       BL bll = new BL();
       Database dbc = new Database();
       GSstring gsstring = new GSstring();
       Check check = new Check();
       Checktable checktable = new Checktable();
       Clear clear = new Clear();
       Initialization init = new Initialization();

        public void controluser(GroupBox gb, GroupBox gb1)
        {
            gb.Visible = true;
            gb1.Visible = false;
        }

        public void controlowner(GroupBox gb, GroupBox gb1)
        {
            gb.Visible = true;
            gb1.Visible = false;
        }
        public void initialization(DateTimePicker dtp1, DateTimePicker dtp2)
        {
            init.setdate2(dtp1, dtp2);
        }

        public void clearaccident(TextBox tb1, TextBox tb2, TextBox tb5, TextBox tb6)
        {
            clear.Cleartb4(tb1, tb2, tb5, tb6);
        }
        public void clearclient(TextBox tb1, TextBox tb2, TextBox tb5, MaskedTextBox mtb)
        {
            clear.Cleartb3(tb1, tb2, tb5); clear.Clearmtb(mtb);
        }
        public void clearpo(TextBox tb0,TextBox tb1, TextBox tb2, TextBox tb5, TextBox tb3, TextBox tb4, TextBox tb6, MaskedTextBox mtb)
        {
            clear.Cleartb4(tb1, tb2, tb3, tb4); 
            clear.Cleartb3(tb0,tb5, tb6); 
            clear.Clearmtb(mtb);
        }
        public void clearcar(TextBox tb1, TextBox tb2, TextBox tb5, TextBox tb6)
        {
            clear.Cleartb4(tb1, tb2, tb5, tb6);
        }
        public void clearmodel(TextBox tb1, TextBox tb2, TextBox tb3, ComboBox cb)
        {
            clear.Cleartb3(tb1, tb2, tb3);
            clear.Clearcb(cb);
        }
        public void clearla(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6)
        {
            clear.Cleartb4(tb1, tb2, tb3, tb4);
            clear.Cleartb2(tb5, tb6);
        }
        public void showcars(DataGridView dgv)
        {
            bll.selectquerybl();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showmodels(DataGridView dgv)
        {
            bll.selectqueryblmodels();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showla(DataGridView dgv)
        {
            bll.selectqueryblla();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showfreecars(DataGridView dgv)
        {
            bll.selectqueryblfreecars();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showa(DataGridView dgv)
        {
            bll.selectqueryblaccident();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showpo(DataGridView dgv)
        {
            bll.selectqueryblpo();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showclient(DataGridView dgv)
        {
            bll.selectqueryblclient();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showallcarinfo(DataGridView dgv,Button btn)
        {
            bll.selectqueryblallcarinfo();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn, "Show information (about all car for rent) such as car number, color, car class, car model, car marka.");
        }

        public void showallfreecarinfo(DataGridView dgv, Button btn)
        {
            bll.selectqueryblallfreecarinfo();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }

        public void showallfreecarinfoclient(DataGridView dgv, Button btn)
        {
            bll.selectqueryblallfreecarinfo();
            string query = File.ReadAllText("query");
            dbc.Selectdatabaseclient(query, dgv);
        }
        public void showcarinmycity(DataGridView dgv, TextBox tb)
        {
            if (check.checkisfreetb(tb) == true)
            {
                bll.selectqueryblcarincity(tb);
                string query = File.ReadAllText("query");
                dbc.Selectdatabase(query, dgv);
            }
            else MessageBox.Show("Error. Enter city");
        }
        public void showpopcarinmycity(DataGridView dgv, TextBox tb)
        {
            if (check.checkisfreetb(tb) == true)
            {
                bll.selectqueryblpopcarincity(tb);
                string query = File.ReadAllText("query");
                dbc.Selectdatabase(query, dgv);
            }
            else MessageBox.Show("Error. Enter city");
        }


        public void showcarinmycityclient(DataGridView dgv, TextBox tb)
        {
            if (check.checkisfreetb(tb) == true)
            {
                bll.selectqueryblcarincity(tb);
                string query = File.ReadAllText("query");
                dbc.Selectdatabaseclient(query, dgv);
            }
            else MessageBox.Show("Error. Enter city");
        }
        public void showpopcarinmycityclient(DataGridView dgv, TextBox tb)
        {
            if (check.checkisfreetb(tb) == true)
            {
                bll.selectqueryblpopcarincity(tb);
                string query = File.ReadAllText("query");
                dbc.Selectdatabaseclient(query, dgv);
            }
            else MessageBox.Show("Error. Enter city");
        }

        public void showallpopcar(DataGridView dgv, Button btn)
        {
            bll.selectqueryblallpopcar();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn, "Show all popular cars in car rental service.");
        }

        public void showallfreepopcar(DataGridView dgv, Button btn)
        {
            bll.selectqueryblaallfreepopcar();
            string query = File.ReadAllText("query");
            dbc.Selectdatabase(query, dgv);
        }
        public void showallfreepopcarclient(DataGridView dgv, Button btn)
        {
            bll.selectqueryblaallfreepopcar();
            string query = File.ReadAllText("query");
            dbc.Selectdatabaseclient(query, dgv);
        }

        public void showownercarstatistic(DataGridView dgv,TextBox tbpoid)
        {
            bll.sqstatisticpo(tbpoid);
            string query = File.ReadAllText("query");
            dbc.Selectdatabasepo(query, dgv);
        }
        public void showownermorecarstatistic(DataGridView dgv, TextBox tbpoid)
        {
            bll.sqmorestatisticpo(tbpoid);
            string query = File.ReadAllText("query");
            dbc.Selectdatabasepo(query, dgv);
        }
        public void showownercaraccidentstatistic(DataGridView dgv, TextBox tbpoid)
        {
            bll.sqowneraccidentstatistic(tbpoid);
            string query = File.ReadAllText("query");
            dbc.Selectdatabasepo(query, dgv);
        }
        public void showownermyclient(DataGridView dgv, TextBox tbpoid)
        {
            bll.sqownermyclient(tbpoid);
            string query = File.ReadAllText("query");
            dbc.Selectdatabasepo(query, dgv);
        }



        public void addaccident(TextBox tb1, TextBox tb2, DateTimePicker dtpaend, DateTimePicker dtpaaccident,TextBox tb5, TextBox tb6)
        {
            bll.selectcountblaccident();
            string query = File.ReadAllText("query");
            dbc.countstrdatabase(query,tb1);
            if (checktable.checktablea(dtpaaccident, dtpaend, tb2,tb5) == true)
            {
                string str = tb1.Text + "," + tb2.Text + ",'" + dtpaend.Value.ToString("yyyy-MM-dd") + "','" + dtpaaccident.Value.ToString("yyyy-MM-dd") + "','" + tb5.Text + "','" + tb6.Text + "'";
                gsstring.strings = str;
                bll.insertaccident(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insert(_query);
            }
            else MessageBox.Show("Error");
        }

        public void addmodel(TextBox tb1, ComboBox cb , TextBox tb3, TextBox tb4)
        {
            bll.selectcountblmodel();
            string query = File.ReadAllText("query");
            dbc.countstrdatabase(query, tb1);
            if (checktable.checktablem(cb, tb3, tb4) == true)
            {
                string str = tb1.Text + ",'" + cb.SelectedItem.ToString() + "','" + tb3.Text + "','" + tb4.Text + "'";
                gsstring.strings = str;
                bll.insertmodel(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insert(_query);
            }
            else MessageBox.Show("Error");
        }

       public void addownermodel(TextBox tb1, ComboBox cb , TextBox tb3, TextBox tb4)
        {
            if (checktable.checktablem(cb, tb3, tb4) == true)
            {
                string str = tb1.Text + ",'" + cb.SelectedItem.ToString() + "','" + tb3.Text + "','" + tb4.Text + "'";
                gsstring.strings = str;
                bll.insertmodel(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insertpo(_query);
            }
            else MessageBox.Show("Error");
        }
        public void addcar(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4)
        {
            bll.selectcountblcars();
            string query = File.ReadAllText("query");
            dbc.countstrdatabase(query, tb1);
            if (checktable.checktablec(tb2, tb3, tb4) == true)
            {
                string str = tb1.Text + "," + tb2.Text + ",'" + tb3.Text + "','" + tb4.Text + "'";
                gsstring.strings = str;
                bll.insertcars(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insert(_query);
            }
            else MessageBox.Show("Error");
        }

        public void setowner(TextBox tbownerpoid, TextBox tbownerpocarid, TextBox tbcarcarid, TextBox tbcarmodelid, TextBox tbownermodelid)
        {
            bll.selectcountblpo();
            string query0 = File.ReadAllText("query");
            dbc.countstrdatabase(query0, tbownerpoid);
            bll.selectcountblcars();
            string query_ = File.ReadAllText("query");
            dbc.countstrdatabase(query_, tbownerpocarid);
            dbc.countstrdatabase(query_, tbcarcarid);
            bll.selectcountblmodel();
            string query1 = File.ReadAllText("query");
            dbc.countstrdatabase(query1, tbcarmodelid);
            dbc.countstrdatabase(query1, tbownermodelid);
        }

        public void addownercar(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4)
        {
            if (checktable.checktableownerc(tb3, tb4) == true)
            {
                string str = tb1.Text + "," + tb2.Text + ",'" + tb3.Text + "','" + tb4.Text + "'";
                gsstring.strings = str;
                bll.insertcars(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insertpo(_query);
            }
            else MessageBox.Show("Error");
        }

        public void recomendedprice(TextBox tbcarid, DateTimePicker dtpstart, DateTimePicker dtpend)
        {
            if (check.checkisfreetb(tbcarid) == true)
            {
                bll.carclass(tbcarid);
                string query1 = File.ReadAllText("query");
                string s = dbc.returnstrfromdatabase(query1);
                int price = 75;
                if (s.Contains("lux")) price = 100;
                if (s.Contains("econom")) price = 50;
                string sprice = init.returncountprice(dtpstart, dtpend, price);
                MessageBox.Show("Recomended price =  " + sprice);
            }
            else MessageBox.Show("Enter car id ");
        }


        public void addla(TextBox tblaid, DateTimePicker dtpstart, DateTimePicker dtpend, TextBox tbclientid, TextBox tbcarid, TextBox tbprice, TextBox tbcountry, TextBox tbcity)
        {
            bll.selectcountblla();
            string query = File.ReadAllText("query");
            dbc.countstrdatabase(query, tblaid);
            if (checktable.checktablela(dtpstart,dtpend,tbclientid,tbcarid,tbprice,tbcountry,tbcity) == true)
            {
                string str = tblaid.Text + ",'" + dtpstart.Value.ToString("yyyy-MM-dd")+"','" + dtpend.Value.ToString("yyyy-MM-dd") + "'," + tbclientid.Text + "," + tbcarid.Text + "," + tbprice.Text + ",'" + tbcountry.Text + "','" + tbcity.Text + "'";
                gsstring.strings = str;
                bll.insertla(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insert(_query);
            }
            else MessageBox.Show("Error");
        }

        public void addlaclient(TextBox tblaid, DateTimePicker dtpstart, DateTimePicker dtpend, TextBox tbclientid, TextBox tbcarid, TextBox tbprice, TextBox tbcountry, TextBox tbcity)
        {
            bll.selectcountblla();
            string query = File.ReadAllText("query");
            dbc.countstrdatabase(query, tblaid);
            bll.carclass(tbcarid);
            string query1 = File.ReadAllText("query");
            string s = dbc.returnstrfromdatabase(query1);
            int price = 75;
            if (s.Contains("lux")) price = 100;
            if (s.Contains("econom")) price = 50;
            init.countprice(dtpstart, dtpend, tbprice, price);
            if (checktable.checktablela(dtpstart, dtpend, tbclientid, tbcarid, tbprice, tbcountry, tbcity) == true)
            {
                string str = tblaid.Text + ",'" + dtpstart.Value.ToString("yyyy-MM-dd") + "','" + dtpend.Value.ToString("yyyy-MM-dd") + "'," + tbclientid.Text + "," + tbcarid.Text + "," + tbprice.Text + ",'" + tbcountry.Text + "','" + tbcity.Text + "'";
                gsstring.strings = str;
                bll.insertla(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insertclient(_query);
            }
            else MessageBox.Show("Error");
        }

        public void addclient(TextBox tbclientid, TextBox tbname, TextBox tbsurname, TextBox tbpassport, MaskedTextBox tbphone, CheckBox cbdl, DateTimePicker dtpclientbirthday)
        {
            bll.selectcountblclient();
            string query = File.ReadAllText("query");
            dbc.countstrdatabase(query, tbclientid);
            if (checktable.checktableclient(tbname, tbsurname,tbpassport,tbphone) == true)
            {
                string str = tbclientid.Text + ",'" + tbname.Text + "','" + tbsurname.Text + "','" + tbpassport.Text + "','" + tbphone.Text + "','" + cbdl.Checked.ToString() + "','" + dtpclientbirthday.Value.ToString("yyyy-MM-dd") + "'";
                gsstring.strings = str;
                bll.insertclient(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insert(_query);
            }
            else MessageBox.Show("Error");
        }

        public void addpo(TextBox tbpoid, TextBox tbponame, TextBox tbposurname, MaskedTextBox mtbpophone, TextBox tbpoemail, TextBox tbpocarid, TextBox tbpocountry, TextBox tbpocity)
        {
            bll.selectcountblpo();
            string query = File.ReadAllText("query");
            dbc.countstrdatabase(query, tbpoid);
            if (checktable.checktablepo(tbponame, tbposurname, mtbpophone, tbpoemail, tbpocarid, tbpocountry, tbpocity) == true)
            {
                string str = tbpoid.Text + ",'" + tbponame.Text + "','" + tbposurname.Text + "','" + mtbpophone.Text + "','" + tbpoemail.Text + "'," + tbpocarid.Text + ",'" + tbpocountry.Text + "','" + tbpocity.Text + "'";
                gsstring.strings = str;
                bll.insertpo(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insert(_query);
            }
            else MessageBox.Show("Error");
        }

        public void addownerpo(TextBox tbpoid, TextBox tbponame, TextBox tbposurname, MaskedTextBox mtbpophone, TextBox tbpoemail, TextBox tbpocarid, TextBox tbpocountry, TextBox tbpocity)
        {
            if (checktable.checktableownerpo(tbponame,tbposurname,mtbpophone,tbpoemail,tbpocountry, tbpocity) == true)
            {
                string str = tbpoid.Text + ",'" + tbponame.Text + "','" + tbposurname.Text + "','" + mtbpophone.Text + "','" + tbpoemail.Text + "'," + tbpocarid.Text + ",'" + tbpocountry.Text + "','" + tbpocity.Text + "'";
                gsstring.strings = str;
                bll.insertpo(gsstring.strings);
                string _query = File.ReadAllText("query");
                dbc.insertpo(_query);
            }
            else MessageBox.Show("Error");
        }

        public bool checkownerowner(TextBox tbpoid, TextBox tbponame, TextBox tbposurname, MaskedTextBox mtbpophone, TextBox tbpoemail, TextBox tbpocarid, TextBox tbpocountry, TextBox tbpocity, TextBox tb3, TextBox tb4, ComboBox cb, TextBox tb3m, TextBox tb4m)
        {
           if (checktable.checkownerowner(tbpoid, tbponame, tbposurname, mtbpophone, tbpoemail, tbpocarid, tbpocountry, tbpocity, tb3, tb4, cb, tb3m,  tb4m) == true) 
                return true;
            else return false;
        }

        public void addclientclient(TextBox tbclientid, TextBox tbname, TextBox tbsurname, TextBox tbpassport, MaskedTextBox tbphone, CheckBox cbdl, DateTimePicker dtpclientbirthday)
        {
            bll.selectcountblclient();
            string query = File.ReadAllText("query");
           // dbc.countstrdatabase(query, tbclientid);
            dbc.countstrdatabase(query, tbclientid);
            if (checktable.checktableclient(tbname, tbsurname, tbpassport, tbphone) == true)
            {
                string str = tbclientid.Text + ",'" + tbname.Text + "','" + tbsurname.Text + "','" + tbpassport.Text + "','" + tbphone.Text + "','" + cbdl.Checked.ToString() + "','" + dtpclientbirthday.Value.ToString("yyyy-MM-dd") + "'";
                gsstring.strings = str;
                bll.insertclient(gsstring.strings);
                string _query = File.ReadAllText("query");
                //dbc.insert(_query);
                dbc.insertclient(_query);
            }
            else MessageBox.Show("Error");
        }
    }
}
