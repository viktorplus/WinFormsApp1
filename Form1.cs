using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Создаем список вариантов семейного статуса
            List<string> familyStatusOptions = new List<string>
            {
                "Холост/Не замужем",
                "Замужем/Женат",
                "Разведен/Разведена",
                "Вдовец/Вдова",
                "Другое"
            };

            // Привязываем список к ComboBox для семейного статуса
            familystatus.DataSource = familyStatusOptions;

            // Создаем список вариантов пола
            List<string> genderOptions = new List<string> { "Мужской", "Женский", "Диверс" };

            // Привязываем список к ComboBox для пола
            sex.DataSource = genderOptions;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения из элементов управления
            string lastnameValue = lastname.Text;
            string nameValue = name.Text;
            string vaternameValue = vatername.Text;
            string sexValue = sex.SelectedItem?.ToString();
            string dateOfBirthValue = datebirhday.Value.ToShortDateString();
            string familyStatusValue = familystatus.SelectedItem?.ToString();
            string additionalInfoValue = info.Text;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(lastnameValue) || string.IsNullOrWhiteSpace(nameValue))
            {
                MessageBox.Show("Заполните обязательные поля: Фамилия и Имя");
                return;
            }

            // Формируем строку для сохранения
            string dataToSave = $"{lastnameValue}, {nameValue}, {vaternameValue}, {sexValue}, {dateOfBirthValue}, {familyStatusValue}, {additionalInfoValue}";

            // Сохраняем данные в файл
            try
            {
                using (StreamWriter sw = new StreamWriter("data.txt", true)) // путь к файлу
                {

                    sw.WriteLine(dataToSave);
                }

                MessageBox.Show("Информация успешно сохранена в файле.");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void ResetForm()
        {
            // Сбросить значения элементов управления
            lastname.Clear();
            name.Clear();
            vatername.Clear();
            sex.SelectedIndex = -1;
            datebirhday.Value = DateTime.Now;
            familystatus.SelectedIndex = -1;
            info.Clear();
        }


    }
}
