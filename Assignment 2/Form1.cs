using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // read the radius from text box
                double CircleRadius = double.Parse(textBox1.Text);
                //calculate the area and circuference
                double CircleArea = CircleRadius * Math.PI;
                double CircleVolume = 4 / 3 * Math.PI * CircleRadius * CircleRadius * CircleRadius;
                label2.Text = "Surface area = " + CircleArea;
                label3.Text = "Volume = " + CircleVolume;

            }
            catch
            {}

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double ConeRadius = double.Parse(textBox2.Text);
                double ConeHeight = double.Parse(textBox3.Text);
                double ConeSurfaceArea = Math.PI * ConeRadius * (ConeRadius + Math.Sqrt(ConeHeight + ConeRadius);
                label4.Text = "Surface Area" + ConeSurfaceArea;
            }
            catch
            {//fix the code on wednesday }
        }
    }
}
