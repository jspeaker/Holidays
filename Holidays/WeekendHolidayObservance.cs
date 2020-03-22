using Holidays.Holidays;
using System;

namespace Holidays
{
    public class WeekendHolidayObservance
    {
        private readonly WeekendDay _weekendDay;
        private readonly DateTime _holidayDate;
        private readonly DateTime _date;

        public WeekendHolidayObservance(DateTime holidayDate, DateTime date) : this(holidayDate, date, new WeekendDay(holidayDate)) { }

        private WeekendHolidayObservance(DateTime holidayDate, DateTime date, WeekendDay weekendDay)
        {
            _holidayDate = holidayDate;
            _date = date;
            _weekendDay = weekendDay;
        }

        public static implicit operator bool(WeekendHolidayObservance value)
        {
            if (!value._weekendDay) return false;

            return value._date.DayOfWeek == DayOfWeek.Friday && value._holidayDate.AddDays(-1) == value._date ||
                   value._date.DayOfWeek == DayOfWeek.Monday && value._holidayDate.AddDays(1) == value._date;
        }
    }
}