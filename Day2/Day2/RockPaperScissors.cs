
#pragma warning disable CS8524
#pragma warning disable CS8846

using static Day2.RockPaperScissors.Hand;
using static Day2.RockPaperScissors.Result;

namespace Day2;
public static class RockPaperScissors
{
    public static int Part1_GetScore()
    {
        return GetHands().Sum(h => ((int) GetMatchResult(h)) * 3
                                 + ((int) h.player) + 1);
    }

    public static int Part2_GetScore()
    {
        return GetHandAndResults()
              .Sum(h => ((int) h.result * 3)
                      + ((int) GetHandForResult(h.opponent, h.result)) + 1);
    }

    private static Result GetMatchResult((Hand opponent, Hand player) hands)
    {
        return hands switch
        {
            var (opponent, player) when opponent == player => Draw,

            (Rock, Paper)     => Win,
            (Rock, Scissors)  => Lose,

            (Paper, Rock)     => Lose,
            (Paper, Scissors) => Win,

            (Scissors, Rock)  => Win,
            (Scissors, Paper) => Lose
        };
    }

    private static Hand GetHandForResult(Hand opponent, Result result)
    {

        return opponent switch
        {
            Rock => result switch
            {
                Lose => Scissors,
                Draw => Rock,
                Win => Paper
            },

            Paper => result switch
            {
                Lose => Rock,
                Draw => Paper,
                Win => Scissors
            },

            Scissors => result switch
            {
                Lose => Paper,
                Draw => Scissors,
                Win => Rock
            }
        };
    }

    private static IEnumerable<(Hand opponent, Hand player)> GetHands()
    {
        return File.ReadAllLines("input.txt")
                   .Select(l => ((Hand) (l[0] - 'A'), (Hand) (l[2] - 'X')));
    }

    private static IEnumerable<(Hand opponent, Result result)> GetHandAndResults()
    {
        return File.ReadAllLines("input.txt")
                   .Select(l => ((Hand) (l[0] - 'A'), (Result) (l[2] - 'X')));
    }

    public enum Hand { Rock, Paper, Scissors }

    public enum Result { Lose, Draw, Win }
}
