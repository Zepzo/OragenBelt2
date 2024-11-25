namespace Kata2;

public class Character
{
    private string _name;
    private int _health;

    private Combat combat = new();
    
    public Character(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public string Name
    {
        get { return _name; }
    }

    public int Health
    {
        get { return _health; }
    }

    public delegate void CharacterAction(Character target, int amount);

    public delegate void Test();

    public event Action<Character> HealthChanged;
    
    public void Attack(Character target, int amount)
    {
        Console.WriteLine($"{_name} attacks {target._name} for {amount} damage");

        target._health -= amount;
        
        combat.OnHealthChange(target);
    }
}