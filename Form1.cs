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
        }
        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                Random random = new Random();
                int maxX = this.ClientSize.Width - label1.Width; // ������������ �������� X
                int maxY = this.ClientSize.Height - label1.Height; // ������������ �������� Y
                int x = random.Next(0, maxX);
                int y = random.Next(0, maxY);
                label1.Location = new Point(x, y);
                label1.Update();
            }
        }
    }
}