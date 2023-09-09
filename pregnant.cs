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
    public partial class pregnant : Form
    {
        public pregnant()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            DateTime date = dateTimePicker1.Value;
            date = date.AddDays(280);
            label3.Text = date.ToShortDateString();
            int dnow = DateTime.Now.Day;
            dnow = dnow - dateTimePicker1.Value.Day;
            label5.Text = dnow.ToString()+" ايام";


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.altbbi.com");
        }
    }
}
