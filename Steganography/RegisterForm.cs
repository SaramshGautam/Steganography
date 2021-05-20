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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        kec_dbEntities _db = new kec_dbEntities();
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtFullname.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                MessageBox.Show("Fullname Required!!!");
                txtFullname.Focus();
            }
            else
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Username Required!!!");
                    txtUsername.Focus();
                }
                else
                {
                    if (txtEmail.Text == "")
                    {
                        MessageBox.Show("Email Required!!!");
                        txtEmail.Focus();
                    }
                    else
                    {
                        if (txtPassword.Text == "")
                        {
                            MessageBox.Show("Enter Password!!!");
                            txtPassword.Focus();
                        }
                        else
                        {

                            if (txtPassword.Text == txtRepassword.Text)
                            {
                                tblSteg tb = new tblSteg();
                                tb.Fullname = txtFullname.Text;
                                tb.Username = txtUsername.Text;
                                tb.Email = txtEmail.Text;
                                tb.Password = txtPassword.Text;
                                _db.tblStegs.Add(tb);
                                _db.SaveChanges();

                                MessageBox.Show("User Registered!!!");
                                ClearControls();
                            }
                            else
                            {
                                MessageBox.Show("Password Mismatch!!!");
                            }
                        }
                    }
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtFullname.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtRepassword.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        bool mousedown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = false;
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }


       
    }
}
