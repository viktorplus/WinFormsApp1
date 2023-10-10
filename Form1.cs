namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int x = e.X;
                int y = e.Y;


                Label label = new Label();
                label.Text = "Статик";
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(x, y);
                label.MinimumSize = new System.Drawing.Size(10, 10);

                this.Controls.Add(label);
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

            Label label = sender as Label;
            if (label != null)
            {
                this.Text = $"Площадь: {label.Size.Width * label.Size.Height}, X: {label.Location.X}, Y: {label.Location.Y}";
            }
        }

        private void label_MouseClick(object sender, MouseEventArgs e)
        {

            Label label = sender as Label;
            if (label != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.Text = $"Площадь: {label.Size.Width * label.Size.Height}, X: {label.Location.X}, Y: {label.Location.Y}";
                }
                else if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    this.Controls.Remove(label); 
                }
            }
        }
    }
}
