using W9_assignment_template.Models;

public abstract class Character : ICharacter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }


    public int RoomId { get; set; }

    public virtual Room Room { get; set; }

    
    public virtual ICollection<Ability> Abilities { get; set; }

    public virtual void Attack(ICharacter target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}!");
    }
}

public abstract class Ability
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

   
    public virtual ICollection<Character> Characters { get; set; }
}