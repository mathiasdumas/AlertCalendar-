using System;
namespace AlertCalendar
{
	public class Calendar
	{
		public int Year { get; set; }
		public Day Day { get; set; }
		public Month Month { get; set; }
		public int DayNumber { get; set; }

        public event Action OnYear;
		public event Action OnMonth;
		public event Action OnWeek;
		public event Action OnNewDay;

		public Calendar()
		{
		}

        public Calendar(int year, Day day, Month month, int dayNumber)
        {
            Year = year;
            Day = day;
            Month = month;
            DayNumber = dayNumber;
			
        }

		public void NextDay()
		{


			if (DayNumber == 31)
			{
				DayNumber = 1;
				OnMonth();
				if (Month == Month.December)
				{
					Year++;
					Month = Month.January;
					OnYear();
				}
			} else
			{
                DayNumber++;
            }


			if (Day == Day.Sunday)
			{
				Day = Day.Monday;
				OnWeek();
			} else 
			{
                
                Day++;
            }

            OnNewDay();
        }
	}
}

