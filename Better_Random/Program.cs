// This is challenge work for the "C# Players Guide"
// Level 34  "Better Random" Challenge
//This is a challenge to exend the Random Method

Random ExtRandom = new Random();

//Changes Max Double from 0 to 1 to a multiple of the value passed in
Console.WriteLine(ExtRandom.NextDouble(10));

//Pulls random string (Contra Cheat Code)
Console.WriteLine(ExtRandom.NextString("Up,Up", "Down, Down", "Left, Right", "AB", "Select", "Start"));

//50% chance for heads
bool CoinTossBaseLine = ExtRandom.CoinFlip();
if (CoinTossBaseLine == true) Console.WriteLine($"The baseline coin toss returned {CoinTossBaseLine}: Heads");
else Console.WriteLine($"The baseline coin toss returned {CoinTossBaseLine}: Tails");

// 75% chance for heads
bool CoinTossHeadsCheat = ExtRandom.CoinFlip(.75);
if (CoinTossHeadsCheat == true) Console.WriteLine($"The heads cheat coin toss returned {CoinTossHeadsCheat}: Heads");
else Console.WriteLine($"The heads cheat coin toss returned {CoinTossHeadsCheat}: Tails");

public static class RandomExtensions
{
    public static double NextDouble (this Random ExtRandom, double MaxValue)
    {
        return ExtRandom.NextDouble() * MaxValue;
    }

    public static string NextString (this Random ExtRandom, params string[] RndWord)
    {
        return RndWord[ExtRandom.Next(RndWord.Length)];
    }
    public static bool CoinFlip(this Random ExtRandom, double LuckForHeads = 0.5)
    {
        double CoinResults = ExtRandom.NextDouble() - LuckForHeads;
        if (CoinResults < 0) return true;
        else return false;
    }
}
