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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Checkpassword checkpassword = new Checkpassword();
       // openformcontrol ofc = new openformcontrol();

        private void btnadminok_Click(object sender, EventArgs e)
        {
            if (checkpassword.checkpassword(tbpassswdadmin) == true)
            {
               // ofc.f1show();
                Form1 f1 = new Form1();
                f1.Show();
                    this.Visible = false;
            }
        }

        private void exitf2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
