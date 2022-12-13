
using NUnit.Framework;

namespace Day4;

internal class RucksackTests
{
    [Test]
    public void Test_Part1()
    {
        Assert.That(Rucksack.Part1(), Is.EqualTo(571));
    }

    [Test]
    public void Test_Part2()
    {
        Assert.That(Rucksack.Part2(), Is.EqualTo(917));
    }
}
