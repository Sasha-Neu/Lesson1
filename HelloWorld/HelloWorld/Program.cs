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

            if (operationType == OperationType.Plus)
            {
                result = numberOne + numberTwo;
                operationName = "sum";
            }
            else if (operationType == OperationType.Minus)
            {
                result = numberOne - numberTwo;
                operationName = "difference";
            }
            else if (operationType == OperationType.Multiplication)
            {
                result = numberOne * numberTwo;
                operationName = "product";
            }
            else
            {
                result = numberOne / numberTwo;
                operationName = "quotient";
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

                decimal result;
                if (decimal.TryParse(readString, out result))
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
            while(true)
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
            }
        }
    }
}