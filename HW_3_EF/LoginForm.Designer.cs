namespace HW_3_EF
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelBackground;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            panelBackground = new Panel();
            panelBackground.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(50, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Вход в систему";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(40, 42, 55);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(50, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Имя пользователя";
            txtUsername.Size = new Size(280, 26);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(40, 42, 55);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(50, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(280, 26);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(88, 101, 242);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(280, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(46, 139, 87);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(50, 250);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(280, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelBackground
            // 
            panelBackground.BackColor = Color.FromArgb(34, 36, 49);
            panelBackground.Controls.Add(lblTitle);
            panelBackground.Controls.Add(txtUsername);
            panelBackground.Controls.Add(txtPassword);
            panelBackground.Controls.Add(btnLogin);
            panelBackground.Controls.Add(btnRegister);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(380, 330);
            panelBackground.TabIndex = 0;
            panelBackground.Paint += panelBackground_Paint;
            // 
            // LoginForm
            // 
            ClientSize = new Size(380, 330);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            ResumeLayout(false);
        }
    }


}