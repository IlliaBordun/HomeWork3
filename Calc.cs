namespace HomeWork3
{
    class Calc
    {
        public static void Calculation()
        {
            int[] numbers = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Please, enter an integer number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result;
            if (numbers[0] >= 0 && numbers[1] >= 0 && numbers[2] >= 0 && numbers[3] >= 0 && numbers[4] >= 0)
            {
                result = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
                Console.WriteLine($"The sum of the first 5 is {result}");
            }
            else
            {
                result = numbers[5] * numbers[6] * numbers[7] * numbers[8] * numbers[9];
                Console.WriteLine($"The product of the last 5 is {result}");
            }
        }
    }
}