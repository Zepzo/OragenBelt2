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

        var healer = new Character("Healer", 10, () => Console.WriteLine($"Healing"));
        
        List<Character> characterList = new() {warrior0,warrior1, warrior2, warrior3, warrior4};

        var gameLoop = new GameLoop();
        gameLoop.Loop(characterList, healer);
    }
}