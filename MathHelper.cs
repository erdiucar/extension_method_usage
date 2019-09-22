namespace extension_method_usage
{
    public static class MathHelper
    {
        /// <summary>
        ///  Returns the number multiplied by two.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int MultiplyByTwo(this int number)
        {
            return number * 2;
        }
    }
}
