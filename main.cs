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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            water w = new water();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weight we = new weight();
            we.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inculation inc = new inculation();
            inc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            burn b = new burn();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calories c = new calories();
            c.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pregnant p = new pregnant();
            p.Show(); 
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
