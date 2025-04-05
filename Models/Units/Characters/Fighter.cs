using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Inventories;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Units.Characters;

public class Fighter : Character
{
    public override string UnitType { get; set; } = "Fighter";

    public Fighter()
    {

    }
    public Fighter(string name, string characterClass, int level, Inventory inventory, Stat stats)
    {
        Name = name;
        Class = characterClass;
        Level = level;
        Inventory = inventory;
        Stat = stats;
        Inventory.Unit = this;
    }
}
