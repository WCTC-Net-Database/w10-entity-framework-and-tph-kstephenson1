﻿using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Abilities;

public class HealAbility : Ability
{
    public override string AbilityType { get; set; } = "HealAbility";

    public HealAbility()
    {
        Name = "Heal";
        Description = "Heals a friendly unit.";
    }
    public override void Execute(Unit unit, Unit target)
    {
        if(CanUseAbility(unit))
        {
            Encounter encounter = new(unit, target);
            if (encounter.IsCrit())
            {
                Console.WriteLine($"{unit.Name} critically heals {target.Name} for {encounter.Damage} hit points!");
                target.Damage(encounter.Damage * -1);
            }
            else if (encounter.IsHit())
            {
                Console.WriteLine($"{unit.Name} heals {target.Name} for {encounter.Damage} hit points.");
                target.Damage(encounter.Damage * -1);
            }
            else
            {
                Console.WriteLine($"{unit.Name}'s misses {target.Name}");
            }
        }
        else
        {
            Console.WriteLine($"{unit} does not have the ability to heal.");
        }
    }
}
