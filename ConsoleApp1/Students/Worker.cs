using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Worker : Human
    {
        float WeekSalar { get; set; }
        int WorkHoursPerDay { get; set; }

        public float MoneyPerHour()
        {
            return WeekSalar / WorkHoursPerDay * 5;
        }

        public Worker(string firstName, string lastName, float weekSalar, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalar = weekSalar;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public void Print()
        {
            Console.WriteLine($"Week Salar={WeekSalar}, works hour per day={WorkHoursPerDay}");
        }
    }
}
