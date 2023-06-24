namespace HealthBreakCLITest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HealthBreakCLI cLI = new HealthBreakCLI();

            Console.Write("Enter url string - ");
            string url = Console.ReadLine();
            Console.Write("Quantity requests - ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            cLI.IsValidURl(url, quantity);
        }
    }
}