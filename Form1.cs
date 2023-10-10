using System.Globalization;

namespace WinFormsApp1
{
    /*������� 6
�������� ���������, ������� �� ��������� ���� ���������� ����
������. ��������� �������� � ��������� ���� (���������� ��-������). 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

            // ������� �������������� ��������� ������ � ����
            if (DateTime.TryParse(userInput, out DateTime selectedDate))
            {
                // ����������� ��� ������ �� ������� �����
                string dayOfWeek = selectedDate.ToString("dddd", new CultureInfo("ru-RU"));

                // ����� ���������� � ��������� ����
                textBox2.Text = $"���� ������: {dayOfWeek}";
            }
            else
            {
                MessageBox.Show("������������ ������ ����!", "������");
            }
        }
    }
}