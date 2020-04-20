namespace WindowsFormsApplication3
{
    partial class home
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.br = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.TextBox();
            this.cn = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.gender);
            this.panel4.Controls.Add(this.br);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.pass);
            this.panel4.Controls.Add(this.fn);
            this.panel4.Controls.Add(this.ln);
            this.panel4.Controls.Add(this.em);
            this.panel4.Controls.Add(this.cn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 556);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(508, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "creat a new acount ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "sign up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gender.Location = new System.Drawing.Point(527, 407);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(222, 21);
            this.gender.TabIndex = 9;
            this.gender.Enter += new System.EventHandler(this.gender_Enter);
            this.gender.Leave += new System.EventHandler(this.gender_Leave);
            // 
            // br
            // 
            this.br.Location = new System.Drawing.Point(538, 454);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(200, 20);
            this.br.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 97);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(874, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(631, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(428, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "email";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(817, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(633, 50);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(160, 23);
            this.password.TabIndex = 2;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(430, 50);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(165, 23);
            this.email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "facebook";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Silver;
            this.pass.Location = new System.Drawing.Point(527, 354);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(222, 23);
            this.pass.TabIndex = 8;
            this.pass.Text = "Password";
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // fn
            // 
            this.fn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.ForeColor = System.Drawing.Color.Silver;
            this.fn.Location = new System.Drawing.Point(527, 186);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(222, 23);
            this.fn.TabIndex = 1;
            this.fn.Text = "First name";
            this.fn.Enter += new System.EventHandler(this.fn_Enter);
            this.fn.Leave += new System.EventHandler(this.fn_Leave);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.SystemColors.Window;
            this.ln.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.ForeColor = System.Drawing.Color.Silver;
            this.ln.Location = new System.Drawing.Point(527, 228);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(222, 23);
            this.ln.TabIndex = 2;
            this.ln.Text = "Last name";
            this.ln.Enter += new System.EventHandler(this.ln_Enter);
            this.ln.Leave += new System.EventHandler(this.ln_Leave);
            // 
            // em
            // 
            this.em.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em.ForeColor = System.Drawing.Color.Silver;
            this.em.Location = new System.Drawing.Point(527, 313);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(222, 23);
            this.em.TabIndex = 5;
            this.em.Text = "New Email";
            this.em.Enter += new System.EventHandler(this.em_Enter);
            this.em.Leave += new System.EventHandler(this.em_Leave);
            // 
            // cn
            // 
            this.cn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn.ForeColor = System.Drawing.Color.Silver;
            this.cn.Location = new System.Drawing.Point(527, 271);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(222, 23);
            this.cn.TabIndex = 3;
            this.cn.Text = "Country";
            this.cn.Enter += new System.EventHandler(this.cn_Enter);
            this.cn.Leave += new System.EventHandler(this.cn_Leave);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 556);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.DateTimePicker br;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox gender;
        public System.Windows.Forms.Panel panel4;
    }
}

