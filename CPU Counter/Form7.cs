using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPU_Counter
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Disk time: " + performanceCounter1.NextValue().ToString("0.0") + " %";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "Disk read time: " + performanceCounter2.NextValue().ToString("0.0") + " %";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Text = "Disk write time: " + performanceCounter3.NextValue().ToString("0.0") + " %";
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label4.Text = "Disk idle time: " + performanceCounter4.NextValue().ToString("0.0") + " %";
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label5.Text = "Bytes read: " + performanceCounter5.NextValue().ToString("0");
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label6.Text = "Bytes written: " + performanceCounter6.NextValue().ToString("0");
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            label7.Text = "Split IO/sec: " + performanceCounter7.NextValue().ToString("0") + " %";
        }
    }
}
