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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            string strid = File.ReadAllText("num");
            tbownerpoid.Text = strid;
            tbownerpoid.Text = strid;
        }

        Controler control = new Controler();
       // openformcontrol ofc = new openformcontrol();

        private void button5_Click(object sender, EventArgs e)
        {
            // Environment.Exit(0);
            //ofc.f2show();
            Form2 f2 = new Form2();
            f2.Show();
            this.Visible = false;
        }

        private void btnownermorecarstatistic_Click(object sender, EventArgs e)
        {
            control.showownermorecarstatistic(dgvowner, tbownerpoid);
        }

        private void btnownercarstatistic_Click(object sender, EventArgs e)
        {
            control.showownercarstatistic(dgvowner, tbownerpoid);
        }

        private void btnowneraccident_Click(object sender, EventArgs e)
        {
            control.showownercaraccidentstatistic(dgvowner, tbownerpoid);
        }

        private void btnownermyclients_Click(object sender, EventArgs e)
        {
            control.showownermyclient(dgvowner, tbownerpoid);
        }
    }
}
