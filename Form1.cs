using System.Globalization;

namespace WinFormsApp1
{
    /*Задание 6
Написать программу, которая по введенной дате определяет день
недели. Результат выводить в текстовое поле (желательно по-русски). 
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

            // Попытка преобразования введенной строки в дату
            if (DateTime.TryParse(userInput, out DateTime selectedDate))
            {
                // Определение дня недели на русском языке
                string dayOfWeek = selectedDate.ToString("dddd", new CultureInfo("ru-RU"));

                // Вывод результата в текстовое поле
                textBox2.Text = $"День недели: {dayOfWeek}";
            }
            else
            {
                MessageBox.Show("Некорректный формат даты!", "Ошибка");
            }
        }
    }
}