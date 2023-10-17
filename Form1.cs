namespace WinFormsApp1
{
    /*Задание 1
Написать приложение, которое отображает количество текста,
прочитанного из файла с помощью ProgressBar. */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //выбор файла для чтения текста.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Чтение текста из файла.
                string text = File.ReadAllText(filePath);

                // Обновление ProgressBar в зависимости от количества символов в тексте.
                progressBar1.Maximum = text.Length;
                progressBar1.Value = 0;

                // Отображение текста в TextBox.
                textBox1.Text = text;

                // Обновление ProgressBar с учетом прочитанных символов.
                foreach (char c in text)
                {
                    progressBar1.Value++;
                    Application.DoEvents(); // Позволяет обновить интерфейс в реальном времени.
                }

                MessageBox.Show("Текст прочитан успешно.");
            }
        }

    }
}