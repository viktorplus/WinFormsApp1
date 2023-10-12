using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace WinFormsApp1
{
    /* 
     * Задание 2
Подсчитайте количество дней между выбранными датами с помощью DateTimePicker и выведите результат на форму с использование
элемента Label. Форму главного окна сделайте в виде круга.
    */
    public partial class Form1 : Form
    {
        private Graphics g;
        public Form1()
        {
            InitializeComponent();

        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startdata = dateTimePicker1.Value;
            DateTime enddata = dateTimePicker2.Value;
            TimeSpan timeSpan = enddata - startdata;
            int daysDifference = (int)timeSpan.TotalDays;

            // Отображаем количество дней на Label
            label1.Text = daysDifference.ToString() + " Дней";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Сглаживание для круга
            Rectangle rect = this.ClientRectangle;
            using (Brush brush = new SolidBrush(Color.Indigo))
            {
                g.FillEllipse(brush, rect);
            }
        }


    }
}