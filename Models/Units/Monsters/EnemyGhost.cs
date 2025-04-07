using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Inventories;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Units.Monsters;

public class EnemyGhost : Monster
{
    public override string UnitType { get; set; } = "EnemyGhost";
    public EnemyGhost()
    {

    }

    public EnemyGhost(string name, string characterClass, int level, int hitPoints, Inventory inventory, Stat stats)
    {

    }
}
