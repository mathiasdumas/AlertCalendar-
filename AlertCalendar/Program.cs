namespace AlertCalendar;

class Program
{
    static void Main(string[] args)
    {

        Calendar calendar = new Calendar(2024, Day.Sunday, Month.December, 31);
        Alert alert1 = new Alert("bonne journée");
        Alert alert2 = new Alert("bonne semaine");
        Alert alert3 = new Alert("bon mois");
        Alert alert4 = new Alert("bonne année");


        calendar.OnNewDay += alert1.DisplayMessage;

        calendar.OnYear += alert4.DisplayMessage;

        calendar.OnMonth += alert3.DisplayMessage;

        calendar.OnWeek += alert2.DisplayMessage;


        calendar.NextDay();

        Console.WriteLine($"jour : {calendar.Day}, jour nombre : {calendar.DayNumber}, mois : {calendar.Month}, année {calendar.Year}");


    }
}

