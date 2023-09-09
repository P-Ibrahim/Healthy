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
    public partial class water : Form
    {
        public water()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(numericUpDown1.Value)*0.03;
            label3.Text = d.ToString() + " لتر يوميا ";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void water_Load(object sender, EventArgs e)
        {

        }
    }
}
