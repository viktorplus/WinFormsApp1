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
            string message = "Имя: Виктор Хоименко\r\nТелефон: +380686700001\r\nEmail: viktorplus3@gmail.com";
            string title = "Контактная информация";
            int len = message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "Специальность: Инженер энергетик\r\nУчебное заведение: Запорожская Государственная Инженерная Аккадемия\r\nГод окончания: 2001\r\nДополнительное образование:\r\nСпециальность: Бухгалтерский учет и аудит\r\nУчебное заведение: Запорожская Государственная Инженерная Аккадемия\r\nГод окончания: 2001";
            title = "Образование";
            len += message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "Продвинутое владение языками программирования С++ и С#.\r\nЗнание основ алгоритмов и структур данных.\r\nЗнание основных принципов разработки по Agile-методологии.\r\nЗнание английского языка на техническом уровне.\r\nЦель: Получить позицию программиста для применения знаний инженерной энергетики, бухгалтерского учета и аудита в сфере разработки программного обеспечения на C++ и C#.";
            title = "Технические навыки";
            len += message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "Создание программного продукта для учета и анализа энергопотребления.\r\nРазработка приложения для автоматизации бухгалтерского учета и аудита.";
            title = "Примерные проекты";
            len += message.Length;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "Рекомендации: По запросу";
            len += message.Length;
            title = $"Среднее количество символов {(int)len / 5} Общее {len}";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}