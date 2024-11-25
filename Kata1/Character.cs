public class Character
{
    private string _name;
    private int _health;
    private Action _primaryAction;
    
    public Character(string name, int health, Action primaryAction)
    {
        _name = name;
        _health = health;
        _primaryAction = primaryAction;
    }

    public string Name
    {
        get { return _name; }
    }

    public int Health
    {
        get { return _health; }
    }

    public Action PrimaryAction
    {
        get { return _primaryAction; }
    }
}