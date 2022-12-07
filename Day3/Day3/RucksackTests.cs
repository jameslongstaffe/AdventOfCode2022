
using NUnit.Framework;

namespace Day3;

internal class RucksackTests
{
    [Test]
    public void Test_Part1()
    {
        Assert.That(Rucksack.Part1_GetSum(), Is.EqualTo(8298));
    }

    [Test]
    public void Test_Part2()
    {
        Assert.That(Rucksack.Part2_GetSum(), Is.EqualTo(2708));
    }
}
