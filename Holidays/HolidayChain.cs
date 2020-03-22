using Holidays.Holidays;
using System;

namespace Holidays
{
    public class HolidayChain : IHoliday
    {
        private readonly IHoliday _strategy;
        public HolidayChain() : this(DateTime.Today) { }

        private HolidayChain(DateTime date) : 
            this(
                new NewYearsDay(date,
                    new MemorialDay(date, 
                        new IndependenceDay(date, 
                            new LaborDay(date, 
                                new ThanksgivingDay(date, 
                                    new DayAfterThanksgiving(date, 
                                        new ChristmasEve(date, 
                                            new NonHoliday())))))))) { }

        private HolidayChain(IHoliday strategy) => _strategy = strategy;

        public bool ObservedHoliday() => _strategy.ObservedHoliday();
    }
}