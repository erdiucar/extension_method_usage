using System;

namespace extension_method_usage
{
    class Program
    {
        private const int VALUE = 10;

        static void Main()
        {
            // Static methods are used like that
            int number = MathHelper.MultiplyByTwo(VALUE);

            // Extension methods are used like that
            number = VALUE.MultiplyByTwo();

            Console.WriteLine(number);
        }
    }
}
