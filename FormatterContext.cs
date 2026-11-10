using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class FormatterContext
    {
        //Хранит текущую стратегию
        private IFormatStrategy _strategy;
        //Устанавливает/меняет стратегию
        public void SetStrategy(IFormatStrategy strategy)
        {
            _strategy = strategy;
        }

        //Запускает алгоритм выбранной стратегии
        public string ExecuteFormatting(List<Dish> dishes)
        {
            if (_strategy == null) return "Стратегия не выбрана!";
            //Делегирует работу стратегии
            return _strategy.Format(dishes);
        }
    }
}
