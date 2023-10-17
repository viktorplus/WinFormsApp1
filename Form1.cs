using System.Xml.Linq;

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

            // Очищаем поля TextBox после добавления информации.
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
        private void btnExportText_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, lstUsers.Items.Cast<string>());
                }
            }
        }

        private void btnImportText_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    lstUsers.Items.AddRange(lines);
                }
            }
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("<Users>");
                        foreach (string userInfo in lstUsers.Items)
                        {
                            string[] userInfoParts = userInfo.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);
                            writer.WriteLine($"  <User>");
                            writer.WriteLine($"    <Name>{userInfoParts[0]}</Name>");
                            writer.WriteLine($"    <Surname>{userInfoParts[1]}</Surname>");
                            writer.WriteLine($"    <Email>{userInfoParts[2]}</Email>");
                            writer.WriteLine($"    <Phone>{userInfoParts[3]}</Phone>");
                            writer.WriteLine($"  </User>");
                        }
                        writer.WriteLine("</Users>");
                    }
                }
            }
        }

        private void btnImportXML_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lstUsers.Items.Clear();

                    try
                    {
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            string xmlString = reader.ReadToEnd();
                            XDocument xdoc = XDocument.Parse(xmlString);

                            foreach (XElement userElement in xdoc.Descendants("User"))
                            {
                                string name = userElement.Element("Name").Value;
                                string surname = userElement.Element("Surname").Value;
                                string email = userElement.Element("Email").Value;
                                string phone = userElement.Element("Phone").Value;

                                string userInfo = $"{name}, {surname}, {email}, {phone}";
                                lstUsers.Items.Add(userInfo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при импорте из XML файла: " + ex.Message, "Ошибка");
                    }
                }
            }
        }


    }
}