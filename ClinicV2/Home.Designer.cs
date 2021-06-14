namespace ClinicV2
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelLabHome = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelMedicineHome = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labeltotalCustomer = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDate.Location = new System.Drawing.Point(25, 128);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(232, 28);
            this.labelDate.TabIndex = 44;
            this.labelDate.Text = "Date: May 25, 2021";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTime.Location = new System.Drawing.Point(25, 93);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(181, 28);
            this.labelTime.TabIndex = 28;
            this.labelTime.Text = "Time: 12:00 PM";
            // 
            // labelLabHome
            // 
            this.labelLabHome.AutoSize = true;
            this.labelLabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(194)))), ((int)(((byte)(112)))));
            this.labelLabHome.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.labelLabHome.ForeColor = System.Drawing.Color.White;
            this.labelLabHome.Location = new System.Drawing.Point(266, 367);
            this.labelLabHome.Name = "labelLabHome";
            this.labelLabHome.Size = new System.Drawing.Size(122, 40);
            this.labelLabHome.TabIndex = 43;
            this.labelLabHome.Text = "23,000";
            this.labelLabHome.Click += new System.EventHandler(this.labelLabHome_Click);
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(194)))), ((int)(((byte)(112)))));
            this.labelGrandTotal.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.labelGrandTotal.ForeColor = System.Drawing.Color.White;
            this.labelGrandTotal.Location = new System.Drawing.Point(480, 367);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(141, 40);
            this.labelGrandTotal.TabIndex = 41;
            this.labelGrandTotal.Text = "500,000";
            this.labelGrandTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelMedicineHome
            // 
            this.labelMedicineHome.AutoSize = true;
            this.labelMedicineHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(194)))), ((int)(((byte)(112)))));
            this.labelMedicineHome.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.labelMedicineHome.ForeColor = System.Drawing.Color.White;
            this.labelMedicineHome.Location = new System.Drawing.Point(79, 367);
            this.labelMedicineHome.Name = "labelMedicineHome";
            this.labelMedicineHome.Size = new System.Drawing.Size(74, 40);
            this.labelMedicineHome.TabIndex = 40;
            this.labelMedicineHome.Text = "300";
            this.labelMedicineHome.Click += new System.EventHandler(this.labelMedicineHome_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(194)))), ((int)(((byte)(112)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(12, 284);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.button13.Size = new System.Drawing.Size(211, 222);
            this.button13.TabIndex = 39;
            this.button13.Text = "Total Medicine";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(194)))), ((int)(((byte)(112)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(229, 284);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.button11.Size = new System.Drawing.Size(211, 222);
            this.button11.TabIndex = 37;
            this.button11.Text = "Total Lab";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(194)))), ((int)(((byte)(112)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(446, 284);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.button14.Size = new System.Drawing.Size(211, 222);
            this.button14.TabIndex = 36;
            this.button14.Text = "Grand Total";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 38F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(20, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(613, 60);
            this.label5.TabIndex = 29;
            this.label5.Text = "Welcome to Dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(212)))), ((int)(((byte)(174)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(399, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "PHP. 13,000";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labeltotalCustomer
            // 
            this.labeltotalCustomer.AutoSize = true;
            this.labeltotalCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(182)))), ((int)(((byte)(164)))));
            this.labeltotalCustomer.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.labeltotalCustomer.ForeColor = System.Drawing.Color.White;
            this.labeltotalCustomer.Location = new System.Drawing.Point(132, 192);
            this.labeltotalCustomer.Name = "labeltotalCustomer";
            this.labeltotalCustomer.Size = new System.Drawing.Size(45, 32);
            this.labeltotalCustomer.TabIndex = 34;
            this.labeltotalCustomer.Text = "15";
            this.labeltotalCustomer.Click += new System.EventHandler(this.label3_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(182)))), ((int)(((byte)(164)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(12, 176);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.button10.Size = new System.Drawing.Size(295, 102);
            this.button10.TabIndex = 32;
            this.button10.Text = "REGULAR PATIENTS";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(212)))), ((int)(((byte)(174)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(313, 176);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.button9.Size = new System.Drawing.Size(344, 102);
            this.button9.TabIndex = 31;
            this.button9.Text = "TOTAL SALES TODAY";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelLabHome);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelMedicineHome);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeltotalCustomer);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1079, 650);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelLabHome;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelMedicineHome;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labeltotalCustomer;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
    }
}
