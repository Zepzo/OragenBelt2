namespace Kata3;

class IceBall : IAbility
{
    private readonly string _name = "IceBall";
    private readonly string _effect = "Creates a big ice ball";

    public string Name
    {
        get { return _name; }
    }

    public string Effect
    {
        get { return _effect; }
    }
}