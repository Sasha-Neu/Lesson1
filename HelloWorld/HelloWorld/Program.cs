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
            string name;

            name = EnterName();

            var greeting = "Hello";
           

            Console.WriteLine($"{ greeting }, { name }!");
        }

        /// <summary>
        /// Entering name from console
        /// </summary>
        /// <returns>Username</returns>
        static string EnterName()
        {
            Console.WriteLine("Please, enter your name:");

            string userName;
            userName = Console.ReadLine();

            return userName;
        }
    }
}