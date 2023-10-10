namespace WinFormsApp1
{
    /*
     Задание 7
Написать программу, вычисляющую сколько осталось времени
до указанной даты (дата вводится с клавиатуры в Edit). Предусмотреть возможность выдачи результата в годах, месяцах, днях, минутах,
секундах (для первых двух вариантов ответ дробный). Для переключения между вариантами желательно использовать переключатели
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
            // Получаем введенную пользователем дату из TextBox
            if (DateTime.TryParse(textBox1.Text, out DateTime targetDate))
            {
                // Получаем текущую дату и время
                DateTime currentDate = DateTime.Now;

                // Рассчитываем разницу между датами
                TimeSpan timeDifference = targetDate - currentDate;

                // В зависимости от выбранной единицы измерения времени вычисляем результат
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

                // Выводим результат
                label1.Text = $"Осталось {result:F2} {(radioButtonYears.Checked ? "год(а)" : radioButtonMonths.Checked ? "месяц(ев)" : radioButtonDays.Checked ? "день(дней)" : radioButtonMinutes.Checked ? "минут(ы)" : "секунд(ы)")} до указанной даты.";
            }
            else
            {
                MessageBox.Show("Некорректный формат даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}