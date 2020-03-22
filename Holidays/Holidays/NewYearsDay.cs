using System;

namespace Holidays.Holidays
{
    public class NewYearsDay : IHoliday
    {
        private readonly DateTime _date;
        private readonly WeekendDay _weekendDay;
        private readonly WeekendHolidayObservance _weekendHolidayObservance;
        private readonly IHoliday _nextStrategy;

        public NewYearsDay(DateTime date, IHoliday nextStrategy) : 
            this(date, new WeekendDay(date), new WeekendHolidayObservance(new DateTime(new ObservanceYear(date), 1, 1), date), nextStrategy) {  }

        private NewYearsDay(DateTime date, WeekendDay weekendDay, WeekendHolidayObservance weekendHolidayObservance, IHoliday nextStrategy)
        {
            _date = date;
            _weekendDay = weekendDay;
            _weekendHolidayObservance = weekendHolidayObservance;
            _nextStrategy = nextStrategy;
        }

        public bool ObservedHoliday()
        {
            if (!_weekendDay && _date.Month == 1 && _date.Day == 1) return true;
            if (_weekendHolidayObservance) return true;

            return _nextStrategy.ObservedHoliday();
        }
    }
}