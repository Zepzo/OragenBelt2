namespace Kata1;

public class StartGame
{
    public void Instanciate()
    {
        var warrior0 = new Character("Warrior", 30, () => Console.WriteLine($"Attacking"));
        var warrior1 = new Character("Warrior", 60, () => Console.WriteLine($"Attacking"));
        var warrior2 = new Character("Warrior", 60, () => Console.WriteLine($"Attacking"));
        var warrior3 = new Character("Warrior", 80, () => Console.WriteLine($"Attacking"));
        var warrior4 = new Character("Warrior", 30, () => Console.WriteLine($"Attacking"));

        var healer4 = new Character("Healer", 50, () => Console.WriteLine($"Healing"));
        var healer0 = new Character("Healer", 10, () => Console.WriteLine($"Healing"));
        var healer1 = new Character("Healer", 80, () => Console.WriteLine($"Healing"));
        var healer2 = new Character("Healer", 40, () => Console.WriteLine($"Healing"));
        var healer3 = new Character("Healer", 70, () => Console.WriteLine($"Healing"));
        
        List<Character> characterList = new() {warrior0,warrior1, warrior2, warrior3, warrior4, healer0, healer1, healer2, healer3, healer4};

        var gameLoop = new GameLoop();
        gameLoop.Loop(characterList);
    }
}