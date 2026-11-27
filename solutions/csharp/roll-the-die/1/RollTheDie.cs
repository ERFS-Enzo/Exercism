using static System.Random;
public class Player
{
    public int RollDie()
    {
        return Random.Shared.Next(1, 19);
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        return Random.Shared.NextDouble() * 100;
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
