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
    public partial class profile : Form
    {
        Thread mostafa;
        private void homee(object obj)
        {
            Application.Run(new profile());
        }
        private void groupe(object obj)
        {
            Application.Run(new Form3());
        }
        private void addf(object obj)
        {
            Application.Run(new Form9());
        }
        private void ch_d(object obj)
        {
            Application.Run(new Change_Data());
        }
        private void outt(object obj)
        {
            Application.Run(new home());
        }
        
        private bool SetButton()
        {
            return Post.Enabled = ((textBox1.Text != "" || textBox1.Visible == false) || (image1.Image != null));


        }
        private bool Set()
        {
            return like.Enabled = ((textBox2.Text != "" || textBox2.Visible == false) || (pictureBox3.Image != null));


        }
        private bool Set2()
        {
            return comment1.Enabled = (((textBox2.Text != "" || textBox2.Visible == false) || (pictureBox3.Image != null)) && (comment.Text != "" || comment.Visible == false));


        }

        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand cmd;
        public profile()
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


        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
            mostafa = new Thread(outt);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(addf);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void updatedata_Click(object sender, EventArgs e)
        {

            this.Close();
            mostafa = new Thread(ch_d);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }

        private void label3_VisibleChanged(object sender, EventArgs e)
        {
            label3.Text = Globals.FN;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Set2();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string FF = @"SELECT likes From Post WHERE email=@username ";
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

            if (FFFF == "unlike" && Globals.countt == 0 && t != null)
            {
                Globals.like1 = "unlike";
                Globals.like = "like";

            }
            else if (FFFF == "like" && Globals.countt == 0 && t != null)
            {
                Globals.like = "unlike";
                Globals.like1 = "like";

            }

            else if (FFFF == "like" && Globals.countt != 0)
            {
                Globals.like = "unlike";
                Globals.like1 = "like";

            }
            else if (FFFF == "unlike" && Globals.countt != 0)
            {
                Globals.like = "like";
                Globals.like1 = "unlike";

            }
            else
            {
                Globals.like1 = "unlike";
                Globals.like = "like";

            }

            cmd = new SqlCommand("createlikes", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", Globals.emails);
            cmd.Parameters.AddWithValue("@like", Globals.like);
            cmd.ExecuteNonQuery();
            Globals.consttt = (string)FFF.ExecuteScalar();
            if (Globals.consttt == "like")
                Globals.consttt = "unlike";
            else
                Globals.consttt = "like";

            cnn.Close();
            like.Text = Globals.like1;
            Globals.seenn++;
            Globals.countt++;

        }
        
        private void like_VisibleChanged(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand c = new SqlCommand("Select MAX(id) From Post Where (email = '" + Globals.emails + "' and comment is NULL and comment_group is NULL and Name_group is NULL and photo is not NULL)", cnn);

            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);

            SqlCommand f = new SqlCommand("Select photo From Post Where (email = '" + Globals.emails + "' and comment is NULL and comment_group is NULL and Name_group is NULL and id = '" + z + "')", cnn);
            SqlDataReader sdr = f.ExecuteReader();
            while (sdr.Read())
            {
                byte[] b = sdr["photo"] as byte[] ?? null;
                if (b != null)
                {
                    MemoryStream ms = new MemoryStream(b);
                    pictureBox3.Image = Image.FromStream(ms);
                }
            }

            sdr.Close();
            cnn.Close();

            Set();
            string FF = @"SELECT likes From Post WHERE email=@username ";
            string FFFF=" ";
            cnn.Open();
            SqlCommand FFF = new SqlCommand();

            FFF = new SqlCommand(FF, cnn);
            FFF.Parameters.Add(new SqlParameter("@username", Globals.emails));

            object t = FFF.ExecuteScalar();
            

            if (t=="NULL")
                FFFF = (string)FFF.ExecuteScalar();
            if (Globals.like != null && Globals.countt == 0 && t == null)
            {
                like.Text = "like";
            }
            else if (Globals.like != null && Globals.seenn != 0 && t != null)
            {
                if (FFFF == "like")
                    like.Text = "unlike";
                else
                    like.Text = "like";
            }

            else if (Globals.like == null && Globals.countt == 0 && Globals.seenn == 0 && t != null)
            {
                if (FFFF == "like")
                    like.Text = "unlike";
                else
                    like.Text = "like";
            }

            else if (Globals.like != null && Globals.countt == 0 && Globals.seenn != 0)
            {
                like.Text = Globals.consttt;
            }
            else if (Globals.like == null)
            { }

            else
            {
                like.Text = Globals.like1;
            }

            cnn.Close();

        }
       

        private void comment1_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("createpost", cnn);
            
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                cmd.Parameters.AddWithValue("@user", Globals.emails);

                cmd.Parameters.AddWithValue("@comment", comment.Text);
                cmd.ExecuteNonQuery();
            MessageBox.Show("Comment Added");
                cnn.Close();

            
        }

        private void comment1_VisibleChanged(object sender, EventArgs e)
        {
            Set2();
        }

        private void label1_VisibleChanged_1(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }

        private void Post_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("createpost", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnn.Open();
            cmd.Parameters.Add(new SqlParameter("@user", Globals.emails));

            cmd.Parameters.Add(new SqlParameter("@text", textBox1.Text));

            if (Globals.imgloc != null)
            {
                byte[] img = null;
                FileStream fs = new FileStream(Globals.imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);


                cmd.Parameters.Add(new SqlParameter("@photo", img));
            }


            cmd.ExecuteNonQuery();

            MessageBox.Show("Post is Added");


            cnn.Close();
            Globals.imgloc = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetButton();

        }

        private void Post_VisibleChanged(object sender, EventArgs e)
        {
            SetButton();

        }

        private void photo_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG;*.3GP)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG;*.3GP";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Globals.imgloc = openFileDialog1.FileName.ToString();
                    image1.ImageLocation = Globals.imgloc;
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Password is Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void image1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            SetButton();

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            Set2();
            Set();
        }

        private void pictureBox3_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Set2();
            Set();
        }

        private void pictureBox3_VisibleChanged(object sender, EventArgs e)
        {

            cnn.Open();
            SqlCommand c = new SqlCommand("Select MAX(id) From Post Where (email = '" + Globals.emails + "' and comment is NULL and comment_group is NULL and Name_group is NULL and photo is not NULL)", cnn);

            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);

            SqlCommand f = new SqlCommand("Select photo From Post Where (email = '" + Globals.emails + "' and comment is NULL and comment_group is NULL and Name_group is NULL and id = '" + z + "')", cnn);
            SqlDataReader sdr = f.ExecuteReader();
            while (sdr.Read())
            {
                byte[] b = sdr["photo"] as byte[] ?? null;
                if (b != null)
                {
                    MemoryStream ms = new MemoryStream(b);
                    pictureBox3.Image = Image.FromStream(ms);
                }
            }

            sdr.Close();
            cnn.Close();
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand c = new SqlCommand("Select MAX(id) From Post Where (email = '" + Globals.emails + "' and comment is NULL and comment_group is NULL and Name_group is NULL and textt is not NULL)", cnn);

            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);


            SqlCommand t = new SqlCommand("Select textt From Post Where (email = '" + Globals.emails + "' and comment is NULL and comment_group is NULL and Name_group is NULL and id = '" + z + "')", cnn);
            object resultt = t.ExecuteScalar();
            resultt = (resultt == DBNull.Value) ? null : resultt;
            string s = Convert.ToString(resultt);

            textBox2.Text = s;
            textBox2.Enabled = false;
            cnn.Close();
        }

        private void paneltool_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_VisibleChanged_1(object sender, EventArgs e)
        {
            label3.Text = Globals.FN;

        }
    }
}
