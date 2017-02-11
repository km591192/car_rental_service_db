namespace Carrent
{
    partial class Form7
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
            this.button5 = new System.Windows.Forms.Button();
            this.tbownerpoid = new System.Windows.Forms.TextBox();
            this.dgvowner = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.btnownercarstatistic = new System.Windows.Forms.Button();
            this.btnownermorecarstatistic = new System.Windows.Forms.Button();
            this.btnowneraccident = new System.Windows.Forms.Button();
            this.btnownermyclients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvowner)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Ivory;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(531, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 33);
            this.button5.TabIndex = 19;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbownerpoid
            // 
            this.tbownerpoid.Location = new System.Drawing.Point(531, 56);
            this.tbownerpoid.Name = "tbownerpoid";
            this.tbownerpoid.ReadOnly = true;
            this.tbownerpoid.Size = new System.Drawing.Size(28, 20);
            this.tbownerpoid.TabIndex = 18;
            // 
            // dgvowner
            // 
            this.dgvowner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvowner.Location = new System.Drawing.Point(3, 2);
            this.dgvowner.Name = "dgvowner";
            this.dgvowner.Size = new System.Drawing.Size(522, 185);
            this.dgvowner.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(531, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "id";
            // 
            // btnownercarstatistic
            // 
            this.btnownercarstatistic.Location = new System.Drawing.Point(13, 206);
            this.btnownercarstatistic.Name = "btnownercarstatistic";
            this.btnownercarstatistic.Size = new System.Drawing.Size(75, 23);
            this.btnownercarstatistic.TabIndex = 21;
            this.btnownercarstatistic.Text = "Car statistic";
            this.btnownercarstatistic.UseVisualStyleBackColor = true;
            this.btnownercarstatistic.Click += new System.EventHandler(this.btnownercarstatistic_Click);
            // 
            // btnownermorecarstatistic
            // 
            this.btnownermorecarstatistic.Location = new System.Drawing.Point(105, 206);
            this.btnownermorecarstatistic.Name = "btnownermorecarstatistic";
            this.btnownermorecarstatistic.Size = new System.Drawing.Size(100, 23);
            this.btnownermorecarstatistic.TabIndex = 22;
            this.btnownermorecarstatistic.Text = "Car statistic(more)";
            this.btnownermorecarstatistic.UseVisualStyleBackColor = true;
            this.btnownermorecarstatistic.Click += new System.EventHandler(this.btnownermorecarstatistic_Click);
            // 
            // btnowneraccident
            // 
            this.btnowneraccident.Location = new System.Drawing.Point(224, 206);
            this.btnowneraccident.Name = "btnowneraccident";
            this.btnowneraccident.Size = new System.Drawing.Size(113, 23);
            this.btnowneraccident.TabIndex = 23;
            this.btnowneraccident.Text = "Accident with my car";
            this.btnowneraccident.UseVisualStyleBackColor = true;
            this.btnowneraccident.Click += new System.EventHandler(this.btnowneraccident_Click);
            // 
            // btnownermyclients
            // 
            this.btnownermyclients.Location = new System.Drawing.Point(344, 206);
            this.btnownermyclients.Name = "btnownermyclients";
            this.btnownermyclients.Size = new System.Drawing.Size(75, 23);
            this.btnownermyclients.TabIndex = 24;
            this.btnownermyclients.Text = "My clients";
            this.btnownermyclients.UseVisualStyleBackColor = true;
            this.btnownermyclients.Click += new System.EventHandler(this.btnownermyclients_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 323);
            this.Controls.Add(this.btnownermyclients);
            this.Controls.Add(this.btnowneraccident);
            this.Controls.Add(this.btnownermorecarstatistic);
            this.Controls.Add(this.btnownercarstatistic);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbownerpoid);
            this.Controls.Add(this.dgvowner);
            this.Name = "Form7";
            this.Text = "Owner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvowner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbownerpoid;
        private System.Windows.Forms.DataGridView dgvowner;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnownercarstatistic;
        private System.Windows.Forms.Button btnownermorecarstatistic;
        private System.Windows.Forms.Button btnowneraccident;
        private System.Windows.Forms.Button btnownermyclients;
    }
}