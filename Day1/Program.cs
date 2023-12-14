using AdventHelper;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allLines = AdventTextReader.GetListFromFile("data.txt", true);
            var result = Calibrator.GetTotalCalibrationNumber(allLines, false);    
            Console.WriteLine(result);
            allLines = AdventTextReader.GetListFromFile("part2Data.txt", true);
            var result2 = Calibrator.GetTotalCalibrationNumber(allLines, true);
            Console.WriteLine(result2);

        }
    }
}
