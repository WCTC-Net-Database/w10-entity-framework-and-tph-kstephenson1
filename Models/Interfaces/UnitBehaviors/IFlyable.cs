using w10_assignment_ksteph.Models.Commands.Invokers;
using w10_assignment_ksteph.Models.Commands.UnitCommands;
namespace w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;

public interface IFlyable
{
    // Interface tha allows units to fly.
    CommandInvoker Invoker { set; get; }
    FlyCommand FlyCommand { set; get; }
    void Fly();
}
