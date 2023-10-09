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
            bool repeat = true;
            while (repeat)
            {
                int targetNumber; // ��������� �����
                int attempts = 0; // ���������� �������
                bool guessed = false; //������� ��
                List<int> usedNumbers = new List<int>(); // ������ ������� ������������� ��� ���������� �����
                if (int.TryParse(textBox1.Text, out targetNumber)) // �������� �� ��������� ����� int
                {
                    if (targetNumber > 0 && targetNumber <2000) 
                    {
                        Random random = new Random(DateTime.Now.Millisecond);

                    }
                    else
                    {
                        MessageBox.Show("����������, ������� ���������� ����� �� 1 �� 2000.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("����������, ������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}