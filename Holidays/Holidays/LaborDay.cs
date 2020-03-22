using System;

namespace Holidays.Holidays
{
    public class LaborDay : IHoliday
    {
        private readonly DateTime _date;
        private readonly IHoliday _nextStrategy;

        public LaborDay(DateTime date, IHoliday nextStrategy)
        {
            _date = date;
            _nextStrategy = nextStrategy;
        }

        public bool ObservedHoliday()
        {
            if (new NthInstanceOfDayOfWeekInMonth(1, DayOfWeek.Monday, _date.Year, 9, 30).Value() == _date) return true;

            return _nextStrategy.ObservedHoliday();
        }
    }
}