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
        String message = "0";
        public Form1()
        {
            InitializeComponent();
            this.phanThuc1.Text = message;
            this.phanAo1.Text = message;
            this.phanThuc2.Text = message;
            this.phanAo2.Text = message;
        }
        // Phep cong
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lay du lieu dau vao
                // Lay du lieu so thu nhat.
                double phanThucSo1 = double.Parse(phanThuc1.Text);
                double phanAoSo1 = double.Parse(phanAo1.Text);
                // Lay du lieu so thu hai
                double phanThucSo2 = double.Parse(phanThuc2.Text);
                double phanAoSo2 = double.Parse(phanAo2.Text);
                // Phan tinh toan ket qua:
                phanThucKetQua.Text = "" + (phanThucSo1 + phanThucSo2);
                PhanAoKetQua.Text = "" + (phanAoSo1 + phanAoSo2);
            } catch(Exception ex)
            {
                MessageBox.Show("Chi duoc nhap so.");
            }
            
        }
        // Phep tru so phuc thu nhat cho so phuc thu 2
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Lay du lieu dau vao
                // Lay du lieu so thu nhat.
                double phanThucSo1 = double.Parse(phanThuc1.Text);
                double phanAoSo1 = double.Parse(phanAo1.Text);
                // Lay du lieu so thu hai
                double phanThucSo2 = double.Parse(phanThuc2.Text);
                double phanAoSo2 = double.Parse(phanAo2.Text);
                // Phan tinh toan ket qua:
                phanThucKetQua.Text = "" + (phanThucSo1 - phanThucSo2);
                PhanAoKetQua.Text = "" + (phanAoSo1 - phanAoSo2);
            } catch (Exception ex)
            {
                MessageBox.Show("Chi duoc nhap so.");
            }
        }
        // Phep nhan so phuc thu nhat cho so phuc thu 2
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Lay du lieu dau vao
                // Lay du lieu so thu nhat.
                double phanThucSo1 = double.Parse(phanThuc1.Text);
                double phanAoSo1 = double.Parse(phanAo1.Text);
                // Lay du lieu so thu hai
                double phanThucSo2 = double.Parse(phanThuc2.Text);
                double phanAoSo2 = double.Parse(phanAo2.Text);
                // Phan tinh toan ket qua:
                phanThucKetQua.Text = "" + (phanThucSo1 * phanThucSo2 - phanAoSo1 * phanAoSo2);
                PhanAoKetQua.Text = "" + (phanThucSo1 * phanAoSo2 - phanThucSo2 * phanAoSo1);
            } catch (Exception ex)
            {
                MessageBox.Show("Chi duoc nhap so.");
            }
        }
        // Phep chia so thu nhat cho so thu 2
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Lay du lieu dau vao
                // Lay du lieu so thu nhat.
                double phanThucSo1 = double.Parse(phanThuc1.Text);
                double phanAoSo1 = double.Parse(phanAo1.Text);
                // Lay du lieu so thu hai
                double phanThucSo2 = double.Parse(phanThuc2.Text);
                double phanAoSo2 = double.Parse(phanAo2.Text);
                // Phan tinh toan ket qua:
                if (phanAoSo2 == 0 && phanThucSo2 == 0)
                {
                    MessageBox.Show("Loi chia cho 0!");
                    return;
                }
                phanThucKetQua.Text = "" + ((phanThucSo1 * phanThucSo1 + phanAoSo1 * phanAoSo2) / (phanAoSo2 * phanAoSo2 + phanThucSo2 * phanThucSo2));
                PhanAoKetQua.Text = "" + ((-phanThucSo1 * phanAoSo2 + phanAoSo1 * phanThucSo2) / (phanAoSo2 * phanAoSo2 + phanThucSo2 * phanThucSo2));
            } catch (Exception ex)
            {
                MessageBox.Show("Chi duoc nhap so.");
            }
        }
    }
}
