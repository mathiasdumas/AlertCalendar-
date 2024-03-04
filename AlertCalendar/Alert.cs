using System;
namespace AlertCalendar
{
	public class Alert
	{
		public string Message { get; set; }

		public Alert()
		{
		}

        public Alert(string message)
        {
            Message = message;
        }

        public virtual void DisplayMessage(object sender, AlertEventArgs alertEventArgs)
		{
			Console.WriteLine(Message);
		}
    }
}

