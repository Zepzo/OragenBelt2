namespace LamdaExercise;

class Program
{
    static void Main(string[] args)
    {
        var caracter = new Character();
        var random = new Random();

        int attackChance = 5;

        List<string> enemies = new() { "enemy", "enemy", "enemy" };
        
        caracter.SpecialAttack(enemies, () => attackChance < random.Next(0,11));
        
    }
}

class Character
{
    public void SpecialAttack(List<string> enemies, Func<bool> canAttack)
    {
        foreach (var enemyList in enemies)
        {
            if (canAttack())
            {
                Console.WriteLine($"Special attack on {enemyList}");
            }
        }
    }
}