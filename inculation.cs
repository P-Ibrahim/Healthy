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

    public partial class inculation : Form
    {
        
        public inculation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            
            
            for (int i = 0; i < 8; i++)
            {
                if (i == 2)
                {

                    listView1.Items[i].Text = date.ToShortDateString();

                }
                else if (i == 4)
                {
                    listView1.Items[i].Text = date.ToShortDateString();
                }
                else if (i == 5)
                {                    
                    listView1.Items[i].Text = date.ToShortDateString();
                    date = date.AddMonths(5);
                }
                else if (i == 7)
                {
                    date = date.AddMonths(1);
                    listView1.Items[i-1].Text = date.ToShortDateString();

                }
                else
                {
                    listView1.Items[i].Text = date.ToShortDateString();
                    date = date.AddMonths(1);
                    
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inculation_Load(object sender, EventArgs e)
        {
           
        }
    }
}
