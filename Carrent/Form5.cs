using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carrent
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            Controler control = new Controler();
            control.setowner(tbownerpoid, tbownerpocarid, tbownercid, tbownercmid, tbownermid);
        }

        Controler control = new Controler();
        //openformcontrol ofc = new openformcontrol();

        private void btnpoadd_Click(object sender, EventArgs e)
        {
            if (control.checkownerowner(tbownerpoid, tbownerponame, tbownerposurname, mtbownerpophone, tbownerpoemail, tbownerpocarid, tbownerpocountry, tbownerpocity, tbownerccolor, tbownercnumber, cbownermclass, tbownermmodel, tbownermmarka) == true)
            {
                control.addownermodel(tbownermid, cbownermclass, tbownermmodel, tbownermmarka);
                control.addownercar(tbownercid, tbownercmid, tbownerccolor, tbownercnumber);
                control.addownerpo(tbownerpoid, tbownerponame, tbownerposurname, mtbownerpophone, tbownerpoemail, tbownerpocarid, tbownerpocountry, tbownerpocity);
                // ofc.f7show();
                Form7 f7 = new Form7();
                f7.Show();
                this.Visible = false;
            }
            else MessageBox.Show("Error");
        }

        private void btnpoclear_Click(object sender, EventArgs e)
        {
            control.clearpo(tbownerpoid, tbownerponame, tbownerposurname, tbownerpoemail, tbownerpocarid, tbownerpocountry, tbownerpocity, mtbownerpophone);
            control.clearmodel(tbownermid, tbownermmodel, tbownermmarka, cbownermclass);
            control.clearcar(tbownercid,tbownercmid, tbownercnumber, tbownerccolor);
        }

     
    }
}
