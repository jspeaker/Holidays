using System;

namespace Holidays
{
    public class NthInstanceOfDayOfWeekInMonth
    {
        private readonly int _nthInstance;
        private readonly DayOfWeek _dayOfWeek;
        private readonly int _year;
        private readonly int _month;
        private readonly int _daysInMonth;

        public NthInstanceOfDayOfWeekInMonth(int nthInstance, DayOfWeek dayOfWeek, int year, int month, int daysInMonth)
        {
            _nthInstance = nthInstance;
            _dayOfWeek = dayOfWeek;
            _year = year;
            _month = month;
            _daysInMonth = daysInMonth;
        }

        public DateTime Value()
        {
            int instanceCount = 0;
            for (int day = 1; day < _daysInMonth; day++)
            {
                DateTime date = new DateTime(_year, _month, day);
                if (date.DayOfWeek == _dayOfWeek) instanceCount++;

                if (instanceCount == _nthInstance) return date;
            }

            throw new Exception($"Instance number {_nthInstance} of {_dayOfWeek} in month number {_month} not found. Weird!");
        }
    }
}