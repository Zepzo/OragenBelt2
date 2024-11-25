namespace Kata3;

class Program
{
    static void Main(string[] args)
    {
        var fireBall = new FireBall();
        var iceBall = new IceBall();
        var abilityContainer = new AbilityContainer<string>();
        
        Console.WriteLine("Adding abilities to the container...");
        abilityContainer.AddAbility(fireBall.Name+":"+" "+fireBall.Effect, fireBall.Name, fireBall.Effect);
        abilityContainer.AddAbility(iceBall.Name+":"+" "+iceBall.Effect, iceBall.Name, iceBall.Effect);
        
        Console.WriteLine();
        
        Console.WriteLine("Listing all abilities in the container:");
        abilityContainer.ShowAbility();
        
        Console.WriteLine();
        
        Console.WriteLine("Removing ability from the container...");
        abilityContainer.RemoveAbility(iceBall.Name+":"+" "+iceBall.Effect, iceBall.Name, iceBall.Effect);

        Console.WriteLine();
        
        Console.WriteLine("Listing all abilities in the container:");
        abilityContainer.ShowAbility();
    }
}