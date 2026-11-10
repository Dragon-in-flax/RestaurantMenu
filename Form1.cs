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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
