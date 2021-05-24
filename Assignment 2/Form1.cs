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
            {
                MessageBox.Show("error cylinder");
            }

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
                double ConeSurfaceArea = Math.PI * ConeRadius * (ConeRadius + Math.Sqrt(ConeHeight + ConeRadius));
                double ConeVolume = Math.PI * ConeRadius * ConeRadius * (ConeHeight / 3);
                label4.Text = "Surface Area =" + ConeSurfaceArea;
                label5.Text = "Volume =" + ConeVolume;
            }

            catch
            {
                MessageBox.Show("Cone");
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double CylinderRadius = double.Parse(textBox4.Text);
                double CylinderHeight = double.Parse(textBox5.Text);
                double CylinderSurfaceArea = 2 * Math.PI * CylinderRadius * CylinderHeight + 2 * Math.PI * (CylinderRadius * CylinderRadius);
                double CylinderVolume = Math.PI * (CylinderRadius * CylinderRadius) * CylinderHeight;
                label8.Text = "Surface Area =" + CylinderSurfaceArea;
                label9.Text = "Volume =" + CylinderVolume;
            }
            catch
            {
                MessageBox.Show("error Cylinder");
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                double ConeEdge = double.Parse(textBox6.Text);
                double ConeSurfaceArea = 6 * (ConeEdge * ConeEdge);
                double ConeVolume = ConeEdge * ConeEdge * ConeEdge;
                label14.Text = "Surface Area =" + ConeSurfaceArea;
                label15.Text = "Volume =" + ConeVolume;
            }
            catch
            {
                MessageBox.Show("Error Cube");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                double CuboidLength = double.Parse(textBox7.Text);
                double CuboidWidth = double.Parse(textBox8.Text);
                double CuboidHeight = double.Parse(textBox9.Text);
                double CuboidSurfaceArea = 2 * (CuboidLength * CuboidWidth) + 2 * (CuboidLength * CuboidHeight) + 2 * (CuboidHeight * CuboidWidth);
                double CuboidVolume = CuboidHeight * CuboidLength * CuboidWidth;
                label18.Text = "Surface Area =" + CuboidSurfaceArea;
                label19.Text = "Volume =" + CuboidVolume;
            }
            catch
            {
                MessageBox.Show("Error Cuboid");
            }
        }
    }
}
