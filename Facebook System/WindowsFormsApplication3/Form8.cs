using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace WindowsFormsApplication3
{
    public partial class Form8 : Form
    {
        Thread mostafa;
        private void homee(object obj)
        {
            Application.Run(new Form7());
        }
        private void brow(object obj)
        {
            Application.Run(new profile());
        }
        private void groupe(object obj)
        {
            Application.Run(new Form3());
        }
        private void outt(object obj)
        {
            Application.Run(new home());
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand cmd;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = @"SELECT Count(*)From Registration WHERE email=@email";
                cnn.Open();
                SqlCommand m;
            m = new SqlCommand(s, cnn);
            m.Parameters.Add(new SqlParameter("@email", textBox2.Text));
            int UserExist = (int)m.ExecuteScalar();
            if (UserExist > 0 )
            {
               cmd = new SqlCommand("Deletee Fake Account", cnn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", textBox2.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Account Deleted");

            }
            else
            {

                MessageBox.Show("This Account Not Found");
            }

            cnn.Close();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            string s = @"SELECT Count(*)From Groupfacebook WHERE email=@email and Block_acc=@email";
            string f = @"SELECT Count(*)From Groupfacebook WHERE email=@email ";


                       cnn.Open();
            SqlCommand  m,z;
            m = new SqlCommand(f, cnn);
            z = new SqlCommand(s, cnn);

            m.Parameters.Add(new SqlParameter("@email", textBox1.Text));
            z.Parameters.Add(new SqlParameter("@email", textBox1.Text));

            int UserExist = (int)m.ExecuteScalar();
            int UserExist_blocked = (int)z.ExecuteScalar();
            if(UserExist>0&& UserExist_blocked>0)
            {
               
                MessageBox.Show("Already Blocked");
            }

            else if (UserExist > 0)
            {
                cmd = new SqlCommand("Block_ACOUNT", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", textBox1.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("The Account Blocked");

            }
            else
            {

                MessageBox.Show("This Account Not Found");
            }





            cnn.Close();
        }

        
        private void label2_VisibleChanged(object sender, EventArgs e)
        {
            label2.Text = Globals.FN;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(homee);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(brow);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(groupe);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(outt);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }
    }
}
