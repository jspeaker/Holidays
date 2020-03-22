using FluentAssertions;
using Holidays;
using Holidays.Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HolidaysTests
{
    [TestClass]
    public class DayAfterThanksgivingTests
    {
        [TestMethod]
        public void GivenFourthFridayInNovember2020_WhenAskingIfObserved_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2020, 11, 27);
            IHoliday subject = new DayAfterThanksgiving(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void GivenNotFourthFridayInNovember_WhenAskingIfObserved_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2020, 6, 1);
            IHoliday subject = new DayAfterThanksgiving(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }
    }
}
