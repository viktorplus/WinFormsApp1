namespace WinFormsApp1
{
    /*
     ������� 7
�������� ���������, ����������� ������� �������� �������
�� ��������� ���� (���� �������� � ���������� � Edit). ������������� ����������� ������ ���������� � �����, �������, ����, �������,
�������� (��� ������ ���� ��������� ����� �������). ��� ������������ ����� ���������� ���������� ������������ �������������
(RadioButton).
      */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �������� ��������� ������������� ���� �� TextBox
            if (DateTime.TryParse(textBox1.Text, out DateTime targetDate))
            {
                // �������� ������� ���� � �����
                DateTime currentDate = DateTime.Now;

                // ������������ ������� ����� ������
                TimeSpan timeDifference = targetDate - currentDate;

                // � ����������� �� ��������� ������� ��������� ������� ��������� ���������
                double result = 0;
                if (radioButtonYears.Checked)
                {
                    result = timeDifference.TotalDays / 365.0;
                }
                else if (radioButtonMonths.Checked)
                {
                    result = timeDifference.TotalDays / 30.4375;
                }
                else if (radioButtonDays.Checked)
                {
                    result = timeDifference.TotalDays;
                }
                else if (radioButtonMinutes.Checked)
                {
                    result = timeDifference.TotalMinutes;
                }
                else if (radioButtonSeconds.Checked)
                {
                    result = timeDifference.TotalSeconds;
                }

                // ������� ���������
                label1.Text = $"�������� {result:F2} {(radioButtonYears.Checked ? "���(�)" : radioButtonMonths.Checked ? "�����(��)" : radioButtonDays.Checked ? "����(����)" : radioButtonMinutes.Checked ? "�����(�)" : "������(�)")} �� ��������� ����.";
            }
            else
            {
                MessageBox.Show("������������ ������ ����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}