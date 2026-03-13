using Hotel.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HotelTests
{
    [TestClass]
    public class QueryTests
    {
        [TestMethod]
        public void Query_Constructor_SetsPropertiesCorrectly()
        {

            DateTime expectedDate = new DateTime(2026, 2, 24);
            RoomCategory expectedCategory = RoomCategory.Люкс;

            Query query = new Query(expectedDate, expectedCategory);

            Assert.AreEqual(expectedDate, query.CheckInDate);
            Assert.AreEqual(expectedCategory, query.SelectedCategory);
        }
    }
}
