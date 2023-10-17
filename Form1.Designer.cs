namespace WinFormsApp1
{
    partial class Form1
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
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExportText = new Button();
            btnImportText = new Button();
            btnExportXML = new Button();
            btnImportXML = new Button();
            lstUsers = new ListBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(165, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 23);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(165, 87);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(163, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(165, 172);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(163, 23);
            txtPhone.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(40, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(143, 225);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 53);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 136);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 9;
            label3.Text = "e-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 180);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Телефон";
            // 
            // btnExportText
            // 
            btnExportText.Location = new Point(40, 291);
            btnExportText.Name = "btnExportText";
            btnExportText.Size = new Size(150, 38);
            btnExportText.TabIndex = 11;
            btnExportText.Text = "Экспорт в текстовый файл";
            btnExportText.UseVisualStyleBackColor = true;
            btnExportText.Click += btnExportText_Click;
            // 
            // btnImportText
            // 
            btnImportText.Location = new Point(196, 291);
            btnImportText.Name = "btnImportText";
            btnImportText.Size = new Size(151, 38);
            btnImportText.TabIndex = 12;
            btnImportText.Text = "Импорт из текстового файла";
            btnImportText.UseVisualStyleBackColor = true;
            btnImportText.Click += btnImportText_Click;
            // 
            // btnExportXML
            // 
            btnExportXML.Location = new Point(40, 355);
            btnExportXML.Name = "btnExportXML";
            btnExportXML.Size = new Size(150, 23);
            btnExportXML.TabIndex = 13;
            btnExportXML.Text = "Экспорт в XML файл";
            btnExportXML.UseVisualStyleBackColor = true;
            btnExportXML.Click += btnExportXML_Click;
            // 
            // btnImportXML
            // 
            btnImportXML.Location = new Point(196, 355);
            btnImportXML.Name = "btnImportXML";
            btnImportXML.Size = new Size(151, 23);
            btnImportXML.TabIndex = 14;
            btnImportXML.Text = "Импорт из XML файла";
            btnImportXML.UseVisualStyleBackColor = true;
            btnImportXML.Click += btnImportXML_Click;
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new Point(374, 44);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(397, 334);
            lstUsers.TabIndex = 15;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstUsers);
            Controls.Add(btnImportXML);
            Controls.Add(btnExportXML);
            Controls.Add(btnImportText);
            Controls.Add(btnExportText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Контакты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnExportText;
        private Button btnImportText;
        private Button btnExportXML;
        private Button btnImportXML;
        private ListBox lstUsers;
    }
}