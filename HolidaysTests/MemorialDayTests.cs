using FluentAssertions;
using Holidays;
using Holidays.Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HolidaysTests
{
    [TestClass]
    public class MemorialDayTests
    {
        [TestMethod]
        public void GivenLastMondayInMay2020_WhenAskingIfObserved_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2020, 5, 25);
            IHoliday subject = new MemorialDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void GivenNonMondayLastDayInMay_WhenAskingIfObserved_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2020, 5, 31);
            IHoliday subject = new MemorialDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod]
        public void GivenLastMondayInMay2021_WhenAskingIfObserved_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2021, 5, 31);
            IHoliday subject = new MemorialDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void GivenNotMemorialDay_WhenAskingIfObserved_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2020, 6, 1);
            IHoliday subject = new MemorialDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }
    }
}
