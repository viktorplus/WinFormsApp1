using System.Reflection;
using System.Windows.Forms;
/*Доработано:
1. Программа теперь суммирует количество товаров указанных несколько раз в разных строках, учитывая количество товаров в каждой из строк.
2. Высота столбцов соответсвует максимальному количеству одного из товаров, а не сумме количеств всех товаров.
3. Ширина столбца зависит от количесвта товаров. На всю ширину всегда.
4. Подписаны оси координат, указан масштаб.
5. отображаем название и колиество товара при клике на столбец диаграммы*/

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // словарь для отслеживания количества каждого товара независимо от количества строк
        private Dictionary<string, int> itemCounts = new Dictionary<string, int>();

        List<Good> goods = new List<Good>();
        public Form1()
        {
            InitializeComponent();
            NUD_Amount.BackColor = Color.DarkGray;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            if (tb_GoodName.Text.Length > 0)
            {
                NUD_Amount.Enabled = true;
                NUD_Amount.BackColor = Color.White;
            }
            else
            {
                NUD_Amount.Value = 0;
                NUD_Amount.Enabled = false;
                NUD_Amount.BackColor = Color.DarkGray;
            }
        }

        private void AmountChanged(object sender, EventArgs e)
        {
            if (NUD_Amount.Value > 0)
            {
                tb_PricePerOne.Enabled = true;
                tb_PriceAll.Enabled = true;
            }
            else
            {
                tb_PricePerOne.Enabled = false;
                tb_PriceAll.Enabled = false;
            }
        }

        private void AddGood_Click(object sender, EventArgs e)
        {

            try
            {
                if (tb_GoodName.Text.Length == 0)
                {
                    throw new Exception("Name is empty");
                }
                if (NUD_Amount.Value == 0)
                {
                    throw new Exception("Amount is 0");
                }
                if (tb_PricePerOne.Text.Length == 0)
                {
                    throw new Exception("Price is empty");
                }
                if (tb_Desc.Text.Length == 0)
                {
                    throw new Exception("Description is empty");
                }
                if (dateTimePicker.Value > DateTime.Now)
                {
                    throw new Exception("Date is in future");
                }
                var good = new Good(tb_GoodName.Text, tb_Desc.Text, (int)NUD_Amount.Value, decimal.Parse(tb_PricePerOne.Text), dateTimePicker.Value);
                goods.Add(good);
                listOfGoods.Items.Clear();
                listOfGoods.Items.AddRange(goods.ToArray());
                listOfGoods.Update();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PricePerOneChanged(object sender, EventArgs e)
        {
            tb_PriceAll.Text = (NUD_Amount.Value * decimal.Parse(tb_PricePerOne.Text)).ToString();
        }

        private void RomoveGoodFromList(object sender, EventArgs e)
        {
            Good good = (Good)listOfGoods.SelectedItem;
            goods.Remove(good);
            listOfGoods.Items.Clear();
            listOfGoods.Items.AddRange(goods.ToArray());
            listOfGoods.Update();
        }

        private void EditGoodItem(object sender, EventArgs e)
        {
            int index = listOfGoods.SelectedIndex;
            Good good = (Good)listOfGoods.SelectedItem;
            good.Name = tb_GoodName.Text;
            good.Description = tb_Desc.Text;
            good.Amount = (int)NUD_Amount.Value;
            good.PricePerOne = decimal.Parse(tb_PricePerOne.Text);
            good.TotalPrice = good.Amount * good.PricePerOne;
            good.Date = dateTimePicker.Value;
            goods[index] = good;
            listOfGoods.Items.Clear();
            listOfGoods.Items.AddRange(goods.ToArray());
            listOfGoods.Update();
        }

        private void SelectedValue(object sender, EventArgs e)
        {
            Good good = (Good)listOfGoods.SelectedItem;
            tb_GoodName.Text = good.Name;
            tb_Desc.Text = good.Description;
            NUD_Amount.Value = good.Amount;
            tb_PricePerOne.Text = good.PricePerOne.ToString();
            tb_PriceAll.Text = good.TotalPrice.ToString();
            dateTimePicker.Value = good.Date;
        }
        private void DrawCord(PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.White, 1), new Point(100, 25), new Point(100, 500));
            e.Graphics.DrawLine(new Pen(Color.White, 1), new Point(75, 475), new Point(875, 475));
            e.Graphics.DrawString("Номенклатура товару", new Font("Arial", 10), new SolidBrush(Color.White), new Point(125, 475));
            e.Graphics.DrawString("50%", new Font("Arial", 10), new SolidBrush(Color.White), new Point(10, 250));


        }
        public static List<Color> ColorStructToList()
        {
            return typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
                                .Select(c => (Color)c.GetValue(null, null))
                                .ToList();
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            try
            {
                DrawCord(e);
                if (goods.Count == 0)
                {
                    throw new Exception("Пустий список. Неможливо створити аналітику!");
                }
                foreach (Good good in goods)
                {
                    string itemName = good.Name;
                    if (itemCounts.ContainsKey(itemName))
                    {
                        itemCounts[itemName] += good.Amount;
                    }
                    else
                    {
                        itemCounts[itemName] = good.Amount;
                    }
                }

                List<Color> ColorsList = ColorStructToList();
                Random random = new Random(DateTime.Now.Millisecond);
                int maxItemCount = itemCounts.Values.Max(); // Определение максимального значения для 100% высоты
                int x = 110;
                int y = 25;
                int h = 450;
                int barCount = itemCounts.Count;
                int barWidth = (int)(tabAnalitics.Width - x - (barCount + 1) * 10) / barCount; // Равномерное распределение ширины столбцов

                foreach (var item in itemCounts)
                {
                    int itemCount = item.Value;
                    int step = (int)(((double)itemCount / maxItemCount) * h); // Используем максимальное количество для нормализации
                    DrawDiagram(e, new Point(x, y + (h - step)), new SolidBrush(ColorsList[random.Next(ColorsList.Count - 1)]), step, barWidth);

                    x += barWidth + 10; // Добавляем отступ между столбцами
                }
                string totalItemCountText = $"100% = {maxItemCount} шт.";
                e.Graphics.DrawString(totalItemCountText, new Font("Arial", 10), new SolidBrush(Color.White), new Point(0, 25));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DrawDiagram(PaintEventArgs e, Point point, Brush brush, int h, int barWidth)
        {
            e.Graphics.FillRectangle(brush, point.X, point.Y, barWidth, h);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabAnalitics)
            {
                tabAnalitics.Refresh();
            }
        }
        private void tabAnalitics_MouseClick(object sender, MouseEventArgs e)
        {
            // Проверка, что мы находимся в пределах диаграммы
            if ( e.X < 100 || e.X > tabAnalitics.Width || e.Y < 25 || e.Y > 475)
            {
                return;
            }

            // Расчитываем индекс столбца, над которым находится мышь
            int x = 110;
            int barCount = itemCounts.Count;
            int barWidth = (int)(tabAnalitics.Width - x - (barCount + 1) * 10) / barCount;

            int columnIndex = (e.X - x) / (barWidth + 10);

            if (columnIndex >= 0 && columnIndex < barCount)
            {
                // Имя товара будет ключом в словаре itemCounts
                string itemName = goods[columnIndex].Name;
                if (itemCounts.TryGetValue(itemName, out int itemCount))
                {
                    // Отобразим информацию о товаре
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(tabAnalitics, $"{itemName}: {itemCount} шт.");
                }
            }
        }

    }
}