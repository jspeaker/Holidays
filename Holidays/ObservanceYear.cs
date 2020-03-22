using System;

namespace Holidays
{
    public class ObservanceYear
    {
        private readonly DateTime _date;

        public ObservanceYear(DateTime date) => _date = date;

        public static implicit operator int(ObservanceYear value) => value._date.Month == 12 && value._date.Day == 31
            ? value._date.Year + 1
            : value._date.Year;
    }
}