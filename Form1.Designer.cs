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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label5 = new Label();
            groupBox6 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            tb_oil_sum = new TextBox();
            tb_oil_count = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            tb_oil_price = new TextBox();
            label1 = new Label();
            comboBox_oil = new ComboBox();
            gb_select_type = new GroupBox();
            lb_oil_amount = new Label();
            lb_oil_price = new Label();
            groupBox2 = new GroupBox();
            tb_kola_count = new TextBox();
            tb_cola_price = new TextBox();
            tb_fri_count = new TextBox();
            tb_fri_price = new TextBox();
            tb_gamburger_count = new TextBox();
            tb_gamburger_price = new TextBox();
            tb_hotdog_count = new TextBox();
            tb_hotdog_price = new TextBox();
            label13 = new Label();
            label12 = new Label();
            cb_kola = new CheckBox();
            cb_fri = new CheckBox();
            cb_gamburger = new CheckBox();
            cb_hotdog = new CheckBox();
            groupBox4 = new GroupBox();
            label8 = new Label();
            lb_kafe_price = new Label();
            groupBox5 = new GroupBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lb_sum = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            gb_select_type.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_oil_price);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox_oil);
            groupBox1.Controls.Add(gb_select_type);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 94);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 8;
            label5.Text = "грн.";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(tb_oil_sum);
            groupBox6.Controls.Add(tb_oil_count);
            groupBox6.Controls.Add(radioButton1);
            groupBox6.Controls.Add(radioButton2);
            groupBox6.Location = new Point(20, 116);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(322, 80);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 57);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 10;
            label4.Text = "грн.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 26);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 9;
            label3.Text = "л.";
            // 
            // tb_oil_sum
            // 
            tb_oil_sum.Enabled = false;
            tb_oil_sum.Location = new Point(146, 51);
            tb_oil_sum.Name = "tb_oil_sum";
            tb_oil_sum.Size = new Size(100, 23);
            tb_oil_sum.TabIndex = 8;
            // 
            // tb_oil_count
            // 
            tb_oil_count.Enabled = false;
            tb_oil_count.Location = new Point(146, 18);
            tb_oil_count.Name = "tb_oil_count";
            tb_oil_count.Size = new Size(100, 23);
            tb_oil_count.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Количество";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 55);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Сумма";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // tb_oil_price
            // 
            tb_oil_price.Location = new Point(166, 86);
            tb_oil_price.Name = "tb_oil_price";
            tb_oil_price.Size = new Size(100, 23);
            tb_oil_price.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Бензин";
            // 
            // comboBox_oil
            // 
            comboBox_oil.FormattingEnabled = true;
            comboBox_oil.Location = new Point(166, 45);
            comboBox_oil.Name = "comboBox_oil";
            comboBox_oil.Size = new Size(100, 23);
            comboBox_oil.TabIndex = 1;
            comboBox_oil.SelectedIndexChanged += comboBox_oil_SelectedIndexChanged;
            // 
            // gb_select_type
            // 
            gb_select_type.Controls.Add(lb_oil_amount);
            gb_select_type.Controls.Add(lb_oil_price);
            gb_select_type.Location = new Point(20, 202);
            gb_select_type.Name = "gb_select_type";
            gb_select_type.Size = new Size(322, 94);
            gb_select_type.TabIndex = 0;
            gb_select_type.TabStop = false;
            gb_select_type.Text = "К оплате";
            // 
            // lb_oil_amount
            // 
            lb_oil_amount.AutoSize = true;
            lb_oil_amount.Location = new Point(266, 51);
            lb_oil_amount.Name = "lb_oil_amount";
            lb_oil_amount.Size = new Size(29, 15);
            lb_oil_amount.TabIndex = 11;
            lb_oil_amount.Text = "грн.";
            // 
            // lb_oil_price
            // 
            lb_oil_price.AutoSize = true;
            lb_oil_price.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_oil_price.Location = new Point(146, 33);
            lb_oil_price.Name = "lb_oil_price";
            lb_oil_price.Size = new Size(68, 37);
            lb_oil_price.TabIndex = 0;
            lb_oil_price.Text = "0,00";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_kola_count);
            groupBox2.Controls.Add(tb_cola_price);
            groupBox2.Controls.Add(tb_fri_count);
            groupBox2.Controls.Add(tb_fri_price);
            groupBox2.Controls.Add(tb_gamburger_count);
            groupBox2.Controls.Add(tb_gamburger_price);
            groupBox2.Controls.Add(tb_hotdog_count);
            groupBox2.Controls.Add(tb_hotdog_price);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cb_kola);
            groupBox2.Controls.Add(cb_fri);
            groupBox2.Controls.Add(cb_gamburger);
            groupBox2.Controls.Add(cb_hotdog);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(421, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 323);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "МиниКафе";
            // 
            // tb_kola_count
            // 
            tb_kola_count.Enabled = false;
            tb_kola_count.Location = new Point(242, 141);
            tb_kola_count.Name = "tb_kola_count";
            tb_kola_count.Size = new Size(100, 23);
            tb_kola_count.TabIndex = 15;
            tb_kola_count.Text = "0";
            tb_kola_count.TextChanged += TextBox_TextChanged;
            // 
            // tb_cola_price
            // 
            tb_cola_price.Enabled = false;
            tb_cola_price.Location = new Point(133, 141);
            tb_cola_price.Name = "tb_cola_price";
            tb_cola_price.Size = new Size(100, 23);
            tb_cola_price.TabIndex = 14;
            // 
            // tb_fri_count
            // 
            tb_fri_count.Enabled = false;
            tb_fri_count.Location = new Point(242, 116);
            tb_fri_count.Name = "tb_fri_count";
            tb_fri_count.Size = new Size(100, 23);
            tb_fri_count.TabIndex = 13;
            tb_fri_count.Text = "0";
            tb_fri_count.TextChanged += TextBox_TextChanged;
            // 
            // tb_fri_price
            // 
            tb_fri_price.Enabled = false;
            tb_fri_price.Location = new Point(133, 116);
            tb_fri_price.Name = "tb_fri_price";
            tb_fri_price.Size = new Size(100, 23);
            tb_fri_price.TabIndex = 12;
            // 
            // tb_gamburger_count
            // 
            tb_gamburger_count.Enabled = false;
            tb_gamburger_count.Location = new Point(242, 91);
            tb_gamburger_count.Name = "tb_gamburger_count";
            tb_gamburger_count.Size = new Size(100, 23);
            tb_gamburger_count.TabIndex = 11;
            tb_gamburger_count.Text = "0";
            tb_gamburger_count.TextChanged += TextBox_TextChanged;
            // 
            // tb_gamburger_price
            // 
            tb_gamburger_price.Enabled = false;
            tb_gamburger_price.Location = new Point(133, 91);
            tb_gamburger_price.Name = "tb_gamburger_price";
            tb_gamburger_price.Size = new Size(100, 23);
            tb_gamburger_price.TabIndex = 10;
            // 
            // tb_hotdog_count
            // 
            tb_hotdog_count.Enabled = false;
            tb_hotdog_count.Location = new Point(242, 66);
            tb_hotdog_count.Name = "tb_hotdog_count";
            tb_hotdog_count.Size = new Size(100, 23);
            tb_hotdog_count.TabIndex = 9;
            tb_hotdog_count.Text = "0";
            tb_hotdog_count.TextChanged += TextBox_TextChanged;
            // 
            // tb_hotdog_price
            // 
            tb_hotdog_price.Enabled = false;
            tb_hotdog_price.Location = new Point(133, 66);
            tb_hotdog_price.Name = "tb_hotdog_price";
            tb_hotdog_price.Size = new Size(100, 23);
            tb_hotdog_price.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(254, 45);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 7;
            label13.Text = "Количество";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(146, 45);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 6;
            label12.Text = "Цена";
            // 
            // cb_kola
            // 
            cb_kola.AutoSize = true;
            cb_kola.Location = new Point(23, 145);
            cb_kola.Name = "cb_kola";
            cb_kola.Size = new Size(82, 19);
            cb_kola.TabIndex = 5;
            cb_kola.Text = "Кока Кола";
            cb_kola.UseVisualStyleBackColor = true;
            cb_kola.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // cb_fri
            // 
            cb_fri.AutoSize = true;
            cb_fri.Location = new Point(23, 120);
            cb_fri.Name = "cb_fri";
            cb_fri.Size = new Size(107, 19);
            cb_fri.TabIndex = 4;
            cb_fri.Text = "Картошка Фри";
            cb_fri.UseVisualStyleBackColor = true;
            cb_fri.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // cb_gamburger
            // 
            cb_gamburger.AutoSize = true;
            cb_gamburger.Location = new Point(23, 95);
            cb_gamburger.Name = "cb_gamburger";
            cb_gamburger.Size = new Size(85, 19);
            cb_gamburger.TabIndex = 3;
            cb_gamburger.Text = "Гамбургер";
            cb_gamburger.UseVisualStyleBackColor = true;
            cb_gamburger.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // cb_hotdog
            // 
            cb_hotdog.AutoSize = true;
            cb_hotdog.Location = new Point(23, 70);
            cb_hotdog.Name = "cb_hotdog";
            cb_hotdog.Size = new Size(68, 19);
            cb_hotdog.TabIndex = 2;
            cb_hotdog.Text = "Хот Дог";
            cb_hotdog.UseVisualStyleBackColor = true;
            cb_hotdog.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(lb_kafe_price);
            groupBox4.Location = new Point(23, 203);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(319, 93);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "К оплате";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(263, 50);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 13;
            label8.Text = "грн.";
            // 
            // lb_kafe_price
            // 
            lb_kafe_price.AutoSize = true;
            lb_kafe_price.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kafe_price.Location = new Point(143, 32);
            lb_kafe_price.Name = "lb_kafe_price";
            lb_kafe_price.Size = new Size(68, 37);
            lb_kafe_price.TabIndex = 12;
            lb_kafe_price.Text = "0,00";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(pictureBox1);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(lb_sum);
            groupBox5.Controls.Add(button1);
            groupBox5.Location = new Point(12, 359);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(776, 117);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Всего к оплате";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ico;
            pictureBox1.Location = new Point(26, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(613, 58);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 13;
            label10.Text = "грн.";
            // 
            // lb_sum
            // 
            lb_sum.AutoSize = true;
            lb_sum.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_sum.Location = new Point(466, 40);
            lb_sum.Name = "lb_sum";
            lb_sum.Size = new Size(68, 37);
            lb_sum.TabIndex = 12;
            lb_sum.Text = "0,00";
            // 
            // button1
            // 
            button1.Location = new Point(210, 42);
            button1.Name = "button1";
            button1.Size = new Size(157, 46);
            button1.TabIndex = 0;
            button1.Text = "Просчитать";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Best Oil";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            gb_select_type.ResumeLayout(false);
            gb_select_type.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox gb_select_type;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private RadioButton radioButton1;
        private Label label2;
        private TextBox tb_oil_price;
        private Label label1;
        private ComboBox comboBox_oil;
        private RadioButton radioButton2;
        private Label label5;
        private GroupBox groupBox6;
        private Label label4;
        private Label label3;
        private TextBox tb_oil_sum;
        private TextBox tb_oil_count;
        private Label lb_oil_price;
        private Label lb_oil_amount;
        private TextBox tb_hotdog_price;
        private Label label13;
        private Label label12;
        private CheckBox cb_kola;
        private CheckBox cb_fri;
        private CheckBox cb_gamburger;
        private CheckBox cb_hotdog;
        private Label label8;
        private Label lb_kafe_price;
        private Label label10;
        private Label lb_sum;
        private Button button1;
        private TextBox tb_hotdog_count;
        private TextBox tb_kola_count;
        private TextBox tb_cola_price;
        private TextBox tb_fri_count;
        private TextBox tb_fri_price;
        private TextBox tb_gamburger_count;
        private TextBox tb_gamburger_price;
        private PictureBox pictureBox1;
    }
}