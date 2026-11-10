using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class Form1 : Form
    {
        //Список блюд
        private List<Dish> _dishes = new List<Dish>();
        //Переключатель стратегии
        private FormatterContext _formatter = new FormatterContext();
        public Form1()
        {
            InitializeComponent();
            //Варианты выбора стратегии
            cmbFormat.Items.Add("Обычный текст");
            cmbFormat.Items.Add("HTML");
            cmbFormat.SelectedIndex = 0; //Обычный теуст по умолчанию
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (_dishes.Count == 0)
            {
                MessageBox.Show("Сначала добавьте хотя бы одно блюдо!", "Список пуст");
                return;
            }

            // ВЫБОР ФОРМАТА FORMATTER
            if (cmbFormat.SelectedIndex == 0)
            {
                _formatter.SetStrategy(new TextStrategy());
            }
            else if (cmbFormat.SelectedIndex == 1)
            {
                _formatter.SetStrategy(new HtmlStrategy());
            }

            //Отправка данных в контекст стратегии
            string result = _formatter.ExecuteFormatting(_dishes);
            textBox.Text = result; //вывод
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim(); // Trim удаляет лишние пробелы в начале и конце текста
            string category = txtCategory.Text.Trim();
            string composition = txtComposition.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Необходимо ввести название и цену!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Цена должна быть числом (например: 450,50)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Создает новое блюдо
            Dish newDish = new Dish(name, category, composition, price);
            _dishes.Add(newDish); //Добавляет в список

            //Отображение в реальном времени в ListBox
            lstDishes.Items.Add($"{name} – {price} руб.");

            //Очищает поля ввода
            txtName.Clear();
            txtCategory.Clear();
            txtComposition.Clear();
            txtPrice.Clear();
        }
    }
}
