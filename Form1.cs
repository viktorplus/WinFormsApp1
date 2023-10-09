namespace WinFormsApp1
{
    /*Задание 2
Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000. Для запроса к пользователю использовать
MessageBox. После того, как число отгадано, необходимо вывести
количество запросов, потребовавшихся для этого, и предоставить
пользователю возможность сыграть еще раз, не выходя из программы
(MessageBox’ы оформляются кнопками и значками соответственно
ситуации)
    */
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
                int targetNumber; // Задуманное число
                int attempts = 0; // Количество попыток
                bool guessed = false; // Угадано ли
                List<int> usedNumbers = new List<int>(); // Список номеров использованных при угадывании числа

                try
                {
                    if (int.TryParse(textBox1.Text, out targetNumber)) // проверка на введенное число int
                    {
                        if (targetNumber > 0 && targetNumber < 2000)
                        {
                            while (!guessed)
                            {
                                attempts++;
                                int guess;

                                do
                                {
                                    guess = new Random().Next(1, 2001); // Генерация случайного числа от 1 до 2000
                                } while (usedNumbers.Contains(guess));

                                usedNumbers.Add(guess);

                                if (guess == targetNumber)
                                {
                                    MessageBox.Show($"Компьютер угадал ваше число {targetNumber} за {attempts} попыток.", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    guessed = true;
                                }
                            }
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }

                DialogResult playAgainResult = MessageBox.Show("Хотите попробовать сыграть еще раз с этим же загаданым числом?", "Еще раз?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                playAgain = (playAgainResult == DialogResult.Yes);
                textBox1.Focus();
            }
        }
    }

}