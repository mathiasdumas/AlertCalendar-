using System;
namespace AlertCalendar
{
	public class Calendar
	{
		public int Year { get; set; }
		public Day Day { get; set; }
		public Month Month { get; set; }
		public int DayNumber { get; set; }

        public event EventHandler<AlertEventArgs> OnYear;
		public event EventHandler<AlertEventArgs> OnMonth;
		public event EventHandler<AlertEventArgs> OnWeek;
		public event EventHandler<AlertEventArgs> OnNewDay;

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
            AlertEventArgs alertEventArgs = new AlertEventArgs(Year, Day, Month, DayNumber);
            if (DayNumber == 31)
			{
				DayNumber = 1;
				Month++;
				OnMonth?.Invoke(this, alertEventArgs);
                if (Month == Month.December)
				{
					Year++;
					Month = Month.January;
					OnYear?.Invoke(this, alertEventArgs);
                }
			} else
			{
                DayNumber++;
            }
			if (Day == Day.Sunday)
			{
				Day = Day.Monday;
				OnWeek?.Invoke(this, alertEventArgs);
            } else 
			{
                
                Day++;
            }
			OnNewDay?.Invoke(this, alertEventArgs);            
        }
	}
}

