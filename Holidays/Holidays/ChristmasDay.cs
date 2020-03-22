using System;

namespace Holidays.Holidays
{
    public class ChristmasDay : IHoliday
    {
        private readonly DateTime _date;
        private readonly IHoliday _nextStrategy;

        public ChristmasDay(DateTime date, IHoliday nextStrategy)
        {
            _date = date;
            _nextStrategy = nextStrategy;
        }

        public bool ObservedHoliday()
        {
            if (!new WeekendDay(_date) && _date.Month == 12 && _date.Day == 25) return true;
            if (new WeekendHolidayObservance(new DateTime(_date.Year, 12, 25), _date)) return true;

            return _nextStrategy.ObservedHoliday();
        }
    }
}