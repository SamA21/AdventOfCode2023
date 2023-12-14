using AdventHelper;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allLines = AdventTextReader.GetListFromFile("data.txt", true);
            var result = GameManager.GetTotalIds(allLines);
            Console.WriteLine(result);
        }
    }
}
