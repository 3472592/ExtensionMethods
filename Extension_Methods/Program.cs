namespace Extension_Methods;

public class Program 
{
    private static void Main(string[] args)
     {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        OrdinaryHuman steve = new(185);
        Console.WriteLine(steve.BreakWalls(89.2));
    }

}
public sealed class OrdinaryHuman
{
    private readonly int age = 18;
    private readonly int weight = 55;

    public OrdinaryHuman (int weight)
    {
        this.weight = weight;
    }
    public void GoToWork()
    {
        Console.WriteLine(" Going to work...");
    }

    public void PayBills()
    {
        Console.WriteLine("Paying bills...");
    }

}

public static class SuperSoldierSerum
{
    public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
    {
        if (h is null)
        {
            throw new ArgumentNullException(nameof(h));
        }

        return ("I broke through a wall of " + wallDensity + " density.");
    }
}