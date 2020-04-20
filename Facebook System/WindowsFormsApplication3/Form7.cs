using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication3
{
    public partial class Form7 : Form
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
        private void con(object obj)
        {
            Application.Run(new Form8());
        }
        private void outt(object obj)
        {
            Application.Run(new home());
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(groupe);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(homee);
            mostafa.SetApartmentState(ApartmentState.STA);
            mostafa.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mostafa = new Thread(con);
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

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = Globals.FN;

        }

        private void label2_VisibleChanged(object sender, EventArgs e)
        {
            label2.Text = Globals.FN;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
