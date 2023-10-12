namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hotdog.Checked)
            {
                tb_hotdog_count.Enabled = true;
                tb_hotdog_count.Text = "1";
            }
            else
            {
                tb_hotdog_count.Enabled = false;
                tb_hotdog_count.Text = "0";
            }
        }

        private void tb_hotdog_count_changed(object sender, EventArgs e)
        {
            if()
        }
    }
}