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
            bool playAgain = true;
            while (playAgain)
            {
                int targetNumber; // ��������� �����
                int attempts = 0; // ���������� �������
                bool guessed = false; //��������� ����� ��� ����������
                List<int> usedNumbers = new List<int>(); // ������ ������� ������������� ��� ���������� �����
                if (int.TryParse(textBox1.Text, out targetNumber)) // �������� �� ��������� ����� int
                {
                    if (targetNumber > 0 && targetNumber <2000) 
                    {
                        //Random random = new Random(DateTime.Now.Millisecond);
                        while (!guessed)
                        {
                            attempts++;
                            int guess;

                            do
                            {
                                guess = new Random().Next(1, 2001); // ��������� ���������� ����� �� 1 �� 2000
                            } while (usedNumbers.Contains(guess));

                            usedNumbers.Add(guess);

                            if (guess == targetNumber)
                            {
                                MessageBox.Show($"��������� ������ ���� ����� {targetNumber} �� {attempts} �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                guessed = true;
                            }
                        }

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
                DialogResult playAgainResult = MessageBox.Show("������ ������� ��� ���?", "��� ���?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                playAgain = (playAgainResult == DialogResult.Yes);
            }
        }
    }
}