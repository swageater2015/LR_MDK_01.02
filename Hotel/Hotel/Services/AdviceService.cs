using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public class AdviceService
    {

        private readonly Dictionary<(RoomCategory, string), string> _adviceStorage;

        public AdviceService()
        {
            _adviceStorage = new Dictionary<(RoomCategory, string), string>();
            InitializeAdvices();
        }

        private void InitializeAdvices()
        {
 
            _adviceStorage[(RoomCategory.Люкс, "вторник")] =
                "Вы выбрали Люкс. По вторникам у нас тихо, и вы можете насладиться видом на город. Рекомендуем забронировать столик в ресторане — действует скидка 10% для гостей Люкса.";

            _adviceStorage[(RoomCategory.Люкс, "пятница")] =
                "Вы выбрали Люкс. В пятницу у нас живая музыка в лобби-баре. Рекомендуем взять номер с дополнительной шумоизоляцией, если планируете рано ложиться.";

            _adviceStorage[(RoomCategory.Эконом, "пятница")] =
                "Вы выбрали Эконом. По пятницам у нас большая загрузка, рекомендуем заселиться до 18:00, чтобы избежать очереди на ресепшене. Завтрак включён в стоимость.";

            _adviceStorage[(RoomCategory.Стандарт, "понедельник")] =
                "Вы выбрали Стандарт. Начало недели — отличное время для деловых поездок. В бизнес-центре отеля свободные места.";

            _adviceStorage[(RoomCategory.Студия, "четверг")] =
                "Вы выбрали Студию. Четверг — день скидок в нашем спа-салоне. Гостям студии массаж за полцены.";

            _adviceStorage[(RoomCategory.Семейный, "суббота")] =
                "Вы выбрали Семейный номер. По субботам в бассейне проводятся детские занятия с 10:00 до 11:30.";

            _adviceStorage[(RoomCategory.Президентский, "суббота")] =
                "Вы выбрали Президентский номер. В выходные для вас забронирован личный автомобиль с водителем на 4 часа.";
        }

        public string GetAdvice(RoomCategory category, string dayOfWeek)
        {
            string lowerDay = dayOfWeek.ToLower();
            var key = (category, lowerDay);

            return _adviceStorage.ContainsKey(key)
                ? _adviceStorage[key]
                : GetDefaultAdvice(category);
        }

        private string GetDefaultAdvice(RoomCategory category)
        {
            string categoryName = GetCategoryName(category);
            return $"Вы выбрали категорию '{categoryName}'. Желаем приятного отдыха в нашем отеле! Для более точных рекомендаций обратитесь на стойку регистрации.";
        }

        private string GetCategoryName(RoomCategory category)
        {
            return category.ToString();
        }
    }
}
