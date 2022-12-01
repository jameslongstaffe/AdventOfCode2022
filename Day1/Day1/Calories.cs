
namespace Day1;

public static class Calories
{
    public static int MaxCalories(string input)
    {
        return GetGroups(input).Max(x => x.Sum());
    }

    public static int TopThreeCalories(string input)
    {
        return GetGroups(input).Select(c => c.Sum())
                               .OrderByDescending(x => x)
                               .Take(3)
                               .Sum();
    }

    private static IEnumerable<IEnumerable<int>> GetGroups(string input)
    {
        return input.Split("\n\n")
                    .Select(c => c.Split('\n').Select(int.Parse));
    }
}
