using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Carrent
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Controler controler = new Controler();
            controler.initialization(dtplacdstart, dtplacend);


            string strid = File.ReadAllText("num");
            tbclientid.Text = strid;
            tblaccid.Text = strid;
        }

        Controler control = new Controler();
      //  openformcontrol ofc = new openformcontrol();

        private void button5_Click(object sender, EventArgs e)
        {
           // Environment.Exit(0);
           // ofc.f2show();
            Form2 f2 = new Form2();
            f2.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            control.addlaclient(tblaclaid, dtplacdstart, dtplacend, tblaccid, tblaccarid, tblacprice, tblaccountry, tblaccity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            control.clearla(tblaclaid, tblaccid, tblaccarid, tblacprice, tblaccountry, tblaccity);
        }

        private void btnpopcarclient_Click(object sender, EventArgs e)
        {
           // control.showallfreepopcar(dgvuser, btnpopcarclient);
            control.showallfreepopcarclient(dgvuser, btnpopcarclient);
        }

        private void btnallcarclient_Click(object sender, EventArgs e)
        {
            //control.showallfreecarinfo(dgvuser, btnallcarclient);
            control.showallfreecarinfoclient(dgvuser, btnallcarclient);
        }

        private void btncarincity_Click(object sender, EventArgs e)
        {
            //control.showcarinmycity(dgvuser, tblaccity);
            control.showcarinmycityclient(dgvuser, tblaccity);
        }

        private void btnpopcarinmycity_Click(object sender, EventArgs e)
        {
            //control.showpopcarinmycity(dgvuser, tblaccity);
            control.showpopcarinmycityclient(dgvuser, tblaccity);
        }

        private void btnlacrecomendedprice_Click(object sender, EventArgs e)
        {
            control.recomendedprice(tblaccarid, dtplacdstart, dtplacend);
        }


       
    }
}