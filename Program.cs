namespace HomeWork3
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter string:");
            StringChecker.Checker(Console.ReadLine());

            Console.WriteLine("Please, enter the month number");
            MonthChecker.Checker(Convert.ToInt32(Console.ReadLine()));
        }
    }
}