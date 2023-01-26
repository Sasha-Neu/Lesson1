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
            string operationName;

            numberOne = EnterNumber();
            numberTwo = EnterNumber();

            OperationType operationType = AskOperationType();

            switch(operationType)
            {
                case OperationType.Plus:
                    result = numberOne + numberTwo;
                    operationName = "sum";
                    break;

                case OperationType.Minus:
                    result = numberOne - numberTwo;
                    operationName = "difference";
                    break;

                case OperationType.Multiplication:
                    result = numberOne * numberTwo;
                    operationName = "product";
                    break;

                case OperationType.Division:
                    result = numberOne / numberTwo;
                    operationName = "quotient";
                    break;

                default:
                    throw new InvalidOperationException("Incorrect operation type!");
            }
            
            Console.WriteLine($"The { operationName } is { result }.");
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
            Console.WriteLine("Please type +, -, * or / for operation type.");

            var readString = Console.ReadLine();

            if (readString == "+")
            {
                return OperationType.Plus;
            }
            else if (readString == "-")
            {
                return OperationType.Minus;
            }
            else if (readString == "*")
            {
                return OperationType.Multiplication;
            }
            else if (readString == "/")
            {
                return OperationType.Division;
            }
            else
            {
                Console.WriteLine("Please type +, -, * or / for operation type.");
                Environment.Exit(1);

                return OperationType.Minus; // Never will be reached because of Exit()
            }
        }
    }
}