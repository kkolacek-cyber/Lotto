namespace LotteryApp.Services;

public static class LotteryGenerator
{
    private static readonly Random _random = new();

    public static List<int> GenerateNumbers(int count, int min, int max)
    {

        var numbers = new HashSet<int>();

        while (numbers.Count < count)
        {
            numbers.Add(_random.Next(min, max + 1));
        }

        return numbers.OrderBy(n => n).ToList();
    }
}