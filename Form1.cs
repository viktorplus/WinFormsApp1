namespace WinFormsApp1
{
    /*Задание 5
Разработать приложение «убегающий статик»:) Суть приложения:
на форме расположен статический элемент управления («статик»).
Пользователь пытается подвести курсор мыши к «статику», и, если
курсор находиться близко со статиком, элемент управления «убегает». Предусмотреть перемещение «статика» только в пределах формы. 
    */
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            //label1.MouseMove += Label1_MouseMove;
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            int threshold = 50; // Пороговое расстояние для перемещения Label

            // Рассчитываем расстояние между текущим положением Label и курсора мыши
            int deltaX = e.X - label1.Left - label1.Width / 2;
            int deltaY = e.Y - label1.Top - label1.Height / 2;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            // Если расстояние меньше порогового значения, перемещаем Label
            if (distance < threshold)
            {
                // Новые случайные координаты для Label в пределах формы
                int newX = random.Next(0, this.ClientSize.Width - label1.Width);
                int newY = random.Next(0, this.ClientSize.Height - label1.Height);

                label1.Location = new Point(newX, newY);
            }
        }
    }
}