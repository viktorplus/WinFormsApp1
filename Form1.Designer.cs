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
            monthCalendar = new MonthCalendar();
            year = new TextBox();
            month = new TextBox();
            day = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(501, 88);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // year
            // 
            year.Location = new Point(345, 159);
            year.Name = "year";
            year.Size = new Size(97, 23);
            year.TabIndex = 1;
            // 
            // month
            // 
            month.Location = new Point(221, 159);
            month.Name = "month";
            month.Size = new Size(100, 23);
            month.TabIndex = 2;
            // 
            // day
            // 
            day.Location = new Point(96, 159);
            day.Name = "day";
            day.Size = new Size(100, 23);
            day.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 132);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 132);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Месяц";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 132);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 6;
            label3.Text = "Год";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 88);
            label4.Name = "label4";
            label4.Size = new Size(265, 15);
            label4.TabIndex = 7;
            label4.Text = "Ввидите дату рождения в текстовые поля ниже";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 317);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(day);
            Controls.Add(month);
            Controls.Add(year);
            Controls.Add(monthCalendar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private TextBox year;
        private TextBox month;
        private TextBox day;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}