using System;

namespace Holidays
{
    public class LastDayOfWeekInMonth
    {
        private readonly DayOfWeek _dayOfWeek;
        private readonly int _year;
        private readonly int _month;
        private readonly int _daysInMonth;

        public LastDayOfWeekInMonth(DayOfWeek dayOfWeek, int year, int month, int daysInMonth)
        {
            _dayOfWeek = dayOfWeek;
            _year = year;
            _month = month;
            _daysInMonth = daysInMonth;
        }

        public DateTime Value()
        {
            for (int day = _daysInMonth; day > 0; day--)
            {
                DateTime date = new DateTime(_year, _month, day);
                if (date.DayOfWeek == _dayOfWeek) return date;
            }

            throw new Exception($"Last {_dayOfWeek} in month {_month} not found. Weird!");
        }
    }
}