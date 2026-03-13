using Hotel.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTests
{
    public class DayOfWeekServiceTests
    {
        private DayOfWeekService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new DayOfWeekService();
        }

        [TestMethod]
        public void GetRussianDayOfWeek_For2422026_ReturnsTuesday()
        {
            DateTime testDate = new DateTime(2026, 2, 24);
            string expectedDay = "вторник";

            string actualDay = _service.GetRussianDayOfWeek(testDate);

            Assert.AreEqual(expectedDay, actualDay);
        }

        [TestMethod]
        public void GetRussianDayOfWeek_For2722026_ReturnsFriday()
        {
            DateTime testDate = new DateTime(2026, 2, 27);
            string expectedDay = "пятница";

            string actualDay = _service.GetRussianDayOfWeek(testDate);

            Assert.AreEqual(expectedDay, actualDay);
        }
    }
}

