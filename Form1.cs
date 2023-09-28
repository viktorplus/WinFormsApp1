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
            bool repeat = true;
            while (repeat)
            {

                if (int.TryParse(textBox1.Text, out int number))
                {
                    //List <int> Benutzen = new List<int>();
                    //Random random = new Random();
                    Random random = new Random(DateTime.Now.Millisecond);
                    List<int> valuesOfNumberGuess = new List<int>();
                    var destinctGoods = goods.Select(x => new { x.Name }).Distinct().ToList();

                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}