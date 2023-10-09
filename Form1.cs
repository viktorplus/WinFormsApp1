namespace WinFormsApp1
{
    /*Задание 3
Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей области формы.
    Необходимо создать следующие обработчики:

■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка: внутри прямоугольника,
снаружи, на границе прямоугольника. Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), 
то приложение должно закрываться;
■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
(рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;
■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна
текущие координаты мыши x и y
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string message = "";

                // Проверяем, находится ли точка внутри прямоугольника
                if (e.X > 10 && e.X < this.ClientSize.Width - 10 &&
                    e.Y > 10 && e.Y < this.ClientSize.Height - 10)
                {
                    message = "Внутри прямоугольника";
                }
                else if (e.X == 10 || e.X == this.ClientSize.Width - 10 ||
                         e.Y == 10 || e.Y == this.ClientSize.Height - 10)
                {
                    message = "На границе прямоугольника";
                }
                else
                {
                    message = "Снаружи прямоугольника";
                }

                // Проверяем, была ли нажата клавиша Ctrl
                if (Control.ModifierKeys == Keys.Control)
                {
                    this.Close(); // Закрываем приложение
                }
                else
                {
                    MessageBox.Show(message); // Выводим сообщение
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                string message = $"Ширина = {this.ClientSize.Width}, Высота = {this.ClientSize.Height}";
                this.Text = message; // Обновляем заголовок окна
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {e.X}, Y: {e.Y}"; // Обновляем заголовок окна
        }


    }
}