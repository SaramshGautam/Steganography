using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Steganography
{
    public partial class TitlePage : Form
    {
        

        public TitlePage()
        {
            InitializeComponent();

            
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void TitlePage_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void TitlePage_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        int counter = 0;
        int len = 0;
        string text;
        private void TitlePage_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
           // label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;

            //label2.Hide();
            label3.Hide();
            text = label1.Text;
            len = text.Length;
            label1.Text = "_";
            
            
            
            timer1.Start();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = text.Substring(0, counter);
            ++counter;

            if (counter > len)
            {
                timer1.Stop();
                label3.Show();
                //label2.Show();
                
                timer2.Start();
            }
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            //Random rand = new Random();
            //int A = rand.Next(0, 255);
            //int R = rand.Next(0, 255);
            //int G = rand.Next(0, 255);
            //int B = rand.Next(0, 255);
            //label2.ForeColor = Color.FromArgb(A, 0, 0, B);

            timer2.Stop();
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
            //if (label2.Enabled == true)
            //{
                
            //    label2.Hide();
            //    label2.Enabled = false;

            //}
            //else
            //{
                
            //    label2.Show();
            //    label2.Enabled = true;
            //}
               
        }
    }
}
