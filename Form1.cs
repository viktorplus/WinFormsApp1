using System.Windows.Forms;

namespace WinFormsApp1
{
    /* 
     * ������� 2
����������� ���������� ���� ����� ���������� ������ � ������� DateTimePicker � �������� ��������� �� ����� � �������������
�������� Label. ����� �������� ���� �������� � ���� �����.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startdata = dateTimePicker1.Value;
            DateTime enddata = dateTimePicker2.Value;
            TimeSpan timeSpan = enddata - startdata;
            int daysDifference = (int)timeSpan.TotalDays;

            // ���������� ���������� ���� �� Label
            label1.Text = "���������� ����: " + daysDifference.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }
    }
}