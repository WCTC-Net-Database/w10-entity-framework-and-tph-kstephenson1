﻿using w10_assignment_ksteph.Models.Interfaces.ItemBehaviors;
using w10_assignment_ksteph.Services.DataHelpers;

namespace w10_assignment_ksteph.Models.Items.ConsumableItems;

public class ItemLockpick : ConsumableItem, IConsumableItem
{
    public override string ItemType { get; set; } = "ItemLockpick";

    public ItemLockpick()
    {
        Name = "Lockpick";
        Description = "Use to unlock a nearby door or chest.";
        MaxUses = 5;
        UsesLeft = MaxUses;
    }

    public ItemLockpick(string name, string desc) : base(name, desc)
    {
        MaxUses = 5;
        UsesLeft = MaxUses;
    }

    public void UseItem()
    {
        Console.WriteLine($"{Inventory.Unit!.Name} unlocked something!");
        UsesLeft--;

        if (UsesLeft == 0)
        {
            Console.WriteLine($"The lockpick broke!");
            Inventory.RemoveItem(this);
        }
    }
    public override string ToString()
    {
        return $"{Name} ({UsesLeft}/{MaxUses})";
    }
}
