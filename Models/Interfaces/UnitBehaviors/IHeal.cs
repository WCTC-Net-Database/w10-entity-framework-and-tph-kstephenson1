﻿using w10_assignment_ksteph.Models.Commands.Invokers;
using w10_assignment_ksteph.Models.Commands.UnitCommands;

namespace w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;

public interface IHeal
{
    // Interface tha allows units to heal.
    CommandInvoker Invoker { set; get; }
    HealCommand HealCommand { set; get; }

    void Heal(IUnit target);
}
