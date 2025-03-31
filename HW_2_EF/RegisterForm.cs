namespace HW_2_EF
{
    public partial class RegisterForm : Form
    {

        private byte[] profilePicture;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profilePicture = File.ReadAllBytes(openFileDialog.FileName);
                MessageBox.Show("���� �������!");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (Database.UserExists(username))
            {
                MessageBox.Show("������������ ��� ����������!");
                return;
            }

            Database.RegisterUser(username, password, profilePicture);
            MessageBox.Show("����������� �������!");

            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
