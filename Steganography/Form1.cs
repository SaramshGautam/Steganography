using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        kec_dbEntities _db = new kec_dbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            cboRole.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tblSteg tb = _db.tblStegs.Where(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text).FirstOrDefault();
            if (tb != null)
            {
                if (cboRole.SelectedIndex == 1)

                {
                    Program.username = txtUsername.Text;
                    LoginForm frm = new LoginForm();
                    frm.Show();
                    this.Hide();
                }
                else if(cboRole.SelectedIndex==2)
                {
                    Program.username = txtUsername.Text;
                    ExtractForm frm = new ExtractForm();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect!!!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Programmed by: \n Saramsh Gautam \n Sohan Pandey \n Subash Dahal \n Sweekar Dahal");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool mousedown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mouseX = Cursor.Position.X - 150;
                int mouseY = Cursor.Position.Y - 20;
                SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
