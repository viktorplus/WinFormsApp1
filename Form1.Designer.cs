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
            label1 = new Label();
            lastname = new TextBox();
            button1 = new Button();
            name = new TextBox();
            label2 = new Label();
            vatername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            sex = new ComboBox();
            datebirhday = new DateTimePicker();
            label5 = new Label();
            familystatus = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            info = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // lastname
            // 
            lastname.Location = new Point(233, 24);
            lastname.Name = "lastname";
            lastname.Size = new Size(199, 23);
            lastname.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(233, 312);
            button1.Name = "button1";
            button1.Size = new Size(199, 23);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.Location = new Point(233, 53);
            name.Name = "name";
            name.Size = new Size(199, 23);
            name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 61);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Имя";
            // 
            // vatername
            // 
            vatername.Location = new Point(233, 82);
            vatername.Name = "vatername";
            vatername.Size = new Size(199, 23);
            vatername.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 90);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 119);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Пол";
            // 
            // sex
            // 
            sex.FormattingEnabled = true;
            sex.Location = new Point(233, 111);
            sex.Name = "sex";
            sex.Size = new Size(199, 23);
            sex.TabIndex = 8;
            // 
            // datebirhday
            // 
            datebirhday.Location = new Point(232, 140);
            datebirhday.Name = "datebirhday";
            datebirhday.Size = new Size(200, 23);
            datebirhday.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 148);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 10;
            label5.Text = "Дата рождения";
            // 
            // familystatus
            // 
            familystatus.FormattingEnabled = true;
            familystatus.Location = new Point(233, 169);
            familystatus.Name = "familystatus";
            familystatus.Size = new Size(199, 23);
            familystatus.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 177);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 11;
            label6.Text = "Семейный статус";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 230);
            label7.Name = "label7";
            label7.Size = new Size(175, 15);
            label7.TabIndex = 14;
            label7.Text = "Дополнительная информация";
            // 
            // info
            // 
            info.Location = new Point(233, 207);
            info.Multiline = true;
            info.Name = "info";
            info.Size = new Size(199, 84);
            info.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(info);
            Controls.Add(label7);
            Controls.Add(familystatus);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(datebirhday);
            Controls.Add(sex);
            Controls.Add(label4);
            Controls.Add(vatername);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lastname);
            Controls.Add(label1);
            MaximumSize = new Size(720, 480);
            Name = "Form1";
            Text = "Анкета в файл";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lastname;
        private Button button1;
        private TextBox name;
        private Label label2;
        private TextBox vatername;
        private Label label3;
        private Label label4;
        private ComboBox sex;
        private DateTimePicker datebirhday;
        private Label label5;
        private ComboBox familystatus;
        private Label label6;
        private Label label7;
        private TextBox info;
    }
}