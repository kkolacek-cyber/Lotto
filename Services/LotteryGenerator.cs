namespace LotteryApp.Services;

public static class LotteryGenerator
{
    private static readonly Random _random = new();

    public static List<int> GenerateNumbers(int count, int min, int max)
    {
        if (count > max - min + 1)
            throw new ArgumentException("Traženo je više brojeva nego što ih ima u rasponu.");

        var numbers = new HashSet<int>();

        while (numbers.Count < count)
        {
            numbers.Add(_random.Next(min, max + 1));
        }

        return numbers.OrderBy(n => n).ToList();
    }
}