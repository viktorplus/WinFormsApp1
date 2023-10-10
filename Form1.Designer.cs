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
            radioButtonYears = new RadioButton();
            radioButtonMonths = new RadioButton();
            radioButtonDays = new RadioButton();
            radioButtonMinutes = new RadioButton();
            radioButtonSeconds = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // radioButtonYears
            // 
            radioButtonYears.AutoSize = true;
            radioButtonYears.Location = new Point(129, 120);
            radioButtonYears.Name = "radioButtonYears";
            radioButtonYears.Size = new Size(65, 19);
            radioButtonYears.TabIndex = 0;
            radioButtonYears.TabStop = true;
            radioButtonYears.Text = "В годах";
            radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonths
            // 
            radioButtonMonths.AutoSize = true;
            radioButtonMonths.Location = new Point(129, 154);
            radioButtonMonths.Name = "radioButtonMonths";
            radioButtonMonths.Size = new Size(81, 19);
            radioButtonMonths.TabIndex = 1;
            radioButtonMonths.TabStop = true;
            radioButtonMonths.Text = "В месяцах";
            radioButtonMonths.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            radioButtonDays.AutoSize = true;
            radioButtonDays.Location = new Point(129, 188);
            radioButtonDays.Name = "radioButtonDays";
            radioButtonDays.Size = new Size(60, 19);
            radioButtonDays.TabIndex = 2;
            radioButtonDays.TabStop = true;
            radioButtonDays.Text = "В днях";
            radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinutes
            // 
            radioButtonMinutes.AutoSize = true;
            radioButtonMinutes.Location = new Point(129, 222);
            radioButtonMinutes.Name = "radioButtonMinutes";
            radioButtonMinutes.Size = new Size(81, 19);
            radioButtonMinutes.TabIndex = 3;
            radioButtonMinutes.TabStop = true;
            radioButtonMinutes.Text = "В минутах";
            radioButtonMinutes.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeconds
            // 
            radioButtonSeconds.AutoSize = true;
            radioButtonSeconds.Location = new Point(129, 260);
            radioButtonSeconds.Name = "radioButtonSeconds";
            radioButtonSeconds.Size = new Size(84, 19);
            radioButtonSeconds.TabIndex = 4;
            radioButtonSeconds.TabStop = true;
            radioButtonSeconds.Text = "В секундах";
            radioButtonSeconds.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 171);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "Результат :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(341, 120);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 36);
            label2.Name = "label2";
            label2.Size = new Size(494, 15);
            label2.TabIndex = 8;
            label2.Text = "Укажите дату в формате День/Месяц/Год что бы расчитать время до текущего момента";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 314);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(radioButtonSeconds);
            Controls.Add(radioButtonMinutes);
            Controls.Add(radioButtonDays);
            Controls.Add(radioButtonMonths);
            Controls.Add(radioButtonYears);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonYears;
        private RadioButton radioButtonMonths;
        private RadioButton radioButtonDays;
        private RadioButton radioButtonMinutes;
        private RadioButton radioButtonSeconds;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
    }
}