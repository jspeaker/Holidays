using System;

namespace Holidays.Holidays
{
    public class MemorialDay : IHoliday
    {
        private readonly DateTime _date;
        private readonly IHoliday _nextStrategy;

        public MemorialDay(DateTime date, IHoliday nextStrategy)
        {
            _date = date;
            _nextStrategy = nextStrategy;
        }

        public bool ObservedHoliday()
        {
            if (new LastDayOfWeekInMonth(DayOfWeek.Monday, _date.Year, 5, 31).Value() == _date) return true;

            return _nextStrategy.ObservedHoliday();
        }
    }
}