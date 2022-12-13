
namespace Day4;

public static class Rucksack
{
    public static int Part1()
    {
        static bool FullyContains(int[] ranges)
        {
            return (ranges[0] >= ranges[2] && ranges[1] <= ranges[3])
                || (ranges[2] >= ranges[0] && ranges[3] <= ranges[1]);
        }

        return GetInputArray().Count(FullyContains);
    }

    public static int Part2()
    {
        static bool Overlaps(int[] ranges)
        {
            return (ranges[2] <= ranges[1] && ranges[2] >= ranges[0])
                || (ranges[0] >= ranges[2] && ranges[0] <= ranges[3]);
        }

        return GetInputArray().Count(Overlaps);
    }

    private static IEnumerable<int[]> GetInputArray()
    {
        return File.ReadAllLines("input.txt")
                   .Select(l => l.Split('-', ',').Select(int.Parse).ToArray());
    }
}
