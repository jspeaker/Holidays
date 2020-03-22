using FluentAssertions;
using Holidays;
using Holidays.Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HolidaysTests
{
    [TestClass]
    public class ChristmasEveTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenNonWeekendChristmasEve_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2020, 12, 24);
            IHoliday subject = new ChristmasEve(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSaturdayChristmasEve_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2016, 12, 24);
            IHoliday subject = new ChristmasEve(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenDecember23rdAndSaturdayChristmasEve_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2016, 12, 23);
            IHoliday subject = new ChristmasEve(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSundayChristmasEve_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2017, 12, 24);
            IHoliday subject = new ChristmasEve(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenDecember23rdAndSundayChristmasEve_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2017, 12, 22);
            IHoliday subject = new ChristmasEve(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenNotChristmasEve_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2019, 7, 1);
            IHoliday subject = new ChristmasEve(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }
    }
}