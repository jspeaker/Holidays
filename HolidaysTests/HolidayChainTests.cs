using FluentAssertions;
using Holidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HolidaysTests
{
    [TestClass]
    public class HolidayChainTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenNewYearsDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 1, 1));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenMemorialDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 5, 25));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIndependenceDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 7, 3));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenLaborDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 9, 7));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenThanksgivingDay_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 11, 26));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenDayAfterThanksgiving_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 11, 27));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenChristmasEve_WhenAskingIfObservedHoliday_ThenItShouldReturnTrue()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 12, 24));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenNonHoliday_WhenAskingIfObservedHoliday_ThenItShouldReturnFalse()
        {
            // arrange
            IHoliday subject = new Privateer().Object<HolidayChain>(new DateTime(2020, 2, 1));

            // act
            bool actual = subject.ObservedHoliday();

            // assert
            actual.Should().BeFalse();
        }
    }
}