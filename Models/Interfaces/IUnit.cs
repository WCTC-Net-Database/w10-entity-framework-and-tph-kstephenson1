using w10_assignment_ksteph.Models.Abilities;
using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Commands.AbilityCommands;
using w10_assignment_ksteph.Models.Commands.UnitCommands;
using w10_assignment_ksteph.Models.Interfaces.InventoryBehaviors;
using w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;
using w10_assignment_ksteph.Models.Rooms;

namespace w10_assignment_ksteph.Models.Interfaces;

public interface IUnit : ITargetable, IAttack, IHaveInventory, IUseItems
{
    // Interface tha allows units to exist.
    public int UnitId { get; set; }
    MoveCommand MoveCommand { set; get; }
    AbilityCommand AbilityCommand { set; get; }
    public string Name { get; set; }
    public string Class { get; set; }
    public int Level { get; set; }
    Room? CurrentRoom { get; set; }
    public Stat Stat { get; set; }
    public List<Ability> Abilities { get; }

    void Move();
    string GetHealthBar();
}
