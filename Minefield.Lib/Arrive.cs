namespace Minefield.Lib;

public class Arrive
{
    public string CharArrive { get; set; } 
    public int XArrive { get; set; }
    public int YArrive { get; set; }

    public Arrive()
    {
        CharArrive = "P";
        var random = new Random();
        XArrive = random.Next(8) + 1;
        YArrive = random.Next(9);
    }
}