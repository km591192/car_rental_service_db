namespace Carrent
{
    partial class Form2
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
            this.tbpassswdadmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadminok = new System.Windows.Forms.Button();
            this.exitf2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbpassswdadmin
            // 
            this.tbpassswdadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpassswdadmin.Location = new System.Drawing.Point(33, 84);
            this.tbpassswdadmin.Margin = new System.Windows.Forms.Padding(5);
            this.tbpassswdadmin.Name = "tbpassswdadmin";
            this.tbpassswdadmin.PasswordChar = '*';
            this.tbpassswdadmin.Size = new System.Drawing.Size(200, 30);
            this.tbpassswdadmin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter password for admin";
            // 
            // btnadminok
            // 
            this.btnadminok.Location = new System.Drawing.Point(88, 122);
            this.btnadminok.Name = "btnadminok";
            this.btnadminok.Size = new System.Drawing.Size(75, 23);
            this.btnadminok.TabIndex = 2;
            this.btnadminok.Text = "Ok";
            this.btnadminok.UseVisualStyleBackColor = true;
            this.btnadminok.Click += new System.EventHandler(this.btnadminok_Click);
            // 
            // exitf2
            // 
            this.exitf2.BackColor = System.Drawing.Color.Ivory;
            this.exitf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitf2.ForeColor = System.Drawing.Color.Red;
            this.exitf2.Location = new System.Drawing.Point(234, -4);
            this.exitf2.Name = "exitf2";
            this.exitf2.Size = new System.Drawing.Size(40, 33);
            this.exitf2.TabIndex = 17;
            this.exitf2.Text = "X";
            this.exitf2.UseVisualStyleBackColor = false;
            this.exitf2.Click += new System.EventHandler(this.exitf2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 203);
            this.Controls.Add(this.exitf2);
            this.Controls.Add(this.btnadminok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpassswdadmin);
            this.Name = "Form2";
            this.Text = "Welcome to car rent sertvice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbpassswdadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadminok;
        private System.Windows.Forms.Button exitf2;
    }
}