using System;

namespace Holidays.Holidays
{
    public class ChristmasEve : IHoliday
    {
        private readonly DateTime _date;
        private readonly IHoliday _nextStrategy;

        public ChristmasEve(DateTime date, IHoliday nextStrategy)
        {
            _date = date;
            _nextStrategy = nextStrategy;
        }

        public bool ObservedHoliday()
        {
            if (!new WeekendDay(_date) && _date.Month == 12 && _date.Day == 24) return true;
            if (_date.DayOfWeek == DayOfWeek.Friday && _date.Month == 12 && (_date.Day == 22 || _date.Day == 23)) return true;

            return _nextStrategy.ObservedHoliday();
        }
    }
}