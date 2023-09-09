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
    public partial class burn : Form
    {
        public burn()
        {
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="خامل")
            {
                double calory = (10 * Convert.ToDouble(numericUpDown1.Value) + 6.25 * Convert.ToDouble(numericUpDown3.Value) - 5 * Convert.ToDouble(numericUpDown2.Value)) * 1.2;
                label5.Text = calory.ToString() + " كيلو كالوري";
            }
            else if (comboBox1.SelectedItem == "قليل النشاط")
            {
                double calory = (10 * Convert.ToDouble(numericUpDown1.Value) + 6.25 * Convert.ToDouble(numericUpDown3.Value) - 5 * Convert.ToDouble(numericUpDown2.Value)) * 1.375;
                label5.Text = calory.ToString() + " كيلو كالوري";
            }
            else if(comboBox1.SelectedItem == "معتدل النشاط")
            {
                double calory = (10 * Convert.ToDouble(numericUpDown1.Value) + 6.25 * Convert.ToDouble(numericUpDown3.Value) - 5 * Convert.ToDouble(numericUpDown2.Value)) * 1.55;
                label5.Text = calory.ToString() + " كيلو كالوري";
            }
            else if (comboBox1.SelectedItem == "نشيط")
            {
                double calory = (10 * Convert.ToDouble(numericUpDown1.Value) + 6.25 * Convert.ToDouble(numericUpDown3.Value) - 5 * Convert.ToDouble(numericUpDown2.Value)) * 1.725;
                label5.Text = calory.ToString() + " كيلو كالوري";
            }
            else if (comboBox1.SelectedItem == "نشيط جدا")
            {
                double calory = (10 * Convert.ToDouble(numericUpDown1.Value) + 6.25 * Convert.ToDouble(numericUpDown3.Value) - 5 * Convert.ToDouble(numericUpDown2.Value) )* 1.9;
                label5.Text = calory.ToString() + " كيلو كالوري";
            }

        }

        private void burn_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.altibbi.com");
        }
    }
}
