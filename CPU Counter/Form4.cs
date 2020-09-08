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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float c = performanceCounter1.NextValue();
            int a = (int)c;

            progressBar1.Value = a;

            chart1.Series["Series1"].Points.AddY(a);
        }
    }
}
