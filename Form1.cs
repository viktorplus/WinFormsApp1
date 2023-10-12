using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������� ������ ��������� ��������� �������
            List<string> familyStatusOptions = new List<string>
            {
                "������/�� �������",
                "�������/�����",
                "��������/���������",
                "������/�����",
                "������"
            };

            // ����������� ������ � ComboBox ��� ��������� �������
            familystatus.DataSource = familyStatusOptions;

            // ������� ������ ��������� ����
            List<string> genderOptions = new List<string> { "�������", "�������", "������" };

            // ����������� ������ � ComboBox ��� ����
            sex.DataSource = genderOptions;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �������� �������� �� ��������� ����������
            string lastnameValue = lastname.Text;
            string nameValue = name.Text;
            string vaternameValue = vatername.Text;
            string sexValue = sex.SelectedItem?.ToString();
            string dateOfBirthValue = datebirhday.Value.ToShortDateString();
            string familyStatusValue = familystatus.SelectedItem?.ToString();
            string additionalInfoValue = info.Text;

            // �������� �� ������ ����
            if (string.IsNullOrWhiteSpace(lastnameValue) || string.IsNullOrWhiteSpace(nameValue))
            {
                MessageBox.Show("��������� ������������ ����: ������� � ���");
                return;
            }

            // ��������� ������ ��� ����������
            string dataToSave = $"{lastnameValue}, {nameValue}, {vaternameValue}, {sexValue}, {dateOfBirthValue}, {familyStatusValue}, {additionalInfoValue}";

            // ��������� ������ � ����
            try
            {
                using (StreamWriter sw = new StreamWriter("data.txt", true)) // ���� � �����
                {

                    sw.WriteLine(dataToSave);
                }

                MessageBox.Show("���������� ������� ��������� � �����.");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������ ��� ���������� ������: {ex.Message}");
            }
        }

        private void ResetForm()
        {
            // �������� �������� ��������� ����������
            lastname.Clear();
            name.Clear();
            vatername.Clear();
            sex.SelectedIndex = -1;
            datebirhday.Value = DateTime.Now;
            familystatus.SelectedIndex = -1;
            info.Clear();
        }


    }
}
