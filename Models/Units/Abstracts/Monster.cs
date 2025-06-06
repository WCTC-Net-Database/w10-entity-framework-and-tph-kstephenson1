﻿using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Inventories;

namespace w10_assignment_ksteph.Models.Units.Abstracts;

public abstract class Monster : Unit
{
    // The Monster class is, for the most part, an abstract(ish) class that might contain some computer intelligence functions one day.
    public Monster() { }

    public Monster(string name, string characterClass, int level, int hitPoints, Inventory inventory, Stat stats)
    {

    }
}
