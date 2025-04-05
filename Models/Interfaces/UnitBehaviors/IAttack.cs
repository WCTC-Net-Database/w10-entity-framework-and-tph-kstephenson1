using w10_assignment_ksteph.Models.Commands.Invokers;
using w10_assignment_ksteph.Models.Commands.ItemCommands;
using w10_assignment_ksteph.Models.Commands.UnitCommands;
using w10_assignment_ksteph.Models.Interfaces.ItemBehaviors;

namespace w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;

public interface IAttack
{
    // Interface tha allows units to attack.
    CommandInvoker Invoker { set; get; }
    AttackCommand AttackCommand { set; get; }
    EquipCommand EquipCommand { set; get; }

    void Attack(IUnit target);
    void Equip(IEquippableItem item);
}
