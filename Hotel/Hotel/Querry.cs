using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Querry
    {
        public enum RoomCategory { get; set; }
        public DateTime CheckInDate { get; set; }
        public enum DayOfweek(DateTime checkInDate) 
        public RoomCategory SelectedCategory { get; set; }
        public string GetDayOfWeek()
        {
            DayOfweek dayOfweek = CheckInDate.DayOfWeek;
        }
        
    }
}
