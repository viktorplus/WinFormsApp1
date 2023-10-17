namespace WinFormsApp1
{
    /*������� 1
�������� ����������, ������� ���������� ���������� ������,
������������ �� ����� � ������� ProgressBar. */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //����� ����� ��� ������ ������.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // ������ ������ �� �����.
                string text = File.ReadAllText(filePath);

                // ���������� ProgressBar � ����������� �� ���������� �������� � ������.
                progressBar1.Maximum = text.Length;
                progressBar1.Value = 0;

                // ����������� ������ � TextBox.
                textBox1.Text = text;

                // ���������� ProgressBar � ������ ����������� ��������.
                foreach (char c in text)
                {
                    progressBar1.Value++;
                    Application.DoEvents(); // ��������� �������� ��������� � �������� �������.
                }

                MessageBox.Show("����� �������� �������.");
            }
        }

    }
}