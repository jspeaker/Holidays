using FluentAssertions;
using Holidays;
using Holidays.Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HolidaysTests
{
    [TestClass]
    public class IndependenceDayTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenNonWeekendIndependenceDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2019, 7, 4);
            IHoliday subject = new IndependenceDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSaturdayIndependenceDay_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2020, 7, 4);
            IHoliday subject = new IndependenceDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenJulyThirdAndSaturdayIndependenceDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2020, 7, 3);
            IHoliday subject = new IndependenceDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSundayIndependenceDay_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2021, 7, 4);
            IHoliday subject = new IndependenceDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenJulyFifthSundayIndependenceDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            DateTime date = new DateTime(2021, 7, 5);
            IHoliday subject = new IndependenceDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenNotIndependenceDay_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            DateTime date = new DateTime(2019, 7, 1);
            IHoliday subject = new IndependenceDay(date, new NonHoliday());

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }
    }
}