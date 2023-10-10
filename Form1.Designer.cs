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
            SuspendLayout();
            // 
            // radioButtonYears
            // 
            radioButtonYears.AutoSize = true;
            radioButtonYears.Location = new Point(129, 120);
            radioButtonYears.Name = "radioButtonYears";
            radioButtonYears.Size = new Size(94, 19);
            radioButtonYears.TabIndex = 0;
            radioButtonYears.TabStop = true;
            radioButtonYears.Text = "radioButton1";
            radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonths
            // 
            radioButtonMonths.AutoSize = true;
            radioButtonMonths.Location = new Point(129, 154);
            radioButtonMonths.Name = "radioButtonMonths";
            radioButtonMonths.Size = new Size(94, 19);
            radioButtonMonths.TabIndex = 1;
            radioButtonMonths.TabStop = true;
            radioButtonMonths.Text = "radioButton2";
            radioButtonMonths.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            radioButtonDays.AutoSize = true;
            radioButtonDays.Location = new Point(129, 188);
            radioButtonDays.Name = "radioButtonDays";
            radioButtonDays.Size = new Size(94, 19);
            radioButtonDays.TabIndex = 2;
            radioButtonDays.TabStop = true;
            radioButtonDays.Text = "radioButton3";
            radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinutes
            // 
            radioButtonMinutes.AutoSize = true;
            radioButtonMinutes.Location = new Point(129, 222);
            radioButtonMinutes.Name = "radioButtonMinutes";
            radioButtonMinutes.Size = new Size(94, 19);
            radioButtonMinutes.TabIndex = 3;
            radioButtonMinutes.TabStop = true;
            radioButtonMinutes.Text = "radioButton4";
            radioButtonMinutes.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeconds
            // 
            radioButtonSeconds.AutoSize = true;
            radioButtonSeconds.Location = new Point(129, 260);
            radioButtonSeconds.Name = "radioButtonSeconds";
            radioButtonSeconds.Size = new Size(94, 19);
            radioButtonSeconds.TabIndex = 4;
            radioButtonSeconds.TabStop = true;
            radioButtonSeconds.Text = "radioButton5";
            radioButtonSeconds.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(135, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}