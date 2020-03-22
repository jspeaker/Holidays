using System;

namespace Holidays.Holidays
{
    public class ThanksgivingDay : IHoliday
    {
        private readonly DateTime _date;
        private readonly IHoliday _nextStrategy;

        public ThanksgivingDay(DateTime date, IHoliday nextStrategy)
        {
            _date = date;
            _nextStrategy = nextStrategy;
        }

        public bool ObservedHoliday()
        {
            if (new NthInstanceOfDayOfWeekInMonth(4, DayOfWeek.Thursday, _date.Year, 11, 30).Value() == _date) return true;

            return _nextStrategy.ObservedHoliday();
        }
    }
}