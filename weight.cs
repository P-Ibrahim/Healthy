using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthy
{
    public partial class weight : Form
    {
        public weight()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = (Convert.ToDouble(numericUpDown1.Value) - 150);
            if (radioButton1.Checked == true)
            {
                label3.Text = (d * 1.1 + 48).ToString();
            }
            else if (radioButton2.Checked == true)
            {
                label3.Text = (d * 0.9 + 45).ToString();
            }
            else
                MessageBox.Show("اختر النوع");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //double d = (Convert.ToDouble(numericUpDown1.Value) - 150);
            //label3.Text = (d * 1.1 + 48).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //double d = (Convert.ToDouble(numericUpDown1.Value) - 150);
            //label3.Text = (d * 1.1 + 45).ToString()+" كيلوجرام ";
        }

        private void weight_Load(object sender, EventArgs e)
        {

        }
    }
}
