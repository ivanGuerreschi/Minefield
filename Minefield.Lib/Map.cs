namespace Minefield.Lib;

public class Map
{
    private const int Dimension = 10;

    private const string CharMap = "*";

    private List<List<string>> _map = new();

    public List<List<string>> Build(Arrive arrive)
    {
        _map = Enumerable.Range(0, Dimension)
            .Select(row => Enumerable.Range(0, Dimension)
                .Select(col => (CharMap))
                .ToList())
            .ToList();
        
        _map[arrive.YArrive][arrive.XArrive] = arrive.CharArrive;
        
        return _map;
    }

    public void Print(List<List<String>> map, Hero hero)
    {
        Console.Clear();
        Console.WriteLine("Vim command to move(hjkl) and exit(q)");

        map[hero.YHero][hero.XHero] = hero.CharHero;
        
        map.ForEach(row =>
        {
            var rowString = string.Join(" ", row);
            Console.WriteLine(rowString);
        });
        
        map[hero.YHero][hero.XHero] = CharMap;

    }
}