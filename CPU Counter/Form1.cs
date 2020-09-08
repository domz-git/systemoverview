using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;




namespace CPU_Counter
{
    public partial class Form1 : Form
    {
        int a = 10;

        public Form1()
        {
             InitializeComponent();
            panel1.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = "TOTAL CPU USAGE: " + performanceCounter1.NextValue().ToString("0") + " %";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl2.Text = "CORE#1: " + performanceCounter2.NextValue().ToString("0") + " %";
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            lbl3.Text = "CORE#2: " + performanceCounter3.NextValue().ToString("0") + " %";
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            lbl4.Text = "CORE#3: " + performanceCounter4.NextValue().ToString("0") + " %";
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            lbl5.Text = "CORE#4: " + performanceCounter5.NextValue().ToString("0") + " %";
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            lbl6.Text = "Free RAM: " + performanceCounter6.NextValue() + " MB";
        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            float s = performanceCounter8.NextValue();

            int ss = (int)s;

            TimeSpan t = TimeSpan.FromSeconds(ss);

            lbl8.Text = "System up time: " + t.ToString();
        }
        private void timer9_Tick(object sender, EventArgs e)
        {
            lbl9.Text = "Active Processes: " + performanceCounter9.NextValue();
        }
        private void timer10_Tick(object sender, EventArgs e)
        {
            lbl10.Text = "Threads: " + performanceCounter10.NextValue();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            SaveFileDialog spremi = new SaveFileDialog();

            spremi.Title = "Save file";
            spremi.Filter = "Text Files (*.txt) |*.txt";


            if (spremi.ShowDialog() == DialogResult.OK){

                StreamWriter write = new StreamWriter(File.Create(spremi.FileName));

                write.Write(lbl1.Text );
                write.Write(lbl2.Text );
                write.Write(lbl3.Text );
                write.Write(lbl4.Text );
                write.Write(lbl5.Text );
                write.Write(lbl6.Text );
                write.Write(lbl8.Text );
                write.Write(lbl9.Text );
                write.Write(lbl10.Text );




                write.Dispose();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                timer8.Enabled = false;
                timer9.Enabled = false;
                timer10.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                timer5.Enabled = true;
                timer6.Enabled = true;
                timer8.Enabled = true;
                timer9.Enabled = true;
                timer10.Enabled = true;


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("upis.txt");
            sr.Write(lbl1.Text+","+lbl2.Text+","+lbl3.Text+","+lbl4.Text+","+lbl5.Text+","+lbl6.Text+","+lbl8.Text+","+lbl9.Text+","+lbl10.Text);
            sr.Close();
            MessageBox.Show("Spremljeno!");

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napravio Dominik Filipović\n");
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The System Overview v1.3® prikazuje podatke vašeg sistema uz opciju \nspremanja i pauziranja vrijednosti.");
        }

        private void versionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v1.0 Očitavanje vrijednosti\nv1.1 Uvedena opcija pauziranja i pokretanja\nv1.2 Uvedena opcija spremanja\nv1.3 Uveden menu strip za dodatne informacije");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pritiskom na tipku STOP zaustavljate brojače vrijednosti\na tipkom RUN ponovo ih pokrećete.\nPodatke možete spremiti na dva načina, File/save ili pritiskom na tipku SAVE, gdje odabirete ime podataka koje spremate i odabirete odredište.");
        }

        string procitano;
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader("upis.txt");
                MessageBox.Show(procitano, "Spremljani podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                procitano = sr.ReadToEnd();

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepostojeća datoteka!", "Greška!");
            }


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        

        private void timer11_Tick(object sender, EventArgs e)
        {

            a = a - 1;

           if (a == 0)
            {
                panel1.Visible = false;
            }

        }

        private void totalUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void cORE1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.Show();
        }

        private void cORE2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();
        }

        private void cORE3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.Show();
        }

        private void cORE4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Show();
        }

        private void hDDInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();

            f7.Show();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
           bool a1 = Environment.Is64BitOperatingSystem;

            if(a1 == true)
            {
                label1.Text = "Operating System: 64-bit";

            }

            else
            {

                label1.Text = "Operating System: 32-bit";
            }
        }

        
    }
    }
    

    

