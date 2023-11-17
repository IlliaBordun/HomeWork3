namespace HomeWork3
{
    class StringChecker
    {
        public static void Checker(string str)
        {
            int charA = 0;
            int charO = 0;
            int charI = 0;
            int charE = 0;

            foreach (char el in str)
            {
                if (el == 'a')
                    charA += 1;
                if (el == 'o')
                    charO += 1;
                if (el == 'i')
                    charI += 1;
                if (el == 'e')
                    charE += 1;
            }
            
            Console.Write($"{charA} \n{charO} \n{charI} \n{charE}");
            Console.ReadKey();    
        }
    }
}