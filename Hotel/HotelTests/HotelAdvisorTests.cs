using Hotel.Advisors;
using Hotel.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTests
{
    public class HotelAdvisorTests
    {
        private HotelAdvisor _advisor;

        [TestInitialize]
        public void Setup()
        {
            _advisor = new HotelAdvisor();
        }

        [TestMethod]
        public void GetAdvice_LuxuryOnTuesday_ReturnsSpecialAdvice()
        {
            DateTime testDate = new DateTime(2026, 2, 24);
            Query query = new Query(testDate, RoomCategory.Люкс);
            string expectedAdvice = "Вы выбрали Люкс. По вторникам у нас тихо, и вы можете насладиться видом на город. Рекомендуем забронировать столик в ресторане — действует скидка 10% для гостей Люкса.";

            string actualAdvice = _advisor.GetAdvice(query);

            Assert.AreEqual(expectedAdvice, actualAdvice);
        }

        [TestMethod]
        public void GetAdvice_LuxuryOnFriday_ReturnsSpecialAdvice()
        {
            DateTime testDate = new DateTime(2026, 2, 27);
            Query query = new Query(testDate, RoomCategory.Люкс);
            string expectedAdvice = "Вы выбрали Люкс. В пятницу у нас живая музыка в лобби-баре. Рекомендуем взять номер с дополнительной шумоизоляцией, если планируете рано ложиться.";

            string actualAdvice = _advisor.GetAdvice(query);

            Assert.AreEqual(expectedAdvice, actualAdvice);
        }

        [TestMethod]
        public void GetAdvice_EconomyOnFriday_ReturnsSpecialAdvice()
        {
            DateTime testDate = new DateTime(2026, 2, 27);
            Query query = new Query(testDate, RoomCategory.Эконом);
            string expectedAdvice = "Вы выбрали Эконом. По пятницам у нас большая загрузка, рекомендуем заселиться до 18:00, чтобы избежать очереди на ресепшене. Завтрак включён в стоимость.";

            string actualAdvice = _advisor.GetAdvice(query);

            Assert.AreEqual(expectedAdvice, actualAdvice);
        }
    }
}
