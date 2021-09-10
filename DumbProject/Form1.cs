using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumbProject
{
    public partial class Form1 : Form
    {
        String message = "abcdef....";
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = message;
            this.textBox2.Text = message;
            this.textBox3.Text = message;
            this.textBox4.Text = message;
        }
        // Phep cong
        private void button1_Click(object sender, EventArgs e)
        {
        // Lay phan thuc va phan ao cua so thu nhat.
            int pt1 = int.Parse(textBox1.Text);
            int pa1 = int.Parse(textBox2.Text);
        // Lay phan thuc va phan ao cua so thu hai
            int pt2 = int.Parse(textBox3.Text);
            int pa2 = int.Parse(textBox4.Text);
            textBox5.Text = "" + (pt1 + pt2);
            textBox6.Text = "" + (pa1 + pa2);
        }
        // Phep tru so thu nhat cho so thu 2
        private void button3_Click(object sender, EventArgs e)
        {
            // Lay phan thuc va phan ao cua so thu nhat.
            int pt1 = int.Parse(textBox1.Text);
            int pa1 = int.Parse(textBox2.Text);
            // Lay phan thuc va phan ao cua so thu hai
            int pt2 = int.Parse(textBox3.Text);
            int pa2 = int.Parse(textBox4.Text);
            textBox5.Text = "" + (pt1 - pt2);
            textBox6.Text = "" + (pa1 - pa2);
        }
        // Phep nhan
        private void button2_Click(object sender, EventArgs e)
        {
            // Lay phan thuc va phan ao cua so thu nhat.
            int pt1 = int.Parse(textBox1.Text);
            int pa1 = int.Parse(textBox2.Text);
            // Lay phan thuc va phan ao cua so thu hai
            int pt2 = int.Parse(textBox3.Text);
            int pa2 = int.Parse(textBox4.Text);
            textBox5.Text = "" + (pt1 * pt2);
            textBox6.Text = "" + (pa1 * pa2);
        }
        // Phep chia so thu nhat cho so thu 2
        private void button4_Click(object sender, EventArgs e)
        {
        // Lay phan thuc va phan ao cua so thu nhat.
            int pt1 = int.Parse(textBox1.Text);
            int pa1 = int.Parse(textBox2.Text);
        // Lay phan thuc va phan ao cua so thu hai
            int pt2 = int.Parse(textBox3.Text);
            int pa2 = int.Parse(textBox4.Text);
            textBox5.Text = "" + (pt1 / pt2);
            textBox6.Text = "" + (pa1 / pa2);
        }
    }
}
