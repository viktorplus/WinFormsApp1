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
        }
        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                Random random = new Random();
                int maxX = this.ClientSize.Width - label1.Width; // Максимальное значение X
                int maxY = this.ClientSize.Height - label1.Height; // Максимальное значение Y
                int x = random.Next(0, maxX);
                int y = random.Next(0, maxY);
                label1.Location = new Point(x, y);
                label1.Update();
            }
        }
    }
}