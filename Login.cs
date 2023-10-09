using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        string username = "admin";
        string password = "admin";
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == username && password == tb_password.Text)
            {
                this.Visible = false;
                MessageBox.Show("Вітаємо, " + username + "!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeUser homeForm = new HomeUser(this);
                var result = homeForm.ShowDialog();
                if (DialogResult.Cancel == result)
                {
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Помилка відкриття форми!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Невірний логін або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}