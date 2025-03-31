using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_3_EF
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (Database.ValidateUser(username, password, out byte[] profilePicture))
            {
                MainForm mainForm = new MainForm(username, profilePicture);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
