using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPassword.Text;

            // �������� ������ � ������
            User authenticatedUser = Users.CheckLogin(username, password);

            if (authenticatedUser != null)
            {
                // ������������ ������� ����������������
                string userStatus = authenticatedUser.Status;

                // �����������, ���� ������������� ������������
                if (userStatus == "user")
                {
                    // ������������� �� ����� ������������
                    UserForm1 userForm = new UserForm1(username);
                    userForm.Show();
                }
                else if (userStatus == "bibliotekar")
                {
                    // ������������� �� ����� ������������
                    BibliotekarForm bibliotekarForm = new BibliotekarForm(username);
                    bibliotekarForm.Show();
                }
                else if (userStatus == "admin")
                {
                    // ������������� �� ����� ������
                    AdminForm adminForm = new AdminForm(username);
                    adminForm.Show();
                }
            }
            else
            {
                // ������ ��������������
                MessageBox.Show("�������� ����� ��� ������. ���������� ��� ���.");
            }
        }


        private void Loginbutton_registration_Click(object sender, EventArgs e)
        {
            RegistationForm Registration = new RegistationForm(this);
            this.Visible = false;
            Registration.Show();
        }

    }
}