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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        registration reg = new registration();
        //openformcontrol ofc = new openformcontrol();

        private void btncpook_Click(object sender, EventArgs e)
        {
            if (reg.checkcorpo(cbcporeg, cbclient, cbpo) == true)
            {
                if (reg.regestration(textBox1, textBox2, maskedTextBox1) == true)
                {
                    reg.stringtofile(maskedTextBox1, textBox1, cbclient, cbpo);
                    this.Visible = false;
                }
            }
            else if (reg.ischeckcpo(cbclient, cbpo) == true)
                {
                    if (cbclient.Checked == true)
                    {
                        if (reg.checkpasswordandphone(cbclient, cbpo, maskedTextBox1, textBox1) == true)
                        {
                            //ofc.f6show();
                            Form6 f6 = new Form6();
                            f6.Show();
                            this.Visible = false;
                        }
                        else MessageBox.Show("No correct insert data");
                    }
                    if (cbpo.Checked == true)
                    {
                        if (reg.checkpasswordandphone(cbclient, cbpo, maskedTextBox1, textBox1) == true)
                        {
                           // ofc.f7show();
                            Form7 f7 = new Form7();
                            f7.Show();
                            this.Visible = false;
                        }
                        else MessageBox.Show("No correct insert data");
                    }
                }
           else if (reg.ischeckcpo(cbclient, cbpo) == false)
                 MessageBox.Show("Choose client or owner");
            else MessageBox.Show("Error");
        }

        private void cbcporeg_CheckedChanged(object sender, EventArgs e)
        {
            reg.checkboxchecked(cbcporeg, label3, textBox2);
        }

        private void cbpo_CheckedChanged(object sender, EventArgs e)
        {
            reg.checkboxcheckedcpo(cbclient, cbpo);
        }

        private void cbclient_CheckedChanged(object sender, EventArgs e)
        {
            reg.checkboxcheckedcpo(cbclient, cbpo);
        }
    }
}
