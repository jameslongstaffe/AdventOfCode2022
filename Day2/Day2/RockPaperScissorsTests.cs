
using NUnit.Framework;

namespace Day2;

internal class RockPaperScissorsTests
{
    [Test]
    public void Test_Part1()
    {
        Assert.That(RockPaperScissors.Part1_GetScore(), Is.EqualTo(9241));
    }

    [Test]
    public void Test_Part2()
    {
        Assert.That(RockPaperScissors.Part2_GetScore(), Is.EqualTo(14610));
    }
}
