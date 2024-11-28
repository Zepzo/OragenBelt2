namespace Kata1;

public class GameLoop
{
    public void Loop(List<Character> characterList, Character healer)
    {
        var orderedList = characterList.OrderBy(character => character.Health);

        int count = 0;
        
        foreach (var characters in orderedList)
        {
            if (count == 0)
            {
                Console.WriteLine();

                Console.WriteLine("healer will heal the warrior with the least amount of hp");
                
                Console.WriteLine($"{healer.Name} healed {characters.Name}. {characters.Name} has {characters.Health} hp");
                healer.PrimaryAction();
                
                Console.WriteLine();
                count++;
            }
            
            Console.WriteLine($"{characters.Name} has {characters.Health}hp");
            characters.PrimaryAction();
        }
    }
}