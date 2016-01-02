using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGMTtime.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime thisDay = DateTime.Today;
            label1.Text = thisDay.ToString("d");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
