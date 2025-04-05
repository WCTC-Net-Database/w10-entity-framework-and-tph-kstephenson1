using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Inventories;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Units.Characters;

public class Rogue : Character
{
    public override string UnitType { get; set; } = "Rogue";

    public Rogue()
    {

    }

    public Rogue(string name, string characterClass, int level, int hitPoints, Inventory inventory, Stat stats)
    {

    }
}
