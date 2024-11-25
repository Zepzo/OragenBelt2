namespace Kata1;

public class GameLoop
{
    public void Loop(List<Character> characterList)
    {
        foreach (var characters in characterList)
        {
            if (characters.Health <= 50)
            {
                Console.WriteLine($"{characters.Name} has {characters.Health}hp");
                characters.PrimaryAction();
            }
        }
        
        foreach (var characters in characterList)
        {
            if (characters.Health > 50)
            {
                Console.WriteLine($"{characters.Name} has {characters.Health}hp");
                characters.PrimaryAction();
            }
        }
    }
}