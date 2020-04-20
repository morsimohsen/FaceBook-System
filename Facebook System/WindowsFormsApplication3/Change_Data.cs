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
namespace WindowsFormsApplication3
{
    public partial class Change_Data : Form
    {
       

        public Change_Data()
        {
            InitializeComponent();

                   
        }
        
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void savename_Click(object sender, EventArgs e)
        {
        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand command;
            command = new SqlCommand("updatename", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            if (Globals.PP == CP.Text)
            {
                command.Parameters.AddWithValue("@user", Globals.emails);
                command.Parameters.AddWithValue("@first", UFN.Text);
                command.Parameters.AddWithValue("@last", ULN.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Name Changed");
            }
            else
                MessageBox.Show("Password is Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            cnn.Close();
        }

        private void UFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void savepass_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
            SqlCommand command;
            command = new SqlCommand("updatepass", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            if (Globals.PP == LP.Text)
            {
                command.Parameters.AddWithValue("@user", Globals.emails);
                command.Parameters.AddWithValue("@pass", NP.Text);
               if(NP.Text==CNP.Text)
                {
             
                command.ExecuteNonQuery();
                MessageBox.Show("Password Changed");
                }
               else
                    MessageBox.Show("Password is Not same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                MessageBox.Show("Password is Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            cnn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
