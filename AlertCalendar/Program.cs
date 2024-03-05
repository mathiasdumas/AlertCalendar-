namespace AlertCalendar;

class Program
{
    static void Main(string[] args)
    {

        Calendar calendar = new Calendar(2024, Day.Sunday, Month.January, 1);
        Alert alert1 = new Alert("bonne journée");
        Alert alert2 = new Alert("bonne semaine");
        Alert alert3 = new Alert("bon mois");
        Alert alert4 = new Alert("bonne année");

        AlertOnThisDay alert5 = new AlertOnThisDay("sortir les poubelles");


        calendar.OnNewDay += alert1.DisplayMessage;
        calendar.OnMonth += alert3.DisplayMessage;
        calendar.OnWeek += alert2.DisplayMessage;
        calendar.OnYear += alert4.DisplayMessage;
        calendar.OnNewDay += alert5.DisplayMessage;
        

        while (calendar.Year != 2025 || calendar.DayNumber != 2)
        {
            Console.WriteLine($"le {calendar.Day} {calendar.DayNumber} {calendar.Month}, {calendar.Year}");
            calendar.NextDay();
        }

        for (int i = 0; i < 100; i++)
        {
            
        }
        

        
    }
}

