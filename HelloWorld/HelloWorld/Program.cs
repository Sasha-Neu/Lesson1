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
            Console.WriteLine("Please enter a number:");

            var readString = Console.ReadLine();

            return decimal.Parse(readString);
        }
    }
}