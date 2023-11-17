namespace HomeWork3
{
    class MonthChecker
    {
        public static void Checker(int monthNumber)
        {
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, monthNumber);
                Console.WriteLine($"The number of days in this month is {daysInMonth}");
            }
            Console.ReadKey();
        }      
    }
}