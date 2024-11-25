namespace Kata3;

class IceBall : IAbility
{
    private string _name = "IceBall";
    private string _effect = "Creates a big ice ball";

    public string Name
    {
        get { return _name; }
    }

    public string Effect
    {
        get { return _effect; }
    }
}