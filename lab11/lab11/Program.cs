namespace lab11
{
    using System;

    delegate string GetWeekDay();

    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDaysRussianNames = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            int currentDay = 0;


            GetWeekDay getWeekDay = () =>
            {
                int day = currentDay % 7;
                currentDay++;
                return weekDaysRussianNames[day];
            };

            
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(getWeekDay());
            }
        }
    }
}