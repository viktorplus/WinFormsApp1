using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Guds guds;
        Oils oils;
        CheckBox[] checkBoxes; // Массив для CheckBox
        TextBox[] textBoxes; // Массив для TextBox
        TextBox[] textBoxesPrice; // Массив для TextBox


        public Form1()
        {
            InitializeComponent();
            guds = new Guds();
            oils = new Oils();
            // Инициализация массивов
            checkBoxes = new CheckBox[] { cb_hotdog, cb_gamburger, cb_fri, cb_kola };
            textBoxes = new TextBox[] { tb_hotdog_count, tb_gamburger_count, tb_fri_count, tb_kola_count };
            textBoxesPrice = new TextBox[] { tb_hotdog_price, tb_gamburger_price, tb_fri_price, tb_cola_price };
            // Подписываем все CheckBox на одно событие
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
            // Подписываем все TextBox на одно событие
            foreach (TextBox textBox in textBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guds.gud.Add(new Gud("Хот Дог", 0, 4));
            guds.gud.Add(new Gud("Гамбургер", 0, 5.4));
            guds.gud.Add(new Gud("Картошка Фри", 0, 7.2));
            guds.gud.Add(new Gud("Кока Кола", 0, 4.4));

            oils.oil.Add(new Oil("A-76", 0, 6.4));
            oils.oil.Add(new Oil("A-92", 0, 7.5));
            oils.oil.Add(new Oil("A-95", 0, 8.6));
            oils.oil.Add(new Oil("A-100", 0, 9.9));

            comboBox_oil.Items.Clear(); // Очищаем существующие элементы, если есть
            foreach (Oil oil in oils.oil)
            {
                comboBox_oil.Items.Add(oil.Name); // Добавляем название варианта в ComboBox
            }


            for (int i = 0; i < checkBoxes.Length; i++)
            {
                textBoxes[i].Text = guds.gud[i].Count.ToString();
                textBoxesPrice[i].Text = guds.gud[i].Price.ToString();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int index = Array.IndexOf(checkBoxes, checkBox);
            if (index >= 0)
            {
                textBoxes[index].Enabled = checkBox.Checked;
                if (!checkBox.Checked)
                {
                    // Если CheckBox выключен, устанавливаем значение в связанном TextBox в 0
                    textBoxes[index].Text = "0";
                }
                GudSumm();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int index = Array.IndexOf(textBoxes, textBox);
            if (index >= 0 && int.TryParse(textBox.Text, out int targetNumber))
            {
                guds.gud[index].SetCount(targetNumber);
                GudSumm();
            }
        }
        private void GudSumm()
        {
            double gudsumm = 0;
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked) // Проверяем, включен ли CheckBox
                {
                    gudsumm += guds.gud[i].Summa;
                }
            }
            lb_kafe_price.Text = gudsumm.ToString();
        }

        private void comboBox_oil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
