using FluentAssertions;
using Holidays;
using Holidays.Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HolidaysTests
{
    [TestClass]
    public class LaborDayTests
    {
        [TestMethod]
        public void GivenFirstMondayInSeptember2020_WhenAskingIfObserved_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2020, 9, 7);
            IHoliday subject = new LaborDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void GivenNotFirstMondayInSeptember_WhenAskingIfObserved_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2020, 6, 1);
            IHoliday subject = new LaborDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }
    }
}
