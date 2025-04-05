using w10_assignment_ksteph.Models.Commands.Invokers;
using w10_assignment_ksteph.Models.Commands.ItemCommands;

namespace w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;

public interface IUseItems
{
    // Interface tha allows units to hold items.
    CommandInvoker Invoker { get; set; }
    UseItemCommand UseItemCommand { get; set; }
    void UseItem(IItem item);
}
