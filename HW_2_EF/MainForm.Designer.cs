namespace HW_2_EF
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button btnLogout;


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
            panelBackground = new Panel();
            lblWelcome = new Label();
            pictureBox = new PictureBox();
            btnUploadPhoto = new Button();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.BackColor = Color.FromArgb(34, 36, 49);
            panelBackground.Controls.Add(lblWelcome);
            panelBackground.Controls.Add(pictureBox);
            panelBackground.Controls.Add(btnUploadPhoto);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(380, 320);
            panelBackground.TabIndex = 0;
            panelBackground.Paint += panelBackground_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(50, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(300, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Добро пожаловать!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(115, 70);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(150, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = Color.FromArgb(88, 101, 242);
            btnUploadPhoto.Cursor = Cursors.Hand;
            btnUploadPhoto.FlatAppearance.BorderSize = 0;
            btnUploadPhoto.FlatStyle = FlatStyle.Flat;
            btnUploadPhoto.Font = new Font("Arial", 12F);
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.Location = new Point(50, 240);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(280, 40);
            btnUploadPhoto.TabIndex = 2;
            btnUploadPhoto.Text = "Обновить фото";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // btnLogout 
            // 
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogout.Location = new System.Drawing.Point(50, 300);
            this.btnLogout.Size = new System.Drawing.Size(280, 40);
            this.btnLogout.Text = "Выйти";
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(192, 57, 43); 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.panelBackground.Controls.Add(this.btnLogout); 

            // 
            // MainForm
            // 
            ClientSize = new Size(380, 400);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное окно";
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }
    }


}
