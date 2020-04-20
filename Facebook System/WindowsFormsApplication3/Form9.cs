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
    public partial class Form9 : Form
    {
        Thread mostafa;
        private void homee(object obj)
        {
            Application.Run(new profile());
        }
        private void outt(object obj)
        {
            Application.Run(new home());
        }
        private void groupe(object obj)
        {
            Application.Run(new Form3());
        }
        private void vieww(object obj)
        {
            Application.Run(new Form14());
        }

        private bool SetAdd()
        {
            return button2.Enabled = (textBox1.Text != "" || textBox1.Visible == false);


        }
        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand cmd;
        public Form9()
        {
            InitializeComponent();
        }

        private void Friends_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(groupe);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(homee);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(outt);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            string s = @"SELECT Count(*)From FriendShip WHERE email1=@user1 and email2=@user2";
            string l = @"SELECT Count(*)From Registration WHERE email=@username";
            cnn.Open();
            SqlCommand cmd,m,z;
            m = new SqlCommand(s, cnn);
            z = new SqlCommand(l, cnn);

            m.Parameters.Add(new SqlParameter("@user1", Globals.emails));
            m.Parameters.Add(new SqlParameter("@user2", textBox1.Text));

            z.Parameters.Add(new SqlParameter("@username", textBox1.Text));

            int UserExist = (int)m.ExecuteScalar();
            int UserNotExist = (int)z.ExecuteScalar();
            if (UserExist > 0)
            {
                MessageBox.Show("You are Friends");
            }
            else if (UserNotExist == 0 || textBox1.Text=="4M")
            {
                MessageBox.Show("This Account Not Found");

            }
            else
            {
                cmd = new SqlCommand("checkfriendship", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email1", Globals.emails));
                cmd.Parameters.Add(new SqlParameter("@email2", textBox1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("You are Now Friends");
            }
            cnn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetAdd();
        }

        private void button2_VisibleChanged(object sender, EventArgs e)
        {
            SetAdd();
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }
        private void label1_VisibleChanged_1(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string l = @"SELECT Count(*)From Registration WHERE email=@username ";

            cnn.Open();
            SqlCommand z;
            z = new SqlCommand(l, cnn);

            z.Parameters.Add(new SqlParameter("@username", textBox1.Text));

            int UserNotExist = (int)z.ExecuteScalar();

            if (UserNotExist == 0)
            {
                MessageBox.Show("This Account Not Found");

            }
            else
            {
                Globals.emails2 = textBox1.Text;
                this.Close();
                mostafa = new Thread(vieww);
                mostafa.SetApartmentState(ApartmentState.STA);
                mostafa.Start();
            }
            cnn.Close();
        }

        
    }
}
