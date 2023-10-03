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
            MessageBox.Show("Мы и не сомневались в этом");
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //button2.Top -= e.Y;
            //button2.Left += e.X;
            //if(button2.Top < -10 || button2.Top > 100)
            //    button2.Top = 60;
            //if (button2.Left < -80 || button2.Left > 250)
            //    button2.Left = 120;
            Random random = new Random();
            int x = random.Next(0, this.Width-button2.Width);
            int y = random.Next(0, this.Height - button2.Height);
            button2.Location = new Point(x, y);
            button2.Update();
        }
    }
}