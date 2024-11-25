namespace Kata3;

class FireBall : IAbility
{
    private readonly string _name = "FireBall";
    private readonly string _effect = "Creates a big fire ball";

    public string Name
    {
        get { return _name; }
    }

    public string Effect
    {
        get { return _effect; }
    }
}