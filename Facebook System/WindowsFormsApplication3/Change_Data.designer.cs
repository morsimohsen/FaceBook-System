namespace WindowsFormsApplication3
{
    partial class Change_Data
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UFN = new System.Windows.Forms.TextBox();
            this.ULN = new System.Windows.Forms.TextBox();
            this.LP = new System.Windows.Forms.TextBox();
            this.NP = new System.Windows.Forms.TextBox();
            this.CNP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.savename = new System.Windows.Forms.Button();
            this.savepass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adjective Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repetition Password:";
            // 
            // UFN
            // 
            this.UFN.Location = new System.Drawing.Point(128, 72);
            this.UFN.Name = "UFN";
            this.UFN.Size = new System.Drawing.Size(244, 20);
            this.UFN.TabIndex = 5;
            this.UFN.TextChanged += new System.EventHandler(this.UFN_TextChanged);
            // 
            // ULN
            // 
            this.ULN.Location = new System.Drawing.Point(128, 106);
            this.ULN.Name = "ULN";
            this.ULN.Size = new System.Drawing.Size(244, 20);
            this.ULN.TabIndex = 6;
            // 
            // LP
            // 
            this.LP.Location = new System.Drawing.Point(189, 251);
            this.LP.Name = "LP";
            this.LP.PasswordChar = '*';
            this.LP.Size = new System.Drawing.Size(244, 20);
            this.LP.TabIndex = 7;
            this.LP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // NP
            // 
            this.NP.Location = new System.Drawing.Point(191, 292);
            this.NP.Name = "NP";
            this.NP.PasswordChar = '*';
            this.NP.Size = new System.Drawing.Size(244, 20);
            this.NP.TabIndex = 8;
            // 
            // CNP
            // 
            this.CNP.Location = new System.Drawing.Point(191, 332);
            this.CNP.Name = "CNP";
            this.CNP.PasswordChar = '*';
            this.CNP.Size = new System.Drawing.Size(244, 20);
            this.CNP.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(35, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Change Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Change Password";
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(128, 147);
            this.CP.Name = "CP";
            this.CP.PasswordChar = '*';
            this.CP.Size = new System.Drawing.Size(244, 20);
            this.CP.TabIndex = 14;
            this.CP.TextChanged += new System.EventHandler(this.CP_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password:";
            // 
            // savename
            // 
            this.savename.BackColor = System.Drawing.SystemColors.Highlight;
            this.savename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savename.Location = new System.Drawing.Point(460, 148);
            this.savename.Name = "savename";
            this.savename.Size = new System.Drawing.Size(75, 23);
            this.savename.TabIndex = 15;
            this.savename.Text = "Save";
            this.savename.UseVisualStyleBackColor = false;
            this.savename.Click += new System.EventHandler(this.savename_Click);
            // 
            // savepass
            // 
            this.savepass.BackColor = System.Drawing.Color.DarkRed;
            this.savepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.savepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savepass.Location = new System.Drawing.Point(460, 332);
            this.savepass.Name = "savepass";
            this.savepass.Size = new System.Drawing.Size(75, 23);
            this.savepass.TabIndex = 16;
            this.savepass.Text = "Save";
            this.savepass.UseVisualStyleBackColor = false;
            this.savepass.Click += new System.EventHandler(this.savepass_Click);
            // 
            // Change_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 398);
            this.Controls.Add(this.savepass);
            this.Controls.Add(this.savename);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.NP);
            this.Controls.Add(this.LP);
            this.Controls.Add(this.ULN);
            this.Controls.Add(this.UFN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change_Data";
            this.Text = "Change_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UFN;
        private System.Windows.Forms.TextBox ULN;
        private System.Windows.Forms.TextBox LP;
        private System.Windows.Forms.TextBox NP;
        private System.Windows.Forms.TextBox CNP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button savename;
        private System.Windows.Forms.Button savepass;
    }
}