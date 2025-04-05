using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Abilities;

public class Ability
{
    public int AbilityId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual List<Unit> Units { get; set; }
    public Ability()
    {
        
    }
    public Ability(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Execute()
    {

    }
}
