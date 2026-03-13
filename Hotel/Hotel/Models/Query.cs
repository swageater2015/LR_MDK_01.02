using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Query
    {
        public RoomCategory SelectedCategory { get; set; }
        public DateTime CheckInDate { get; set; }
        public static object RoomCategory { get; internal set; }

        public Query(DateTime date, RoomCategory category)
        {
            CheckInDate = date;
            SelectedCategory = category;
        }
    }
}
