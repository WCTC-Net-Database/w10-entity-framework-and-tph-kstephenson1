using w10_assignment_ksteph.Models.Commands.Invokers;
using w10_assignment_ksteph.Models.Commands.UnitCommands;

namespace w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;

public interface IShootable
{
    // Interface tha allows units to shoot.
    CommandInvoker Invoker { set; get; }
    ShootCommand ShootCommand { set; get; }
    void Shoot(IUnit target);
}
