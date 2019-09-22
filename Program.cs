using System;

namespace extension_method_usage
{
    class Program
    {
        private const int MAXIMUM_VALUE = 10;

        static void Main()
        {
            // Static methods are used like that
            int randomNumber = Randomize.GetRandomNumber(MAXIMUM_VALUE);

            // Extension methods are used like that
            randomNumber = MAXIMUM_VALUE.GetRandomNumber();

            Console.WriteLine(randomNumber);
        }
    }
}
