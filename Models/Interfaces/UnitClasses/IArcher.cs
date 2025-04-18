﻿using w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;

namespace w10_assignment_ksteph.Models.Interfaces.UnitClasses;

public interface IArcher : IShootable
{
    // An Archer unit that is able to shoot.
    public void Attack(IUnit target) => Shoot(target);
}
