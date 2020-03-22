using System;

namespace Holidays.Holidays
{
    public class IndependenceDay : IHoliday
    {
        private readonly DateTime _date;
        private readonly IHoliday _nextStrategy;

        public IndependenceDay(DateTime date, IHoliday nextStrategy)
        {
            _date = date;
            _nextStrategy = nextStrategy;
        }

        public bool ObservedHoliday()
        {
            if (!new WeekendDay(_date) && _date.Month == 7 && _date.Day == 4) return true;
            if (new WeekendHolidayObservance(new DateTime(_date.Year, 7, 4), _date)) return true;

            return _nextStrategy.ObservedHoliday();
        }
    }
}