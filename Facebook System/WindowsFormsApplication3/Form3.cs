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
    public partial class Form3 : Form
    {
        Thread mostafa;
        private void homee(object obj)
        {
            Application.Run(new profile());
        }
        private void fci(object obj)
        {
            Application.Run(new Form6());
        }
        private void gym(object obj)
        {
            Application.Run(new Form10());
        }
        private void food(object obj)
        {
            Application.Run(new Form11());
        }
        private void comm(object obj)
        {
            Application.Run(new Form12());
        }
        private void ultras(object obj)
        {
            Application.Run(new Form13());
        }

        private void set()
        {


            if (button4.Enabled == true)
            {
                button2.Enabled = false;
            }
            else
                button2.Enabled = true;

            if (button5.Enabled == true)
            {
                button3.Enabled = false;
            }
            else
                button3.Enabled = true;

            if (button6.Enabled == true)
            {
                button7.Enabled = false;
            }
            else
                button7.Enabled = true;

            if (button8.Enabled == true)
            {
                button9.Enabled = false;
            }
            else
                button9.Enabled = true;

            if (button10.Enabled == true)
            {
                button11.Enabled = false;
            }
            else
                button11.Enabled = true;

        }

        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(fci);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           cmd = new SqlCommand("creategroup", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.Add(new SqlParameter("@user", Globals.emails));
            cmd.Parameters.Add(new SqlParameter("@name", "FCIS 2021"));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));
            cmd.ExecuteNonQuery();


            cnn.Close();
            if (Globals.emails != "4M")
            {
                button4.Text = "Joined";
                button4.Enabled = false;
                set();

            }
        }

        
        private void button4_VisibleChanged(object sender, EventArgs e)
        {


            if (Globals.emails == "4M")
            {
                button4.Text = "Joined";
                button4.Enabled = false;

            }
            else
            {
                string s = @"SELECT Count(*)From Groupfacebook WHERE email=@username and GroupName='FCIS 2021'";
                string f = @"SELECT Count(*)From Groupfacebook WHERE Block_acc=@username and GroupName='FCIS 2021'";


               SqlCommand  cmd2;



                cmd = new SqlCommand(s, cnn);
                cmd2 = new SqlCommand(f, cnn);

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@username", Globals.emails));
                cmd2.Parameters.Add(new SqlParameter("@username", Globals.emails));
                int UserExist = (int)cmd.ExecuteScalar();
                int UserExist_block = (int)cmd2.ExecuteScalar();

                if (UserExist_block > 0 && UserExist > 0)
                {
                    Globals.check = true;
                    button4.Text = "Join";
                    button4.Enabled = false;
                }
                else if (UserExist > 0)
                {
                    button4.Text = "Joined";
                    button4.Enabled = false;
                }


                cnn.Close();

            }

        }

        private void button2_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.check)
            {
                button2.Enabled = false;
            }
            else
            {
                set();

            }
        }
        

        private void label1_VisibleChanged_1(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }
        
        private void label1_VisibleChanged_2(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(gym);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("creategroup", cnn);
            cmd.CommandType = CommandType.StoredProcedure;



            cnn.Open();
            cmd.Parameters.Add(new SqlParameter("@user", Globals.emails));
            cmd.Parameters.Add(new SqlParameter("@name", "Healthy GYM"));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));




            cmd.ExecuteNonQuery();


            cnn.Close();
            if (Globals.emails != "4M")
            {
                button5.Text = "Joined";
                button5.Enabled = false;
                set();

            }




        }

        private void button5_VisibleChanged(object sender, EventArgs e)
        {

            if (Globals.emails == "4M")
            {
                button5.Text = "Joined";
                button5.Enabled = false;

            }
            else
            {
                string s = @"SELECT Count(*)From Groupfacebook WHERE email=@username and GroupName='Healthy GYM'";
                string f = @"SELECT Count(*)From Groupfacebook WHERE Block_acc=@username and GroupName='Healthy GYM'";


                SqlCommand  cmd2;



                cmd = new SqlCommand(s, cnn);
                cmd2 = new SqlCommand(f, cnn);

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@username", Globals.emails));
                cmd2.Parameters.Add(new SqlParameter("@username", Globals.emails));
                int UserExist = (int)cmd.ExecuteScalar();
                int UserExist_block = (int)cmd2.ExecuteScalar();

                if (UserExist_block > 0 && UserExist > 0)
                {
                    Globals.check = true;
                    button5.Text = "Join";
                    button5.Enabled = false;
                }
                else if (UserExist > 0)
                {
                    button5.Text = "Joined";
                    button5.Enabled = false;
                }


                cnn.Close();
            }
        }

        private void button3_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.check)
            {
                button3.Enabled = false;
            }
            else
            {
                set();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(homee);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("creategroup", cnn);
            cmd.CommandType = CommandType.StoredProcedure;



            cnn.Open();
            cmd.Parameters.Add(new SqlParameter("@user", Globals.emails));
            cmd.Parameters.Add(new SqlParameter("@name", "Healthy Food"));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));
            cmd.ExecuteNonQuery();


            cnn.Close();
            if (Globals.emails != "4M")
            {
                button6.Text = "Joined";
                button6.Enabled = false;
                set();

            }


        }

        private void button6_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.emails == "4M")
            {
                button6.Text = "Joined";
                button6.Enabled = false;

            }
            else
            {
                string s = @"SELECT Count(*)From Groupfacebook WHERE email=@username and GroupName='Healthy Food' ";
                string f = @"SELECT Count(*)From Groupfacebook WHERE Block_acc=@username and GroupName='Healthy Food'";


                SqlCommand  cmd2;



                cmd = new SqlCommand(s, cnn);
                cmd2 = new SqlCommand(f, cnn);

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@username", Globals.emails));
                cmd2.Parameters.Add(new SqlParameter("@username", Globals.emails));

                int UserExist = (int)cmd.ExecuteScalar();
                int UserExist_block = (int)cmd2.ExecuteScalar();

                if (UserExist_block > 0 && UserExist > 0)
                {
                    Globals.check = true;
                    button6.Text = "Join";
                    button6.Enabled = false;
                }
                else if (UserExist > 0)
                {
                    button6.Text = "Joined";
                    button6.Enabled = false;
                }


                cnn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(food);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button7_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.check)
            {
                button7.Enabled = false;
            }
            else
            {
                set();

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("creategroup", cnn);
            cmd.CommandType = CommandType.StoredProcedure;



            cnn.Open();
            cmd.Parameters.Add(new SqlParameter("@user", Globals.emails));
            cmd.Parameters.Add(new SqlParameter("@name", "Community"));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));




            cmd.ExecuteNonQuery();

            cnn.Close();
            if (Globals.emails != "4M")
            {
                button8.Text = "Joined";
                button8.Enabled = false;
                set();

            }

        }

        private void button8_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.emails == "4M")
            {
                button8.Text = "Joined";
                button8.Enabled = false;

            }
            else
            {
                string s = @"SELECT Count(*)From Groupfacebook WHERE email=@username and GroupName='Community' ";
                string f = @"SELECT Count(*)From Groupfacebook WHERE Block_acc=@username and GroupName='Community'";


                SqlCommand  cmd2;



                cmd = new SqlCommand(s, cnn);
                cmd2 = new SqlCommand(f, cnn);

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@username", Globals.emails));
                cmd2.Parameters.Add(new SqlParameter("@username", Globals.emails));






                int UserExist = (int)cmd.ExecuteScalar();
                int UserExist_block = (int)cmd2.ExecuteScalar();

                if (UserExist_block > 0 && UserExist > 0)
                {
                    Globals.check = true;
                    button8.Text = "Join";
                    button8.Enabled = false;
                }
                else if (UserExist > 0)
                {
                    button8.Text = "Joined";
                    button8.Enabled = false;
                }


                cnn.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(comm);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button9_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.check)
            {
                button9.Enabled = false;
            }
            else
            {
                set();

            }
        }

        
        private void button10_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("creategroup", cnn);
            cmd.CommandType = CommandType.StoredProcedure;



            cnn.Open();
            cmd.Parameters.Add(new SqlParameter("@user", Globals.emails));
            cmd.Parameters.Add(new SqlParameter("@name", "Ultras FCIS"));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));

            cmd.ExecuteNonQuery();

            cnn.Close();
            if (Globals.emails != "4M")
            {
                button10.Text = "Joined";
                button10.Enabled = false;
                set();

            }

        }

        private void button10_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.emails == "4M")
            {
                button10.Text = "Joined";
                button10.Enabled = false;

            }
            else
            {
                string s = @"SELECT Count(*)From Groupfacebook WHERE email=@username and GroupName='Ultras FCIS' ";
                string f = @"SELECT Count(*)From Groupfacebook WHERE Block_acc=@username and GroupName='Ultras FCIS'";


                SqlCommand  cmd2;



                cmd = new SqlCommand(s, cnn);
                cmd2 = new SqlCommand(f, cnn);

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@username", Globals.emails));
                cmd2.Parameters.Add(new SqlParameter("@username", Globals.emails));






                int UserExist = (int)cmd.ExecuteScalar();
                int UserExist_block = (int)cmd2.ExecuteScalar();

                if (UserExist_block > 0 && UserExist > 0)
                {
                    Globals.check = true;
                    button10.Text = "Join";
                    button10.Enabled = false;
                }
                else if (UserExist > 0)
                {
                    button10.Text = "Joined";
                    button10.Enabled = false;
                }


                cnn.Close();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(ultras);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button11_VisibleChanged(object sender, EventArgs e)
        {
            if (Globals.check)
            {
                button11.Enabled = false;
            }
            else
            {
                set();

            }
        }
    }
}

