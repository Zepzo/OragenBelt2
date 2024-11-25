namespace Kata2;

public class Combat
{
    public void Game()
    {
        var Red = new Character("Red", 100);
        var Blue = new Character("Blue", 120);

        Character.CharacterAction redAttack = Red.Attack;
        Character.CharacterAction blueAttack = Blue.Attack;

        redAttack(Blue, 10);
        blueAttack(Red, 8);
    }
}