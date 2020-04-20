using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication3
{
    
    public partial class home : Form

    {
        Thread mostafa;
        private void logain(object obj)
        {
            Application.Run(new profile());
        }
        private void logainadmin(object obj)
        {
            Application.Run(new Form7());
        }
        private bool SetButton()
        {

            return button3.Enabled = (fn.Text != "First name" && ln.Text != "Last name" && gender.Text != "Gender" && cn.Text != "Country" && em.Text != "New Email" && pass.Text != "Password");

        }
        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand cmd;
        public home()
        {
  
            InitializeComponent();
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (SetButton() == true)
            {

                try
                {
                    cmd = new SqlCommand("sign_up", cnn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@fname", fn.Text);
                    cmd.Parameters.AddWithValue("@lmane", ln.Text);
                    cmd.Parameters.AddWithValue("@birthday", br.Value);
                    cmd.Parameters.AddWithValue("@gender", gender.Text);
                    cmd.Parameters.AddWithValue("@country", cn.Text);
                    cmd.Parameters.AddWithValue("@pass", pass.Text);

                    cmd.Parameters.Add(new SqlParameter("@mail", em.Text));
                    cmd.ExecuteNonQuery();
                    Globals.FN = fn.Text+ln.Text;
                    MessageBox.Show("    Welcome " + fn.Text);
                    cnn.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Some Erros was occured " + ex.Message);
                }

            }

            else
            {
                MessageBox.Show("Invalid Information");
            }
            button3.Enabled = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            string s = @"SELECT Count(*)From Registration WHERE email=@username";
            string l = @"SELECT Count(*)From Registration WHERE pass=@pass";
            string FF = @"SELECT first_name From Registration WHERE email=@username";
            string LL = @"SELECT last_name From Registration WHERE email=@username";

            SqlCommand m, z,FFF,LLL;
            m = new SqlCommand(s, cnn);
            z = new SqlCommand(l, cnn);
            FFF = new SqlCommand(FF, cnn);
            LLL = new SqlCommand(LL, cnn);


            cmd = new SqlCommand("checkuser", cnn);
            cmd = new SqlCommand("checkpass", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.Add(new SqlParameter("@username", email.Text));
            cmd.Parameters.Add(new SqlParameter("@pass", password.Text));
            m.Parameters.Add(new SqlParameter("@username", email.Text));
            z.Parameters.Add(new SqlParameter("@pass", password.Text));
            FFF.Parameters.Add(new SqlParameter("@username", email.Text));
            LLL.Parameters.Add(new SqlParameter("@username", email.Text));



            Globals.emails = email.Text;
            Globals.PP = password.Text;


            
            int UserExist = (int)m.ExecuteScalar();
            int UserExistt = (int)z.ExecuteScalar();
            string FFFF =(string) FFF.ExecuteScalar();
            string LLLL = (string)LLL.ExecuteScalar();
            Globals.FN = FFFF+LLLL;

            if (UserExist > 0 && UserExistt > 0)
            {
                if (Globals.emails == "4M")
                {
                    this.Close();
                    mostafa = new Thread(logainadmin);
                    mostafa.SetApartmentState(ApartmentState.STA);
                    mostafa.Start();

                }

                else
                {
                    this.Close();
                    mostafa = new Thread(logain);
                    mostafa.SetApartmentState(ApartmentState.STA);
                    mostafa.Start();
                }
            }
            else
                MessageBox.Show("Account Not Found");

            cnn.Close();

        }
        
        private void fn_Enter(object sender, EventArgs e)
        {
            if (fn.Text == "First name")
            {
                fn.Text = "";
                fn.ForeColor = Color.Black;
            }
        }

        private void fn_Leave(object sender, EventArgs e)
        {
            if (fn.Text == "")
            {
                fn.Text = "First name";
                fn.ForeColor = Color.Silver;
            }
        }

        private void ln_Enter(object sender, EventArgs e)
        {
            if (ln.Text == "Last name")
            {
                ln.Text = "";
                ln.ForeColor = Color.Black;
            }
        }

        private void ln_Leave(object sender, EventArgs e)
        {
            if (ln.Text == "")
            {
                ln.Text = "Last name";
                ln.ForeColor = Color.Silver;
            }
        }

        private void cn_Enter(object sender, EventArgs e)
        {
            if (cn.Text == "Country")
            {
                cn.Text = "";
                cn.ForeColor = Color.Black;
            }

        }

        private void cn_Leave(object sender, EventArgs e)
        {
            if (cn.Text == "")
            {
                cn.Text = "Country";
                cn.ForeColor = Color.Silver;
            }


        }

        private void em_Enter(object sender, EventArgs e)
        {
            if (em.Text == "New Email")
            {
                em.Text = "";
                em.ForeColor = Color.Black;
            }

        }

        private void em_Leave(object sender, EventArgs e)
        {
            if (em.Text == "")
            {
                em.Text = "New Email";
                em.ForeColor = Color.Silver;
            }

        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }

        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Password";
                pass.ForeColor = Color.Silver;
            }
        }

        private void gender_Enter(object sender, EventArgs e)
        {
            if (gender.Text == "Gender")
            {
                gender.Text = "";
                gender.ForeColor = Color.Black;
            }
        }

        private void gender_Leave(object sender, EventArgs e)
        {
            if (gender.Text == "")
            {
                gender.Text = "Gender";
                gender.ForeColor = Color.Silver;
            }
        }
    }
}   
    


