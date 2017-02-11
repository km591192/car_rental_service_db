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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Controler control = new Controler();
       // openformcontrol ofc = new openformcontrol();

        private void btnclientadd_Click(object sender, EventArgs e)
        {
          //  control.addclient(tbclientid, tbclientname, tbclientsurname, tbclientpassport, mtbclientphone, cbdrivelicense, dtpclientbirth);
            control.addclientclient(tbclientid, tbclientname, tbclientsurname, tbclientpassport, mtbclientphone, cbdrivelicense, dtpclientbirth);
           // ofc.f6show();
            Form6 f6 = new Form6();
            f6.Show();
            this.Visible = false;
        }

        private void btnclientclear_Click(object sender, EventArgs e)
        {
            control.clearclient(tbclientname, tbclientsurname, tbclientpassport, mtbclientphone);
        }
    }
}
