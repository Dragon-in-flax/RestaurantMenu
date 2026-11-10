using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class HtmlStrategy : IFormatStrategy
    {
        public string Format(List<Dish> dishes)
        {
            StringBuilder sb = new StringBuilder();

            //Обязательные теги для HTML
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta charset=\"UTF-8\">");
            sb.AppendLine("<title>Меню ресторана</title>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("<h1>Наше меню</h1>");

            foreach (var dish in dishes)
            {
                //Экранирование символов
                string safeName = EscapeHtml(dish.Name);
                string safeCategory = EscapeHtml(dish.Category);
                string safeComposition = EscapeHtml(dish.Composition);

                //Каждая запись заканчивается тегом <br>
                sb.AppendLine($"<b>{safeName}</b> (Категория: {safeCategory})<br>");
                sb.AppendLine($"Состав: {safeComposition}<br>");
                sb.AppendLine($"Цена: {dish.Price} руб.<br><hr>");
            }

            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            return sb.ToString();
        }

        //Экранирование символов для HTML, чтобы в случае ввода HTML не воспринял текст как команду
        private string EscapeHtml(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";

            return text.Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt")
                .Replace("\"", "&quot");
        }
    }
}
