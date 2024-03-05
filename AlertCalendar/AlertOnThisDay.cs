using System;
namespace AlertCalendar
{
	public class AlertOnThisDay : Alert
	{

		public AlertOnThisDay(string message) : base(message)
        {
        }

        public override void DisplayMessage(object sender, AlertEventArgs alertEventArgs)
		{
			if (alertEventArgs.DayNumber == 10)
			{
				Console.WriteLine(Message);
			}
		}
	}
}

