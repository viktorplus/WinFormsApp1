using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Привязываем событие TextChanged для текстовых полей
            day.TextChanged += UpdateSelectedDate;
            month.TextChanged += UpdateSelectedDate;
            year.TextChanged += UpdateSelectedDate;
        }

        private void UpdateSelectedDate(object sender, EventArgs e)
        {
            if (int.TryParse(day.Text, out int dayValue) && int.TryParse(month.Text, out int monthValue) && int.TryParse(year.Text, out int yearValue))
            {
                if (dayValue >= 1 && dayValue <= 31 && monthValue >= 1 && monthValue <= 12 && yearValue >= 1900)
                {
                    // Проверка на правильные значения дня, месяца и года
                    DateTime selectedDate = new DateTime(yearValue, monthValue, dayValue);
                    monthCalendar.SetDate(selectedDate);
                }
                else
                {
                    //MessageBox.Show("Неправильные значения дня, месяца или года.");
                }
            }
            else
            {
                //MessageBox.Show("Введите числовые значения для дня, месяца и года.");
            }
        }
    }
}
