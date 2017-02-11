namespace Carrent
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbownerpoemail = new System.Windows.Forms.TextBox();
            this.btnpoclear = new System.Windows.Forms.Button();
            this.btnpoadd = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tbownerpocity = new System.Windows.Forms.TextBox();
            this.tbownerpocountry = new System.Windows.Forms.TextBox();
            this.tbownerpocarid = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.mtbownerpophone = new System.Windows.Forms.MaskedTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tbownerponame = new System.Windows.Forms.TextBox();
            this.tbownerposurname = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbownerpoid = new System.Windows.Forms.TextBox();
            this.tbownercnumber = new System.Windows.Forms.TextBox();
            this.tbownerccolor = new System.Windows.Forms.TextBox();
            this.tbownercmid = new System.Windows.Forms.TextBox();
            this.tbownercid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbownermmarka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbownermmodel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbownermclass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbownermid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbownerpoemail
            // 
            this.tbownerpoemail.Location = new System.Drawing.Point(290, 23);
            this.tbownerpoemail.Name = "tbownerpoemail";
            this.tbownerpoemail.Size = new System.Drawing.Size(87, 20);
            this.tbownerpoemail.TabIndex = 65;
            // 
            // btnpoclear
            // 
            this.btnpoclear.Location = new System.Drawing.Point(536, 75);
            this.btnpoclear.Name = "btnpoclear";
            this.btnpoclear.Size = new System.Drawing.Size(39, 23);
            this.btnpoclear.TabIndex = 64;
            this.btnpoclear.Text = "Clear";
            this.btnpoclear.UseVisualStyleBackColor = true;
            this.btnpoclear.Click += new System.EventHandler(this.btnpoclear_Click);
            // 
            // btnpoadd
            // 
            this.btnpoadd.Location = new System.Drawing.Point(491, 75);
            this.btnpoadd.Name = "btnpoadd";
            this.btnpoadd.Size = new System.Drawing.Size(39, 23);
            this.btnpoadd.TabIndex = 63;
            this.btnpoadd.Text = "Add";
            this.btnpoadd.UseVisualStyleBackColor = true;
            this.btnpoadd.Click += new System.EventHandler(this.btnpoadd_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(517, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 13);
            this.label36.TabIndex = 62;
            this.label36.Text = "city";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(429, 9);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 13);
            this.label37.TabIndex = 61;
            this.label37.Text = "country";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(383, 10);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(33, 13);
            this.label35.TabIndex = 60;
            this.label35.Text = "car id";
            // 
            // tbownerpocity
            // 
            this.tbownerpocity.Location = new System.Drawing.Point(500, 25);
            this.tbownerpocity.Name = "tbownerpocity";
            this.tbownerpocity.Size = new System.Drawing.Size(73, 20);
            this.tbownerpocity.TabIndex = 59;
            // 
            // tbownerpocountry
            // 
            this.tbownerpocountry.Location = new System.Drawing.Point(421, 26);
            this.tbownerpocountry.Name = "tbownerpocountry";
            this.tbownerpocountry.Size = new System.Drawing.Size(73, 20);
            this.tbownerpocountry.TabIndex = 58;
            // 
            // tbownerpocarid
            // 
            this.tbownerpocarid.Location = new System.Drawing.Point(383, 25);
            this.tbownerpocarid.Name = "tbownerpocarid";
            this.tbownerpocarid.ReadOnly = true;
            this.tbownerpocarid.Size = new System.Drawing.Size(32, 20);
            this.tbownerpocarid.TabIndex = 57;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(314, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 13);
            this.label34.TabIndex = 56;
            this.label34.Text = "e-mail";
            // 
            // mtbownerpophone
            // 
            this.mtbownerpophone.Location = new System.Drawing.Point(197, 25);
            this.mtbownerpophone.Mask = "+999000000000";
            this.mtbownerpophone.Name = "mtbownerpophone";
            this.mtbownerpophone.Size = new System.Drawing.Size(87, 20);
            this.mtbownerpophone.TabIndex = 55;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(209, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(75, 13);
            this.label31.TabIndex = 54;
            this.label31.Text = "phone number";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(135, 10);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 13);
            this.label32.TabIndex = 53;
            this.label32.Text = "surname";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(70, 10);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(33, 13);
            this.label33.TabIndex = 52;
            this.label33.Text = "name";
            // 
            // tbownerponame
            // 
            this.tbownerponame.Location = new System.Drawing.Point(42, 25);
            this.tbownerponame.Name = "tbownerponame";
            this.tbownerponame.Size = new System.Drawing.Size(73, 20);
            this.tbownerponame.TabIndex = 51;
            // 
            // tbownerposurname
            // 
            this.tbownerposurname.Location = new System.Drawing.Point(118, 26);
            this.tbownerposurname.Name = "tbownerposurname";
            this.tbownerposurname.Size = new System.Drawing.Size(73, 20);
            this.tbownerposurname.TabIndex = 50;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(15, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 13);
            this.label29.TabIndex = 49;
            this.label29.Text = "id";
            // 
            // tbownerpoid
            // 
            this.tbownerpoid.Location = new System.Drawing.Point(11, 25);
            this.tbownerpoid.Name = "tbownerpoid";
            this.tbownerpoid.ReadOnly = true;
            this.tbownerpoid.Size = new System.Drawing.Size(28, 20);
            this.tbownerpoid.TabIndex = 48;
            // 
            // tbownercnumber
            // 
            this.tbownercnumber.Location = new System.Drawing.Point(171, 78);
            this.tbownercnumber.Name = "tbownercnumber";
            this.tbownercnumber.Size = new System.Drawing.Size(63, 20);
            this.tbownercnumber.TabIndex = 73;
            // 
            // tbownerccolor
            // 
            this.tbownerccolor.Location = new System.Drawing.Point(102, 78);
            this.tbownerccolor.Name = "tbownerccolor";
            this.tbownerccolor.Size = new System.Drawing.Size(62, 20);
            this.tbownerccolor.TabIndex = 72;
            // 
            // tbownercmid
            // 
            this.tbownercmid.Location = new System.Drawing.Point(59, 79);
            this.tbownercmid.Name = "tbownercmid";
            this.tbownercmid.ReadOnly = true;
            this.tbownercmid.Size = new System.Drawing.Size(37, 20);
            this.tbownercmid.TabIndex = 71;
            // 
            // tbownercid
            // 
            this.tbownercid.Location = new System.Drawing.Point(18, 79);
            this.tbownercid.Name = "tbownercid";
            this.tbownercid.ReadOnly = true;
            this.tbownercid.Size = new System.Drawing.Size(34, 20);
            this.tbownercid.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "reg num";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "color";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Id model";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Id car";
            // 
            // tbownermmarka
            // 
            this.tbownermmarka.Location = new System.Drawing.Point(420, 78);
            this.tbownermmarka.Name = "tbownermmarka";
            this.tbownermmarka.Size = new System.Drawing.Size(51, 20);
            this.tbownermmarka.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "car marka";
            // 
            // tbownermmodel
            // 
            this.tbownermmodel.Location = new System.Drawing.Point(361, 80);
            this.tbownermmodel.Name = "tbownermmodel";
            this.tbownermmodel.Size = new System.Drawing.Size(53, 20);
            this.tbownermmodel.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "car model";
            // 
            // cbownermclass
            // 
            this.cbownermclass.FormattingEnabled = true;
            this.cbownermclass.Items.AddRange(new object[] {
            "econom",
            "standart",
            "luxery"});
            this.cbownermclass.Location = new System.Drawing.Point(296, 79);
            this.cbownermclass.Name = "cbownermclass";
            this.cbownermclass.Size = new System.Drawing.Size(59, 21);
            this.cbownermclass.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "car class";
            // 
            // tbownermid
            // 
            this.tbownermid.Location = new System.Drawing.Point(257, 79);
            this.tbownermid.Name = "tbownermid";
            this.tbownermid.ReadOnly = true;
            this.tbownermid.Size = new System.Drawing.Size(32, 20);
            this.tbownermid.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Id model";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 119);
            this.Controls.Add(this.tbownermmarka);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbownermmodel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbownermclass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbownermid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbownercnumber);
            this.Controls.Add(this.tbownerccolor);
            this.Controls.Add(this.tbownercmid);
            this.Controls.Add(this.tbownercid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbownerpoemail);
            this.Controls.Add(this.btnpoclear);
            this.Controls.Add(this.btnpoadd);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.tbownerpocity);
            this.Controls.Add(this.tbownerpocountry);
            this.Controls.Add(this.tbownerpocarid);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.mtbownerpophone);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tbownerponame);
            this.Controls.Add(this.tbownerposurname);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.tbownerpoid);
            this.Name = "Form5";
            this.Text = "Owner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbownerpoemail;
        private System.Windows.Forms.Button btnpoclear;
        private System.Windows.Forms.Button btnpoadd;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbownerpocity;
        private System.Windows.Forms.TextBox tbownerpocountry;
        private System.Windows.Forms.TextBox tbownerpocarid;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.MaskedTextBox mtbownerpophone;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbownerponame;
        private System.Windows.Forms.TextBox tbownerposurname;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbownerpoid;
        private System.Windows.Forms.TextBox tbownercnumber;
        private System.Windows.Forms.TextBox tbownerccolor;
        private System.Windows.Forms.TextBox tbownercmid;
        private System.Windows.Forms.TextBox tbownercid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbownermmarka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbownermmodel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbownermclass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbownermid;
        private System.Windows.Forms.Label label7;
    }
}