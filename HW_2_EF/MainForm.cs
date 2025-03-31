using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2_EF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string username;

        public MainForm(string username, byte[] profilePicture)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = $"Добро пожаловать, {username}!";

            if (profilePicture != null)
            {
                using (var ms = new MemoryStream(profilePicture))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] newPicture = File.ReadAllBytes(openFileDialog.FileName);
                Database.UpdateProfilePicture(username, newPicture);

                using (var ms = new MemoryStream(newPicture))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }

                MessageBox.Show("Фото обновлено!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); 
            this.Close(); 
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
