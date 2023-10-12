using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace WinFormsApp1
{
    /* 
     * ������� 2
����������� ���������� ���� ����� ���������� ������ � ������� DateTimePicker � �������� ��������� �� ����� � �������������
�������� Label. ����� �������� ���� �������� � ���� �����.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.None;
            this.Paint += Form1_Paint;
            this.Size = new Size(400, 400); // 400x400 ��������


        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startdata = dateTimePicker1.Value;
            DateTime enddata = dateTimePicker2.Value;
            TimeSpan timeSpan = enddata - startdata;
            int daysDifference = (int)timeSpan.TotalDays;

            // ���������� ���������� ���� �� Label
            label1.Text = "���������� ����: " + daysDifference.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias; // ����������� ��� �����

                Rectangle rect = this.ClientRectangle;
                using (Brush brush = new SolidBrush(Color.Indigo))
                {
                    g.FillEllipse(brush, rect);
                }
            }
        }

    }
}