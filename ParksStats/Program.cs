namespace ParksStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printer = new ParkInfoPrinter();
            printer.PrintParksInfo();
        }
    }
}
