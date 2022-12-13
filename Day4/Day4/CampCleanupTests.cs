
using NUnit.Framework;

namespace Day4;

internal class CampCleanupTests
{
    [Test]
    public void Test_Part1()
    {
        Assert.That(CampCleanup.Part1(), Is.EqualTo(571));
    }

    [Test]
    public void Test_Part2()
    {
        Assert.That(CampCleanup.Part2(), Is.EqualTo(917));
    }
}
