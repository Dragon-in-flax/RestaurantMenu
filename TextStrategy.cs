using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class TextStrategy : IFormatStrategy
    {
        public string Format(List<Dish> dishes)
        {
            /*
            В отличие от string позволяет добавлять записи в конец
            В C# тип string – неизменяемый, можно только создать новую
            StringBuilder хранит текст в виде массива символов и может динамически расширяться
            */
            StringBuilder sb = new StringBuilder(); // Создается новый массив

            foreach (var dish in dishes) // перебирает список (пока dish есть в dishes)
            {
                //Добавляет текст в конец массива. В конце переносит курсор на новую строку
                sb.AppendLine($"Блюдо: {dish.Name} " +
                    $"→ Категория: {dish.Category} " +
                    $"→ Состав: {dish.Composition} " +
                    $"→ Цена: {dish.Price} руб.");
            }
            //Переводит массив символов в строку и возвращает её
            return sb.ToString();
        }
    }
}
