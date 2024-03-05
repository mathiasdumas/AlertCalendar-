using System;
namespace AlertCalendar
{
	public class AlertEventArgs : EventArgs
	{
        public int Year { get; set; }
        public Day Day { get; set; }
        public Month Month { get; set; }
        public int DayNumber { get; set; }


        public AlertEventArgs(int year, Day day, Month month, int dayNumber)
        {
            Year = year;
            Day = day;
            Month = month;
            DayNumber = dayNumber;
        }
    }
}

