namespace Kata1;

public class GameLoop
{
    public void Loop(List<Character> characterList, Character healer)
    {
        var orderedList = characterList.OrderBy(character => character.Health);
        
        foreach (var characters in orderedList)
        {
            Console.WriteLine($"{characters.Name} has {characters.Health}hp");
            characters.PrimaryAction();
        }
        
        Console.WriteLine();

        Console.WriteLine("healer will heal the warrior with the least amount of hp first");
        foreach (var character in orderedList)
        {
            Console.WriteLine($"{healer.Name} healed {character.Name}.{character.Name} has {character.Health} hp");
            healer.PrimaryAction();
        }
    }
}