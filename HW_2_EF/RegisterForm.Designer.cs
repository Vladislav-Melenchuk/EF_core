namespace HW_2_EF
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label lblPhotoStatus;

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
            btnRegister = new Button();
            btnSelectImage = new Button();
            lblPhotoStatus = new Label();
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
            lblTitle.Text = "Регистрация";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
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
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(88, 101, 242);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(50, 280);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(280, 40);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSelectImage
            // 
            btnSelectImage.BackColor = Color.FromArgb(46, 139, 87);
            btnSelectImage.Cursor = Cursors.Hand;
            btnSelectImage.FlatAppearance.BorderSize = 0;
            btnSelectImage.FlatStyle = FlatStyle.Flat;
            btnSelectImage.Font = new Font("Arial", 12F);
            btnSelectImage.ForeColor = Color.White;
            btnSelectImage.Location = new Point(50, 200);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(280, 40);
            btnSelectImage.TabIndex = 4;
            btnSelectImage.Text = "Выбрать фото (необязательно)";
            btnSelectImage.UseVisualStyleBackColor = false;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // lblPhotoStatus
            // 
            lblPhotoStatus.Font = new Font("Arial", 10F);
            lblPhotoStatus.ForeColor = Color.Gray;
            lblPhotoStatus.Location = new Point(50, 250);
            lblPhotoStatus.Name = "lblPhotoStatus";
            lblPhotoStatus.Size = new Size(280, 20);
            lblPhotoStatus.TabIndex = 5;
            lblPhotoStatus.Text = "Фото не выбрано";
            lblPhotoStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBackground
            // 
            panelBackground.BackColor = Color.FromArgb(34, 36, 49);
            panelBackground.Controls.Add(lblTitle);
            panelBackground.Controls.Add(txtUsername);
            panelBackground.Controls.Add(txtPassword);
            panelBackground.Controls.Add(btnRegister);
            panelBackground.Controls.Add(btnSelectImage);
            panelBackground.Controls.Add(lblPhotoStatus);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(380, 360);
            panelBackground.TabIndex = 0;
            panelBackground.Paint += panelBackground_Paint;
            // 
            // RegisterForm
            // 
            ClientSize = new Size(380, 360);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            ResumeLayout(false);
        }
    }


}
