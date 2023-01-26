namespace HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            decimal numberOne;
            decimal numberTwo;
            decimal result;

            numberOne = EnterNumber();
            numberTwo = EnterNumber();

            result = numberOne + numberTwo;

            Console.WriteLine($"The sum is { result }");
        }

        /// <summary>
        /// User enters a number
        /// </summary>
        /// <returns>Number</returns>
        static decimal EnterNumber()
        {
            while(true)
            {
                Console.WriteLine("Please enter a number:");

                var readString = Console.ReadLine();

                bool isSuccess;
                decimal result;
                isSuccess = decimal.TryParse(readString, out result);

                if (isSuccess)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Please enter the number in a correct format!");
                }
            }
        }
    }
}