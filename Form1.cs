using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Guds guds;
        CheckBox[] checkBoxes; // ������ ��� CheckBox
        TextBox[] textBoxes; // ������ ��� TextBox

        public Form1()
        {
            InitializeComponent();
            guds = new Guds();
            // ������������� ��������
            checkBoxes = new CheckBox[] { cb_hotdog, cb_gamburger, cb_fri, cb_kola };
            textBoxes = new TextBox[] { tb_hotdog_count, tb_gamburger_count, tb_fri_count, tb_kola_count };
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

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                textBoxes[i].Text = guds.gud[i].Count.ToString();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int index = Array.IndexOf(checkBoxes, checkBox);
            if (index >= 0)
            {
                textBoxes[index].Enabled = checkBox.Checked;
                guds.gud[index].OnOff = checkBox.Checked;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int index = Array.IndexOf(textBoxes, textBox);
            if (index >= 0 && int.TryParse(textBox.Text, out int targetNumber))
            {
                guds.gud[index].SetCount(targetNumber);
            }
        }
    }
}
