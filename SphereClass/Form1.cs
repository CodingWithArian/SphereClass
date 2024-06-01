using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            Sphere sphere = new Sphere();
            double radius = int.Parse(textBox1.Text);
            sphere.Radius = radius;
            output += sphere.ToString();
            output += "Perimeter : " + sphere.Perimeter() + "\n";
            output += "Area : " + sphere.Area() + "\n";
            output += "Valume : " + sphere.Valume() + "\n";
            MessageBox.Show(output);

            Sphere sphere1 = new Sphere(double.Parse(textBox1.Text));
            output= sphere1.ToString();
            MessageBox.Show(output);
        }
    }
}
