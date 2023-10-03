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
            string title = "Notification";
            string message = "Congratulation!";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Form mainform = new Form();
                mainform.Show();
            }
            if (result == DialogResult.No)
            {
                this.Close();
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}