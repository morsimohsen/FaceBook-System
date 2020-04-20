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
    public partial class Form14 : Form
    {
        Thread mostafa;
        private void homee(object obj)
        {
            Application.Run(new profile());
        }
        private void flist(object obj)
        {
            Application.Run(new Form9());
        }
        private void groupe(object obj)
        {
            Application.Run(new Form3());
        }
        private bool Set2()
        {
            return comment1.Enabled = (((textBox2.Text != "" || textBox2.Visible == false) || (pictureBox3.Image != null)) && (comment.Text != "" || comment.Visible == false));


        }
        private bool Set()
        {
            return like.Enabled = ((textBox2.Text != "" || textBox2.Visible == false) || (pictureBox3.Image != null));


        }

        SqlConnection cnn = new SqlConnection(@"Data Source=TATA\MOSTAFA;Initial Catalog=Facebook;Integrated Security=SSPI;");
        SqlCommand cmd;
        public Form14()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globals.counttt=0;
            this.Close();
            mostafa = new Thread(homee);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void Friends_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(groupe);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(flist);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            string l = @"SELECT first_name From Registration WHERE email=@username ";
            string s = @"SELECT last_name From Registration WHERE email=@username ";


            cnn.Open();
            SqlCommand z, m;
            z = new SqlCommand(l, cnn);
            m = new SqlCommand(s, cnn);


            z.Parameters.Add(new SqlParameter("@username", Globals.emails2));
            m.Parameters.Add(new SqlParameter("@username", Globals.emails2));
            string zz = (string)z.ExecuteScalar();
            string mm = (string)m.ExecuteScalar();

            Globals.FN2 = zz + mm;
            cnn.Close();
            label1.Text = Globals.FN2;
        }

        private void label3_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = Globals.FN2;


        }

        private void like_Click(object sender, EventArgs e)
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

            if (FFFF == "unlike" && Globals.counttt == 0 && t != null)
            {
                Globals.like2 = "unlike";
                Globals.like3 = "like";

            }
            else if (FFFF == "like" && Globals.counttt == 0 && t != null)
            {
                Globals.like3 = "unlike";
                Globals.like2 = "like";

            }

            else if (FFFF == "like" && Globals.counttt != 0)
            {
                Globals.like3 = "unlike";
                Globals.like2 = "like";

            }
            else if (FFFF == "unlike" && Globals.counttt != 0)
            {
                Globals.like2 = "like";
                Globals.like3 = "unlike";

            }
            else
            {
                Globals.like2 = "unlike";
                Globals.like3 = "like";

            }

            cmd = new SqlCommand("createlikes", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", Globals.emails);
            cmd.Parameters.AddWithValue("@like", Globals.like3);
            cmd.ExecuteNonQuery();
            Globals.consttt1 = (string)FFF.ExecuteScalar();
            if (Globals.consttt1 == "like")
                Globals.consttt1 = "unlike";
            else
                Globals.consttt1 = "like";

            cnn.Close();
            like.Text = Globals.like2;
            Globals.seennn++;
            Globals.counttt++;

        }

        private void like_VisibleChanged(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand c = new SqlCommand("Select MAX(id) From Post Where (email = '" + Globals.emails2 + "' and comment is NULL and comment_group is NULL and Name_group is NULL and photo is not NULL)", cnn);

            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);

            SqlCommand f = new SqlCommand("Select photo From Post Where (email = '" + Globals.emails2 + "' and comment is NULL and comment_group is NULL and Name_group is NULL and id = '" + z + "')", cnn);
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
            string FFFF = " ";
            cnn.Open();
            SqlCommand FFF = new SqlCommand();

            FFF = new SqlCommand(FF, cnn);
            FFF.Parameters.Add(new SqlParameter("@username", Globals.emails));

            object t = FFF.ExecuteScalar();


            if (t == "NULL")
                FFFF = (string)FFF.ExecuteScalar();
            if (Globals.like3 != null && Globals.counttt == 0 && t == null)
            {
                like.Text = "like";
            }
            else if (Globals.like3 != null && Globals.seennn != 0 && t != null)
            {
                if (FFFF == "like")
                    like.Text = "unlike";
                else
                    like.Text = "like";
            }

            else if (Globals.like3 == null && Globals.counttt == 0 && Globals.seennn == 0 && t != null)
            {
                if (FFFF == "like")
                    like.Text = "unlike";
                else
                    like.Text = "like";
            }

            else if (Globals.like3 != null && Globals.counttt == 0 && Globals.seennn != 0)
            {
                like.Text = Globals.consttt1;
            }
            else if (Globals.like3 == null)
            { }

            else
            {
                like.Text = Globals.like2;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Set2();
            Set();
        }

        private void comment_TextChanged(object sender, EventArgs e)
        {
            Set2();
            
        }

        private void pictureBox3_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Set2();
            Set();
        }

        private void pictureBox3_VisibleChanged(object sender, EventArgs e)
        {

            cnn.Open();
            SqlCommand c = new SqlCommand("Select MAX(id) From Post Where (email = '" + Globals.emails2+ "' and comment is NULL and comment_group is NULL and Name_group is NULL)", cnn);

            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);

            SqlCommand f = new SqlCommand("Select photo From Post Where (email = '" + Globals.emails2+ "' and comment is NULL and comment_group is NULL and Name_group is NULL and id = '" + z + "')", cnn);
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
            SqlCommand c = new SqlCommand("Select MAX(id) From Post Where (email = '" + Globals.emails2 + "' and comment is NULL and comment_group is NULL and Name_group is NULL)", cnn);

            object result = c.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int z = Convert.ToInt32(result);


            SqlCommand t = new SqlCommand("Select textt From Post Where (email = '" + Globals.emails2 + "' and comment is NULL and comment_group is NULL and Name_group is NULL and id = '" + z + "')", cnn);

            object resultt = t.ExecuteScalar();
            resultt = (resultt == DBNull.Value) ? null : resultt;
            string s = Convert.ToString(resultt);


            //string s = (string)t.ExecuteScalar();
            textBox2.Text = s;
            textBox2.Enabled = false;
            cnn.Close();
        }

       

        private void label1_VisibleChanged_1(object sender, EventArgs e)
        {
            label1.Text = Globals.emails2;
        }

        private void label2_VisibleChanged(object sender, EventArgs e)
        {
            label2.Text = Globals.emails2;
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
