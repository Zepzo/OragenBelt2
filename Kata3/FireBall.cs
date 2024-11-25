namespace Kata3;

class FireBall : IAbility
{
    private string _name = "FireBall";
    private string _effect = "Creates a big fire ball";

    public string Name
    {
        get { return _name; }
    }

    public string Effect
    {
        get { return _effect; }
    }
}