
namespace Day3;

public static class Rucksack
{
    public static int Part1_GetSum()
    {
        static char GetWrongItem(string s) =>
            s[..(s.Length / 2)].Intersect(s[(s.Length / 2)..]).Single();

        return File.ReadAllLines("input.txt")
                   .Select(GetWrongItem)
                   .Sum(GetPriority);
    }

    public static int Part2_GetSum()
    {
        static char GetCommonItem(string[] s)
        {
            return s[1..].Aggregate(s[0].ToCharArray().AsEnumerable(),
                                    (result, x) => result.Intersect(x.ToCharArray()))
                         .Single();
        }

        return File.ReadAllLines("input.txt")
                   .Chunk(3)
                   .Select(GetCommonItem)
                   .Sum(GetPriority);
    }

    private static int GetPriority(char c) =>
        char.IsLower(c) ? c - 'a' + 1 : c - 'A' + 27;
}
