namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Guds guds;
        public Form1()
        {
            InitializeComponent();
            guds = new Guds();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guds.gud.Add(new Gud ("Хот Дог", 0, 4));
            guds.gud.Add(new Gud("Гамбургер", 0, 5.4));
            guds.gud.Add(new Gud("Картошка Фри", 0, 7.2));
            guds.gud.Add(new Gud("Кока Кола", 0, 4.4));

        }

        private void cb_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hotdog.Checked)
            {
                tb_hotdog_count.Enabled = true;
            }
            else
            {
                tb_hotdog_count.Enabled = false;
            }
        }

        private void tb_hotdog_count_changed(object sender, EventArgs e)
        {
            if (int.TryParse(tb_hotdog_count.Text, out int targetNumber)) // проверка на введенное число int
            {
                if (targetNumber > 0)
                {
                    guds.gud[0].SetCount(targetNumber);
                    tb_hotdog_price.Enabled = true;
                    tb_hotdog_price.Text = guds.gud[0].Summa.ToString();
                }
                else
                {
                    tb_hotdog_price.Enabled = false;
                }
            }
            else
            {
                tb_hotdog_price.Enabled = false;

            }
        }
    }
}