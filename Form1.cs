namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "���: ������ ��������\r\n�������: +380686700001\r\nEmail: viktorplus3@gmail.com";
            string title = "���������� ����������";
            int len = message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "�������������: ������� ���������\r\n������� ���������: ����������� ��������������� ���������� ���������\r\n��� ���������: 2001\r\n�������������� �����������:\r\n�������������: ������������� ���� � �����\r\n������� ���������: ����������� ��������������� ���������� ���������\r\n��� ���������: 2001";
            title = "�����������";
            len += message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "����������� �������� ������� ���������������� �++ � �#.\r\n������ ����� ���������� � �������� ������.\r\n������ �������� ��������� ���������� �� Agile-�����������.\r\n������ ����������� ����� �� ����������� ������.\r\n����: �������� ������� ������������ ��� ���������� ������ ���������� ����������, �������������� ����� � ������ � ����� ���������� ������������ ����������� �� C++ � C#.";
            title = "����������� ������";
            len += message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "�������� ������������ �������� ��� ����� � ������� �����������������.\r\n���������� ���������� ��� ������������� �������������� ����� � ������.";
            title = "��������� �������";
            len += message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "������������: �� �������";
            len += message.Length;
            title = $"������� ���������� �������� {(int)len / 5} ����� {len}";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}