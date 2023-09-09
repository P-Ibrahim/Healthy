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
    public partial class calories : Form
    {
        public calories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory = 10 * Convert.ToDouble(numericUpDown1.Value) + 6.25 * Convert.ToDouble(numericUpDown3.Value) - 5 * Convert.ToDouble(numericUpDown2.Value);
            label5.Text = calory.ToString() + " كيلو كالوري";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
