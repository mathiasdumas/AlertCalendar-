using System;
namespace AlertCalendar
{
	public class AlertOnThisDay : Alert
	{
		public string Message { get; set; }


        public AlertOnThisDay()
        {
        }

		public AlertOnThisDay(string message) : base(message)
        {
            Message = message;
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

