using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class RoomNumber
    {
        public double price_;
        public int floor_;
        public string number_;
        public string category_;

        public RoomNumber(double price, int floor, string number, string category)
        {
            price_ = price;
            floor_ = floor;
            number_ = number;
            category_ = category;
        }

        public double Price
        {
            get { return price_; }
        }
        public int Floor
        {
            get { return floor_; }
        }
        public string Number
        {
            get { return number_; }
        }
        public string Category
        {
            get { return category_; }
        }

        List<RoomNumber> roomNumbers = new List<RoomNumber>();
    }
}
