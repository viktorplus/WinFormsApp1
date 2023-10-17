namespace WinFormsApp1
{
    public partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_login = new Label();
            label_password = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            button_login = new Button();
            button_registration = new Button();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Location = new Point(51, 75);
            label_login.Name = "label_login";
            label_login.Size = new Size(41, 15);
            label_login.TabIndex = 0;
            label_login.Text = "Логин";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(51, 129);
            label_password.Name = "label_password";
            label_password.Size = new Size(49, 15);
            label_password.TabIndex = 1;
            label_password.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(138, 67);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(173, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(138, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 3;
            // 
            // button_login
            // 
            button_login.Location = new Point(51, 198);
            button_login.Name = "button_login";
            button_login.Size = new Size(118, 23);
            button_login.TabIndex = 4;
            button_login.Text = "Войти";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += Login_Click;
            // 
            // button_registration
            // 
            button_registration.Location = new Point(192, 198);
            button_registration.Name = "button_registration";
            button_registration.Size = new Size(119, 23);
            button_registration.TabIndex = 5;
            button_registration.Text = "Регистрация";
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += Loginbutton_registration_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 280);
            Controls.Add(button_registration);
            Controls.Add(button_login);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label_password);
            Controls.Add(label_login);
            Name = "LoginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_login;
        private Label label_password;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button button_login;
        private Button button_registration;
    }
}