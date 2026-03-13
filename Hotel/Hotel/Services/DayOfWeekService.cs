using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public class DayOfWeekService
    {
        private static readonly Dictionary<DayOfWeek, string> RussianDays = new Dictionary<DayOfWeek, string>
        {
            { DayOfWeek.Monday, "понедельник" },
            { DayOfWeek.Tuesday, "вторник" },
            { DayOfWeek.Wednesday, "среда" },
            { DayOfWeek.Thursday, "четверг" },
            { DayOfWeek.Friday, "пятница" },
            { DayOfWeek.Saturday, "суббота" },
            { DayOfWeek.Sunday, "воскресенье" }
        };

        public string GetRussianDayOfWeek(DateTime date)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            return RussianDays.ContainsKey(dayOfWeek)
                ? RussianDays[dayOfWeek]
                : "неизвестный день";
        }

        public DayOfWeek GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek;
        }

  
        public bool IsWeekend(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
        }

        public bool IsWeekday(DateTime date)
        {
            return !IsWeekend(date);
        }
    }
}
