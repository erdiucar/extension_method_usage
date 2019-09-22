using System;

namespace extension_method_usage
{
    public static class Randomize
    {
        private static readonly Random random = new Random();

        /// <summary>
        ///  Returns a random number.
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int GetRandomNumber(this int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
