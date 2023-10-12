using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Guds guds;
        Oils oils;
        CheckBox[] checkBoxes; // ������ ��� CheckBox
        TextBox[] textBoxes; // ������ ��� TextBox
        TextBox[] textBoxesPrice; // ������ ��� TextBox

        private double oilLiters = 0; // ���������� ������� ���������� ������
        private double oilPrice = 0;  // ���������� ������� ����� � ������
        private double gudsumm = 0; // ����� ����� �� ���������

        public Form1()
        {
            InitializeComponent();
            guds = new Guds();
            oils = new Oils();
            // ������������� ��������
            checkBoxes = new CheckBox[] { cb_hotdog, cb_gamburger, cb_fri, cb_kola };
            textBoxes = new TextBox[] { tb_hotdog_count, tb_gamburger_count, tb_fri_count, tb_kola_count };
            textBoxesPrice = new TextBox[] { tb_hotdog_price, tb_gamburger_price, tb_fri_price, tb_cola_price };
            // ����������� ��� CheckBox �� ���� �������
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
            // ����������� ��� TextBox �� ���� �������
            foreach (TextBox textBox in textBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guds.gud.Add(new Gud("��� ���", 0, 4));
            guds.gud.Add(new Gud("���������", 0, 5.4));
            guds.gud.Add(new Gud("�������� ���", 0, 7.2));
            guds.gud.Add(new Gud("���� ����", 0, 4.4));

            oils.oil.Add(new Oil("A-76", 0, 6.4));
            oils.oil.Add(new Oil("A-92", 0, 7.5));
            oils.oil.Add(new Oil("A-95", 0, 8.6));
            oils.oil.Add(new Oil("A-100", 0, 9.9));

            comboBox_oil.Items.Clear(); // ������� ������������ ��������, ���� ����
            foreach (Oil oil in oils.oil)
            {
                comboBox_oil.Items.Add(oil);
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
                    // ���� CheckBox ��������, ������������� �������� � ��������� TextBox � 0
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
                if (checkBoxes[i].Checked) // ���������, ������� �� CheckBox
                {
                    gudsumm += guds.gud[i].Summa;
                }
            }
            lb_kafe_price.Text = gudsumm.ToString();
        }

        private void comboBox_oil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_oil.SelectedItem is Oil selectedOil)
            {
                tb_oil_price.Text = selectedOil.Price.ToString();
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // �� ������
        {
            tb_oil_sum.Enabled = false;
            tb_oil_count.Enabled = true;
            CalculateOilValue();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // �� �����
        {
            tb_oil_count.Enabled = false;
            tb_oil_sum.Enabled = true;
            CalculateOilValue();
        }

        private void CalculateOilValue()
        {
            if (radioButton1.Checked) // ����� �� ������
            {
                if (double.TryParse(tb_oil_count.Text, out double liters) && comboBox_oil.SelectedItem is Oil selectedOil)
                {
                    gb_select_type.Text = "����� � ������:";
                    oilLiters = liters;
                    oilPrice = Math.Round((liters * selectedOil.Price), 2);
                    lb_oil_price.Text = $"{oilPrice} ���";
                    tb_oil_sum.Text = oilPrice.ToString();
                }
            }
            else if (radioButton2.Checked) // ����� �� �����
            {
                if (double.TryParse(tb_oil_sum.Text, out double totalAmount) && comboBox_oil.SelectedItem is Oil selectedOil)
                {
                    gb_select_type.Text = "� ������:";
                    oilPrice = totalAmount;
                    oilLiters = Math.Round((totalAmount / selectedOil.Price), 2);
                    lb_oil_price.Text = $"{oilLiters} ������";
                    tb_oil_count.Text = oilLiters.ToString();
                }
            }
        }

        private void UpdateOilValue(object sender, EventArgs e)
        {
            CalculateOilValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_sum.Text=(oilPrice+ gudsumm).ToString();
        }
    }
}

