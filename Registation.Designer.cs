namespace WinFormsApp1
{
    partial class RegistationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtAdress = new TextBox();
            txtTelefon = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_reg = new Button();
            label5 = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 41);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(203, 73);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(203, 113);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(100, 23);
            txtAdress.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(203, 151);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 121);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Адрес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 159);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Телефон";
            // 
            // button_reg
            // 
            button_reg.Location = new Point(203, 304);
            button_reg.Name = "button_reg";
            button_reg.Size = new Size(100, 23);
            button_reg.TabIndex = 8;
            button_reg.Text = "Регистрация";
            button_reg.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 199);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(203, 191);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(203, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 238);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 12;
            label6.Text = "Пароль";
            // 
            // RegistationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label5);
            Controls.Add(button_reg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdress);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "RegistationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtAdress;
        private TextBox txtTelefon;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_reg;
        private Label label5;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label label6;
    }
}