namespace WinFormsApp1
/*Задание 2
Написать приложение – анкету, которую предлагается заполнить
пользователю: имя, фамилия, e-mail, телефон. После нажатия на кнопку «Добавить» Информация о пользователе попадает в ListBox, в котором храниться информация о всех пользователях. Также, в ListBox,
по клику на строку с информацией о пользователе следует предусмотреть возможность удаления пользователя из коллекции элементов ListBox, а также редактирования. Редактирование информации о
пользователе производиться путем подстановки данных из ListBox, в
соответствующие поля для ввода новой информации.
Предусмотреть:
■ экспорт/импорт всей информации о пользователях в текстовый файл;
■ экспорт/импорт всей информации о пользователях в *.xml
файл.*/
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            string userInfo = $"{name}, {surname}, {email}, {phone}";

            lstUsers.Items.Add(userInfo);

            // Очистите поля TextBox после добавления информации.
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex != -1)
            {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;

                string editedInfo = $"{name}, {surname}, {email}, {phone}";

                // Получаем индекс выбранного элемента.
                int selectedIndex = lstUsers.SelectedIndex;

                // Удаляем выбранный элемент.
                lstUsers.Items.RemoveAt(selectedIndex);

                // Добавляем отредактированную информацию на том же индексе.
                lstUsers.Items.Insert(selectedIndex, editedInfo);
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex != -1)
            {
                string selectedUserInfo = lstUsers.SelectedItem.ToString();
                string[] userInfoParts = selectedUserInfo.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);

                if (userInfoParts.Length == 4)
                {
                    txtName.Text = userInfoParts[0].Trim();
                    txtSurname.Text = userInfoParts[1].Trim();
                    txtEmail.Text = userInfoParts[2].Trim();
                    txtPhone.Text = userInfoParts[3].Trim();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex != -1)
            {
                lstUsers.Items.RemoveAt(lstUsers.SelectedIndex);
            }
        }

    }
}