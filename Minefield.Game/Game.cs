using Minefield.Lib;

namespace Minefield.Game;

public class Game
{
    public void Run()
    {
        var map = new Map();
        var hero = new Hero();
        var arrive = new Arrive();
        var random = new Random();
        var mine = new List<Mine>();

        for (var i = 0; i < 5; i++)
        {
            mine.Add(new((random.Next(10)), random.Next(10)));
        }

        var newMap = map.Build(arrive);
        map.Print(newMap, hero);
        
        var loop = true;

        while (loop)
        {
            switch (Console.ReadLine()?.ToLower())
            {
                case "q":
                    loop = false;
                    break;
                
                case "l":
                    hero.XHero += 1;
                    if (hero.XHero > 9)
                    {
                        hero.XHero = 9;
                    }
                    map.Print(newMap, hero);
                    break;
                
                case "h":
                    hero.XHero += -1;
                    if (hero.XHero < 0)
                    {
                        hero.XHero = 0;
                    }
                    map.Print(newMap, hero);
                    break;
                
                case "k":
                    hero.YHero += 1;
                    if (hero.YHero > 9)
                    {
                        hero.YHero = 9;
                    }
                    map.Print(newMap, hero);
                    break;
                
                case "j":
                    hero.YHero += -1;
                    if (hero.YHero < 0)
                    {
                        hero.YHero = 0;
                    }
                    map.Print(newMap, hero);
                    break;
            }
            
            if (hero.XHero == arrive.XArrive && hero.YHero == arrive.YArrive)
            {
                Console.WriteLine("Win!!");
                loop = false;
            }
            
            foreach (var mina in mine)
            {
                if (hero.XHero == mina.XMine && hero.YHero == mina.YMine)
                {
                    hero.CharHero = "X";
                    map.Print(newMap, hero);
                    Console.WriteLine("Game Over!!");
                    loop = false;
                }
            }
        }
    }
}
