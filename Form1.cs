namespace WinFormsApp1
{
    /*������� 5
����������� ���������� ���������� ������:) ���� ����������:
�� ����� ���������� ����������� ������� ���������� (�������).
������������ �������� �������� ������ ���� � ��������, �, ����
������ ���������� ������ �� ��������, ������� ���������� ��������. ������������� ����������� �������� ������ � �������� �����. 
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
            int threshold = 50; // ��������� ���������� ��� ����������� Label

            // ������������ ���������� ����� ������� ���������� Label � ������� ����
            int deltaX = e.X - label1.Left - label1.Width / 2;
            int deltaY = e.Y - label1.Top - label1.Height / 2;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            // ���� ���������� ������ ���������� ��������, ���������� Label
            if (distance < threshold)
            {
                // ����� ��������� ���������� ��� Label � �������� �����
                int newX = random.Next(0, this.ClientSize.Width - label1.Width);
                int newY = random.Next(0, this.ClientSize.Height - label1.Height);

                label1.Location = new Point(newX, newY);
            }
        }
    }
}