using System;

namespace Holidays
{
    public class WeekendDay
    {
        private readonly DateTime _date;

        public static implicit operator bool(WeekendDay value) => value._date.DayOfWeek == DayOfWeek.Saturday || value._date.DayOfWeek == DayOfWeek.Sunday;

        public WeekendDay(DateTime date) => _date = date;
    }
}