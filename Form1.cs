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
                int targetNumber; // задуманое число
                int attempts = 0; // количество попыток
                bool guessed = false; //угадано ли
                List<int> usedNumbers = new List<int>(); // список номеров использованых при угадывании числа
                if (int.TryParse(textBox1.Text, out targetNumber)) // проверка на введенное число int
                {
                    if (targetNumber > 0 && targetNumber <2000) 
                    {
                        Random random = new Random(DateTime.Now.Millisecond);

                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, введите корректное число от 1 до 2000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}