using System;
using System.Windows.Forms;
/*Задание 8
Постановка задачи:
Владелец автозаправки «BestOil» заказал следующую программу.
Когда автозаправка только начинает свою деятельность, владелец
обычно хочет получать максимально большой доход, который планирует увеличить за счет дополнительных услуг. Поэтому на автозаправке будет действовать небольшое кафе. Но, в то же время он может нанять только одного работника на должность кассира, а потому
Домашнее задание №1 назначение программы – учет продаж бензина и ассортимента товаров в миникафе.
Требования к поставленной задаче:
Для удобства окно разделено на три части: первая для осуществления вычислений, касающихся непосредственно заправки автомобилей топливом; вторая – покупки в мини-кафе; третья часть для вычисления суммы оплаты.
Итак, первая группа элементов Автозаправка.
ComboBox – выпадающий список с перечнем имеющегося горючего. По умолчанию, сразу при запуске программы должен быть выбран
определенный вид горючего и в TextBox (или например Label) должна
отображаться цена на данный вид продукта. При каждой смене выбоОриентировочный вид:
(переведите на русский самостоятельно)
Домашнее задание №1 ра бензина, цена в данном поле будет соответственно меняться.
Далее, дается возможность выбора: купить горючее, указав необходимое количество литров или указав, на какую сумму клиент будет
заправляться. При этом, после выбора одного из двух вариантов предоставления услуги, ненужное поле становится заблокированным. В
случае ввода суммы денег, группа «К оплате» изменит название на «К
выдаче»; вместо суммы следует выводить количество литров, соответственно изменяются единицы измерения с «грн..» на «л»..
Вторая группа Мини-кафе.
Для удобства, все возможные товары выведены сразу в данной
части. Для каждого продукта предусмотрены CheckBox с названием
товара, рядом выводится цена (неактивный TextBox). При получении
заказа для возможности ввода количества заказанных единиц товара,
следует поставить «галочку» в CheckBox напротив соответствующего
товара.
Последняя – «К оплате».
Содержит кнопку, которая отвечает за осуществление вычисления
и вывода сумм в соответствующих полях.
После того, как выведена сумма, через (например) 10 секунд должен появиться запрос на очистку формы, то есть при появлении следующего клиент: да – все поля принимают значения по умолчанию,
нет – неизменное состояние остается еще на 10 секунд. При выходе
из программы (закончился рабочий день) должно появиться окно с
сообщением, какова общая сумма выручки за данный день. Или эту
сумму можно сразу выводить в самой форме и изменять после каждого осуществления расчета с клиентом.
Кроме этого, придайте форме эстетический вид (цвета, шрифты, рисунки ...). При обоснованной необходимости и интересном
решении функциональности программы разрешается вносить изменения во внешний вид формы или набор элементов.*/
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Guds guds;
        Oils oils;
        CheckBox[] checkBoxes; // Массив для CheckBox
        TextBox[] textBoxes; // Массив для TextBox
        TextBox[] textBoxesPrice; // Массив для TextBox

        private double oilLiters = 0; // Изначально нулевое количество литров
        private double oilPrice = 0;  // Изначально нулевая сумма к оплате
        private double gudsumm = 0; // общая сумма по продуктам
        private double totalRevenue = 0; // общая сумма выручки за день

        private System.Windows.Forms.Timer resetFormTimer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            guds = new Guds();
            oils = new Oils();
            // Инициализация массивов
            checkBoxes = new CheckBox[] { cb_hotdog, cb_gamburger, cb_fri, cb_kola };
            textBoxes = new TextBox[] { tb_hotdog_count, tb_gamburger_count, tb_fri_count, tb_kola_count };
            textBoxesPrice = new TextBox[] { tb_hotdog_price, tb_gamburger_price, tb_fri_price, tb_cola_price };
            // Подписываем все CheckBox на одно событие
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
            // Подписываем все TextBox на одно событие
            foreach (TextBox textBox in textBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            // Инициализация таймера
            resetFormTimer = new System.Windows.Forms.Timer();
            resetFormTimer.Interval = 10000; // 10 секунд
            resetFormTimer.Tick += ResetFormTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guds.gud.Add(new Gud("Хот Дог", 0, 4));
            guds.gud.Add(new Gud("Гамбургер", 0, 5.4));
            guds.gud.Add(new Gud("Картошка Фри", 0, 7.2));
            guds.gud.Add(new Gud("Кока Кола", 0, 4.4));

            oils.oil.Add(new Oil("A-76", 0, 6.4));
            oils.oil.Add(new Oil("A-92", 0, 7.5));
            oils.oil.Add(new Oil("A-95", 0, 8.6));
            oils.oil.Add(new Oil("A-100", 0, 9.9));

            foreach (Oil oil in oils.oil)
            {
                comboBox_oil.Items.Add(oil);
            }

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                textBoxes[i].Text = guds.gud[i].Count.ToString();
                textBoxesPrice[i].Text = guds.gud[i].Price.ToString();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int index = Array.IndexOf(checkBoxes, checkBox);
            if (index >= 0)
            {
                textBoxes[index].Enabled = checkBox.Checked;
                if (!checkBox.Checked)
                {
                    // Если CheckBox выключен, устанавливаем значение в связанном TextBox в 0
                    textBoxes[index].Text = "0";
                }
                GudSumm();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int index = Array.IndexOf(textBoxes, textBox);
            if (index >= 0 && int.TryParse(textBox.Text, out int targetNumber))
            {
                guds.gud[index].SetCount(targetNumber);
                GudSumm();
            }
        }

        private void GudSumm()
        {
            gudsumm = 0;
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked) // Проверяем, включен ли CheckBox
                {
                    gudsumm += guds.gud[i].Summa;
                }
            }
            lb_kafe_price.Text = gudsumm.ToString();
        }

        private void comboBox_oil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_oil.SelectedItem is Oil selectedOil)
            {
                tb_oil_price.Text = selectedOil.Price.ToString();
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // по объему
        {
            tb_oil_sum.Enabled = false;
            tb_oil_count.Enabled = true;
            CalculateOilValue();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // по сумме
        {
            tb_oil_count.Enabled = false;
            tb_oil_sum.Enabled = true;
            CalculateOilValue();
        }

        private void CalculateOilValue()
        {
            if (radioButton1.Checked) // Режим по объему
            {
                if (double.TryParse(tb_oil_count.Text, out double liters) && comboBox_oil.SelectedItem is Oil selectedOil)
                {
                    gb_select_type.Text = "Сумма к оплате:";
                    oilLiters = liters;
                    oilPrice = Math.Round((liters * selectedOil.Price), 2);
                    lb_oil_price.Text = $"{oilPrice} грн";
                    tb_oil_sum.Text = oilPrice.ToString();
                }
            }
            else if (radioButton2.Checked) // Режим по сумме
            {
                if (double.TryParse(tb_oil_sum.Text, out double totalAmount) && comboBox_oil.SelectedItem is Oil selectedOil)
                {
                    gb_select_type.Text = "К выдаче:";
                    oilPrice = totalAmount;
                    oilLiters = Math.Round((totalAmount / selectedOil.Price), 2);
                    lb_oil_price.Text = $"{oilLiters} литров";
                    tb_oil_count.Text = oilLiters.ToString();
                }
            }
        }

        private void UpdateOilValue(object sender, EventArgs e)
        {
            CalculateOilValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_sum.Text = (oilPrice + gudsumm).ToString();

            // Увеличить общую сумму выручки за день
            totalRevenue += oilPrice + gudsumm;
            DayMoney.Text = totalRevenue.ToString();

            // Запустить таймер для сброса формы через 10 секунд
            resetFormTimer.Start();
        }

        private void ResetFormTimer_Tick(object sender, EventArgs e)
        {
            ResetForm();
            resetFormTimer.Stop();
        }

        private void ResetForm()
        {
            // Сбросить все значения формы
            foreach (var checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }

            foreach (var textBox in textBoxes)
            {
                textBox.Text = "0";
            }

            comboBox_oil.SelectedIndex = -1;
            tb_oil_price.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tb_oil_count.Text = "0";
            tb_oil_sum.Text = "";
            lb_kafe_price.Text = "0";
            lb_oil_price.Text = "0";

            // Сбросить суммы и значения
            gudsumm = 0;
            oilLiters = 0;
            oilPrice = 0;
            lb_sum.Text = "0";

            // Старт таймера для сброса формы через 10 секунд
            resetFormTimer.Start();
        }
    }
}
