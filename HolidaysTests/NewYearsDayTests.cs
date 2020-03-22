using FluentAssertions;
using Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Holidays.Holidays;

namespace HolidaysTests
{
    [TestClass]
    public class NewYearsDayTests
    {
        [TestMethod]
        public void GivenSunday_WhenAskingIfObserved_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2017, 1, 1);
            IHoliday subject = new NewYearsDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            date.DayOfWeek.Should().Be(DayOfWeek.Sunday);
            actual.Should().BeFalse();
        }

        [TestMethod]
        public void GivenMondayAndNewYearsDayOnSunday_WhenAskingIfObserved_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2017, 1, 2);
            IHoliday subject = new NewYearsDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            date.DayOfWeek.Should().Be(DayOfWeek.Monday);
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void GivenSaturday_WhenAskingIfObserved_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2022, 1, 1);
            IHoliday subject = new NewYearsDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            date.DayOfWeek.Should().Be(DayOfWeek.Saturday);
            actual.Should().BeFalse();
        }

        [TestMethod]
        public void GivenFridayAndNewYearsDayOnSaturday_WhenAskingIfObserved_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2021, 12, 31);
            IHoliday subject = new NewYearsDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            date.DayOfWeek.Should().Be(DayOfWeek.Friday);
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void GivenNewYearsDayNotOnWeekend_WhenAskingIfObserved_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2020, 1, 1);
            IHoliday subject = new NewYearsDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            date.DayOfWeek.Should().NotBe(DayOfWeek.Saturday);
            date.DayOfWeek.Should().NotBe(DayOfWeek.Sunday);
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void GivenNewYearsDayNotOnWeekendAndDayAfter_WhenAskingIfObserved_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2020, 1, 2);
            IHoliday subject = new NewYearsDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            date.AddDays(-1).DayOfWeek.Should().NotBe(DayOfWeek.Saturday);
            date.AddDays(-1).DayOfWeek.Should().NotBe(DayOfWeek.Sunday);
            actual.Should().BeFalse();
        }
    }
}
