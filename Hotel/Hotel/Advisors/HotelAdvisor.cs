using Hotel.Interfaces;
using Hotel.Models;
using Hotel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Advisors
{
    public class HotelAdvisor : IAdvisor
    {
        private readonly DayOfWeekService _dayOfWeekService;
        private readonly AdviceService _adviceService;

        public HotelAdvisor()
        {
            _dayOfWeekService = new DayOfWeekService();
            _adviceService = new AdviceService();
        }

        public HotelAdvisor(DayOfWeekService dayOfWeekService, AdviceService adviceService)
        {
            _dayOfWeekService = dayOfWeekService;
            _adviceService = adviceService;
        }

        public string GetAdvice(Query query)
        {
            string dayOfWeek = _dayOfWeekService.GetRussianDayOfWeek(query.CheckInDate);

            return _adviceService.GetAdvice(query.SelectedCategory, dayOfWeek);
        }

        public string GetAdvice(RoomCategory category, DateTime date)
        {
            string dayOfWeek = _dayOfWeekService.GetRussianDayOfWeek(date);
            return _adviceService.GetAdvice(category, dayOfWeek);
        }
    }
}
