namespace Carrent
{
    partial class Form4
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
            this.mtbclientphone = new System.Windows.Forms.MaskedTextBox();
            this.btnclientclear = new System.Windows.Forms.Button();
            this.btnclientadd = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpclientbirth = new System.Windows.Forms.DateTimePicker();
            this.cbdrivelicense = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbclientpassport = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbclientname = new System.Windows.Forms.TextBox();
            this.tbclientsurname = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbclientid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mtbclientphone
            // 
            this.mtbclientphone.Location = new System.Drawing.Point(277, 33);
            this.mtbclientphone.Mask = "+999000000000";
            this.mtbclientphone.Name = "mtbclientphone";
            this.mtbclientphone.Size = new System.Drawing.Size(87, 20);
            this.mtbclientphone.TabIndex = 44;
            // 
            // btnclientclear
            // 
            this.btnclientclear.Location = new System.Drawing.Point(512, 34);
            this.btnclientclear.Name = "btnclientclear";
            this.btnclientclear.Size = new System.Drawing.Size(39, 23);
            this.btnclientclear.TabIndex = 43;
            this.btnclientclear.Text = "Clear";
            this.btnclientclear.UseVisualStyleBackColor = true;
            this.btnclientclear.Click += new System.EventHandler(this.btnclientclear_Click);
            // 
            // btnclientadd
            // 
            this.btnclientadd.Location = new System.Drawing.Point(512, 7);
            this.btnclientadd.Name = "btnclientadd";
            this.btnclientadd.Size = new System.Drawing.Size(39, 23);
            this.btnclientadd.TabIndex = 42;
            this.btnclientadd.Text = "Add";
            this.btnclientadd.UseVisualStyleBackColor = true;
            this.btnclientadd.Click += new System.EventHandler(this.btnclientadd_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(433, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 41;
            this.label28.Text = "date of birth";
            // 
            // dtpclientbirth
            // 
            this.dtpclientbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpclientbirth.Location = new System.Drawing.Point(433, 33);
            this.dtpclientbirth.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpclientbirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpclientbirth.Name = "dtpclientbirth";
            this.dtpclientbirth.Size = new System.Drawing.Size(78, 20);
            this.dtpclientbirth.TabIndex = 40;
            this.dtpclientbirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbdrivelicense
            // 
            this.cbdrivelicense.AutoSize = true;
            this.cbdrivelicense.Checked = true;
            this.cbdrivelicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbdrivelicense.Location = new System.Drawing.Point(368, 27);
            this.cbdrivelicense.Name = "cbdrivelicense";
            this.cbdrivelicense.Size = new System.Drawing.Size(59, 30);
            this.cbdrivelicense.TabIndex = 39;
            this.cbdrivelicense.Text = "Driving\r\nlicense";
            this.cbdrivelicense.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(289, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 13);
            this.label27.TabIndex = 38;
            this.label27.Text = "phone number";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(209, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 13);
            this.label26.TabIndex = 37;
            this.label26.Text = "passport N";
            // 
            // tbclientpassport
            // 
            this.tbclientpassport.Location = new System.Drawing.Point(210, 34);
            this.tbclientpassport.Name = "tbclientpassport";
            this.tbclientpassport.Size = new System.Drawing.Size(57, 20);
            this.tbclientpassport.TabIndex = 36;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(148, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 35;
            this.label25.Text = "surname";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(83, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "name";
            // 
            // tbclientname
            // 
            this.tbclientname.Location = new System.Drawing.Point(55, 33);
            this.tbclientname.Name = "tbclientname";
            this.tbclientname.Size = new System.Drawing.Size(73, 20);
            this.tbclientname.TabIndex = 33;
            // 
            // tbclientsurname
            // 
            this.tbclientsurname.Location = new System.Drawing.Point(131, 34);
            this.tbclientsurname.Name = "tbclientsurname";
            this.tbclientsurname.Size = new System.Drawing.Size(73, 20);
            this.tbclientsurname.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "id";
            // 
            // tbclientid
            // 
            this.tbclientid.Location = new System.Drawing.Point(21, 33);
            this.tbclientid.Name = "tbclientid";
            this.tbclientid.ReadOnly = true;
            this.tbclientid.Size = new System.Drawing.Size(28, 20);
            this.tbclientid.TabIndex = 30;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 100);
            this.Controls.Add(this.mtbclientphone);
            this.Controls.Add(this.btnclientclear);
            this.Controls.Add(this.btnclientadd);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dtpclientbirth);
            this.Controls.Add(this.cbdrivelicense);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tbclientpassport);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tbclientname);
            this.Controls.Add(this.tbclientsurname);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbclientid);
            this.Name = "Form4";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbclientphone;
        private System.Windows.Forms.Button btnclientclear;
        private System.Windows.Forms.Button btnclientadd;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtpclientbirth;
        private System.Windows.Forms.CheckBox cbdrivelicense;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbclientpassport;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbclientname;
        private System.Windows.Forms.TextBox tbclientsurname;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbclientid;
    }
}