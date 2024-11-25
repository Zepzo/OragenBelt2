namespace Kata2;

public class Combat
{
    public void Game()
    {
        var red = new Character("Red", 100);
        var blue = new Character("Blue", 120);

        Character.CharacterAction redAttack = red.Attack;
        Character.CharacterAction blueAttack = blue.Attack;
        
        red.HealthChanged += OnHealthChange;
        blue.HealthChanged += OnHealthChange;

        redAttack(blue, 10);
        blueAttack(red, 8);
    }
    
    public void OnHealthChange(Character target)
    {
        Console.WriteLine($"[Event] {target.Name}'s health changed to {target.Health}.");
    }
}