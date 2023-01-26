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

            OperationType operationType = AskOperationType();

            if (operationType == OperationType.Plus)
            {
                result = numberOne + numberTwo;
            }
            else
            {
                result = numberOne - numberTwo;
            }

            Console.WriteLine($"The result is { result }");
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

        /// <summary>
        /// Asking the user for the operation type.
        /// </summary>
        /// <returns>Operation type</returns>
        static OperationType AskOperationType()
        {
            Console.WriteLine("Please type + if you want to add and - if you want to subtract.");

            var readString = Console.ReadLine();

            if (readString == "+")
            {
                return OperationType.Plus;
            }
            else if (readString == "-")
            {
                return OperationType.Minus;
            }
            else
            {
                Console.WriteLine("Please type + if you want to add and - if you want to subtract.");
                Environment.Exit(1);

                return OperationType.Minus; // Never will be reached because of Exit()
            }
        }
    }
}