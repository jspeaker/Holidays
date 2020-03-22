using FluentAssertions;
using Holidays;
using Holidays.Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HolidaysTests
{
    [TestClass]
    public class ChristmasDayTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenNonWeekendChristmasDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2020, 12, 25);
            IHoliday subject = new ChristmasDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSaturdayChristmasDay_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2010, 12, 25);
            IHoliday subject = new ChristmasDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenDecember24thAndSaturdayChristmasDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2010, 12, 24);
            IHoliday subject = new ChristmasDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSundayChristmasDay_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2016, 12, 25);
            IHoliday subject = new ChristmasDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenDecember26thAndSundayChristmasDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2016, 12, 26);
            IHoliday subject = new ChristmasDay(date, new NonHoliday());

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
            IHoliday subject = new ChristmasDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }
    }
}