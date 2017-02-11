using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;

namespace Carrent
{
    public partial class Form1 : Form
    {

        Controler control = new Controler();
        //openformcontrol ofc = new openformcontrol();


        public Form1()
        {
            InitializeComponent();

            control.initialization(dtpaenddate, dtpaaccidentdate);
            control.initialization(dtplastart, dtplaend);
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
           // ofc.f3show();
            Form3 f3 = new Form3();
            f3.Show();
            this.Visible = false;
        }

        private void btnowner_Click(object sender, EventArgs e)
        {
            //ofc.f3show();
            Form3 f3 = new Form3();
            f3.Show();
            this.Visible = false;
        }

        private void btncarsshow_Click(object sender, EventArgs e)
        {
            control.showcars(dgvcars);
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            control.showmodels(dgvmodel);
        }

        private void btnla_Click(object sender, EventArgs e)
        {
            control.showla(dgvla);
        }

        private void btna_Click(object sender, EventArgs e)
        {
            control.showa(dgva);
        }

        private void btnshowpo_Click(object sender, EventArgs e)
        {
            control.showpo(dgvpo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.showallcarinfo(dgvuser,button1);
        }

        private void btnpopcar_Click(object sender, EventArgs e)
        {
            control.showallpopcar(dgvcars, btnpopcar);
        }

        private void btnaadd_Click(object sender, EventArgs e)
        {
            control.addaccident(tba1, tba2, dtpaenddate, dtpaaccidentdate, tba5, tba6);
        }

        private void btnmodeladd_Click(object sender, EventArgs e)
        {
            control.addmodel(tbmid, cbmclass, tbmmodel, tbmmarka);
        }

        private void button2_Click(object sender, EventArgs e) //Clear accident
        {
            control.clearaccident(tba1, tba2, tba5, tba6);
        }

        private void btnclearm_Click(object sender, EventArgs e)
        {
            control.clearmodel(tbmid, tbmmarka, tbmmodel,cbmclass);
        }

        private void btncclear_Click(object sender, EventArgs e)
        {
            control.clearcar(tbcid, tbcmid, tbccolor, tbccolor);
        }

        private void btncadd_Click(object sender, EventArgs e)
        {
            control.addcar(tbcid, tbcmid, tbccolor, tbcnumber);
        }

        private void btnfreecars_Click(object sender, EventArgs e)
        {
            control.showfreecars(dgvcars);
        }

        private void btnlaclear_Click(object sender, EventArgs e)
        {
            control.clearla(tblaid, tblaclientid, tblacarid, tblaprice, tblacountry, tblacity);
        }

        private void btnlaadd_Click(object sender, EventArgs e)
        {
            control.addla(tblaid, dtplastart, dtplaend, tblaclientid, tblacarid, tblaprice, tblacountry, tblacity);
        }

        private void btnshowclients_Click(object sender, EventArgs e)
        {
            control.showclient(dgvuser);
        }

        private void btnownersshowclients_Click(object sender, EventArgs e)
        {
            control.showclient(dgvpo);
        }

        private void btnclientshowowners_Click(object sender, EventArgs e)
        {
            control.showpo(dgvuser);
        }

        private void btnclientadd_Click(object sender, EventArgs e)
        {
            control.addclient(tbclientid, tbclientname, tbclientsurname, tbclientpassport, mtbclientphone, cbdrivelicense, dtpclientbirth);
        }

        private void btnclientclear_Click(object sender, EventArgs e)
        {
            control.clearclient(tbclientname, tbclientsurname, tbclientpassport, mtbclientphone);
        }

        private void btnpoclear_Click(object sender, EventArgs e)
        {
            control.clearpo(tbpoid, tbponame, tbposurname, tbpoemail, tbpocarid, tbpocountry, tbpocity, mtbpophone);
        }

        private void btnpoadd_Click(object sender, EventArgs e)
        {
            control.addpo(tbpoid, tbponame, tbposurname, mtbpophone, tbpoemail, tbpocarid, tbpocountry, tbpocity);
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            //ofc.f2show();
            Form2 f2 = new Form2();
            f2.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnlarecomendedprice_Click(object sender, EventArgs e)
        {
            control.recomendedprice(tblacarid, dtplastart, dtplaend);
        } 
    }
}
