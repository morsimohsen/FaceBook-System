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
using System.IO;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form10 : Form
    {
        Thread mostafa;
        private void homee(object obj)
        {
            Application.Run(new profile());
        }
        private bool SetButton()
        {
            return Post.Enabled = ((textBox1.Text != "" || textBox1.Visible == false) || (image1.Image != null));


        }
        private bool Set2()
        {
            return comment1.Enabled = (((textBox2.Text != "" || textBox2.Visible == false) || (pg_Gym.Image != null)) && (comment.Text != "" || comment.Visible == false));


        }
        private bool Set()
        {
            return like.Enabled = ((textBox2.Text != "" || textBox2.Visible == false) || (pg_Gym.Image != null));


        }
        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand cmd;
        public Form10()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try {

                
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG;*.3GP)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG;*.3GP";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                   Globals.imgloc = openFileDialog1.FileName.ToString();
                    image1.ImageLocation =Globals. imgloc;
                }

            


            }
            catch(Exception )
            {
                MessageBox.Show("Password is Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
                cmd = new SqlCommand("creategroup", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@user", Globals.emails));

                cmd.Parameters.Add(new SqlParameter("@post", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@name", "Healthy GYM"));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));

            if (Globals.imgloc != null)
            {
                byte[] img = null;
                FileStream fs = new FileStream(Globals.imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);


                cmd.Parameters.Add(new SqlParameter("@image", img));
            }

               
                cmd.ExecuteNonQuery();

                MessageBox.Show("Post is Added");


                cnn.Close();
            Globals.imgloc = null;
        }

        
       
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SetButton();

        }
        


        private void Post_VisibleChanged(object sender, EventArgs e)
        {
            SetButton();


        }


        private void image1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            SetButton();

        }

        
        
        private void label1_VisibleChanged_1(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Set2();
            Set();
        }
        
        private void comment1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("createpost", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.AddWithValue("@user", Globals.emails);

            cmd.Parameters.AddWithValue("@comment1", comment.Text);
            cmd.Parameters.AddWithValue("@name", "Healthy GYM" );
            cmd.ExecuteNonQuery();
            MessageBox.Show("Comment Added");
            cnn.Close();

        }

       
        private void comment_TextChanged(object sender, EventArgs e)
        {
            Set2();
            
        }
        
        private void comment1_VisibleChanged(object sender, EventArgs e)
        {
            Set2();
        

        }

        private void like_Click(object sender, EventArgs e)
        {
            string FF = @"SELECT likes_group From Post WHERE email=@username and Name_group='Healthy GYM' ";
            string FFFF = null;
            cnn.Open();
                    SqlCommand FFF = new SqlCommand();

            FFF = new SqlCommand(FF, cnn);
            FFF.Parameters.Add(new SqlParameter("@username", Globals.emails));

            var t = FFF.ExecuteScalar();
            if (t != DBNull.Value && t != null)
            {
                FFFF = (string)t;
            }

            if (FFFF == "unlike" && Globals.count == 0 && t != null)
            {
                Globals.like1_group = "unlike";
                Globals.like_group = "like";

            }
            else if (FFFF == "like" && Globals.count == 0 && t != null)
            {
                Globals.like_group = "unlike";
                Globals.like1_group = "like";

            }

            else if (FFFF == "like" && Globals.count != 0)
            {
                Globals.like_group = "unlike";
                Globals.like1_group = "like";

            }
            else if (FFFF == "unlike" && Globals.count != 0)
            {
                Globals.like_group = "like";
                Globals.like1_group = "unlike";

            }
            else
            {
                Globals.like1_group = "unlike";
                Globals.like_group = "like";

            }





            cmd = new SqlCommand("createlike", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", Globals.emails);
            cmd.Parameters.AddWithValue("@like_group", Globals.like_group);
            cmd.Parameters.AddWithValue("@name", "Healthy GYM");
            cmd.ExecuteNonQuery();
            Globals.constt = (string)FFF.ExecuteScalar();
            if (Globals.constt == "like")
                Globals.constt = "unlike";
            else
                Globals.constt = "like";

            cnn.Close();
            like.Text = Globals.like1_group;
            Globals.seen++;
            Globals.count++;
        }
       
        private void like_VisibleChanged(object sender, EventArgs e)
        {
            cnn.Open();

            SqlCommand c = new SqlCommand("Select  MAX(G_ID) From Groupfacebook Where (email = '" + Globals.emails + "' and GroupName ='Healthy GYM' )", cnn);
            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);

            cmd = new SqlCommand("Select photo From Groupfacebook Where (email = '" + Globals.emails + "' and GroupName ='Healthy GYM'and photo is not NULL and G_ID = '" + z + "')", cnn); SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                byte[] b = sdr["photo"] as byte[] ?? null;
                if (b != null)
                {
                    MemoryStream ms = new MemoryStream(b);
                    pg_Gym.Image = Image.FromStream(ms);
                }
            }

            sdr.Close();
            cnn.Close();

            Set();
            string FF = @"SELECT likes_group From Post WHERE email=@username and Name_group='Healthy GYM'";
            string FFFF = null;
            cnn.Open();
        
            SqlCommand FFF = new SqlCommand();

            FFF = new SqlCommand(FF, cnn);
            FFF.Parameters.Add(new SqlParameter("@username", Globals.emails));

            var t = FFF.ExecuteScalar();
            if (t == "NULL")
                FFFF = (string)FFF.ExecuteScalar();
            if (Globals.like_group != null && Globals.count == 0 && t == null)
            {
                like.Text = "like";
            }

            else if (Globals.like_group != null && Globals.seen != 0 && t != null)
            {
                if (FFFF == "like")
                    like.Text = "unlike";
                else
                    like.Text = "like";
            }

            else if (Globals.like_group == null && Globals.count == 0 && Globals.seen == 0 && t != null)
            {
                if (FFFF == "like")
                    like.Text = "unlike";
                else
                    like.Text = "like";
            }

            else if (Globals.like_group != null && Globals.count == 0 && Globals.seen != 0)
            {
                like.Text = Globals.constt;
            }
            else if (Globals.like_group == null)
            { }

            else
            {
                like.Text = Globals.like1_group;
            }

            cnn.Close();


        }

        private void pictureBox4_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Set2();
            Set();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.count = 0;
            this.Close();
            mostafa = new Thread(homee);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();

        }


        private void pictureBox4_VisibleChanged(object sender, EventArgs e)
        {
            cnn.Open();

            SqlCommand c = new SqlCommand("Select  MAX(G_ID) From Groupfacebook Where (email = '" + Globals.emails + "' and GroupName ='Healthy GYM' )", cnn);
            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);

            cmd = new SqlCommand("Select photo From Groupfacebook Where (email = '" + Globals.emails + "' and GroupName ='Healthy GYM'and photo is not NULL and G_ID = '" + z + "')", cnn); SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                byte[] b = sdr["photo"] as byte[] ?? null;
                if (b != null)
                {
                    MemoryStream ms = new MemoryStream(b);
                    pg_Gym.Image = Image.FromStream(ms);
                }
            }

            sdr.Close();
            cnn.Close();
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            cnn.Open();

            SqlCommand c = new SqlCommand("Select  MAX(G_ID) From Groupfacebook Where (email = '" + Globals.emails + "' and GroupName ='Healthy GYM' )", cnn);
            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);

            cmd = new SqlCommand("Select  post From Groupfacebook Where (email = '" + Globals.emails + "' and GroupName ='Healthy GYM' and post is not NULL and G_ID = '" + z + "')", cnn);
            string t = (string)cmd.ExecuteScalar();
            if (t == "NULL")
            {
                textBox2.Enabled = false;

            }
            else
            {
                string s = (string)cmd.ExecuteScalar();
                textBox2.Text = s;
                textBox2.Enabled = false;
            }
            cnn.Close();

        }
    }
}

