﻿using w10_assignment_ksteph.Models.Interfaces;
using w10_assignment_ksteph.Models.Interfaces.Commands;
using w10_assignment_ksteph.Models.Interfaces.InventoryBehaviors;

namespace w10_assignment_ksteph.Models.Commands.ItemCommands;

public class TradeItemCommand : ICommand
{
    // A generic attack command.  It takes in an attacking unit and a target, creates a new encounter object, and calculates whether or
    // not the unit hit/crit and calculates damage.  If the unit cannot attack, a message is provided to the user.

    private readonly IUnit _unit;
    private readonly IItem _item;
    private readonly IUnit _target;
    public TradeItemCommand(IUnit unit, IItem item, IUnit target)
    {
        _unit = unit;
        _item = item;
        _target = target;
    }
    public void Execute()
    {
        if (_unit is IHaveInventory && _target is IHaveInventory)
        {
            if (!_target.Inventory.IsFull())
            {
                _unit.Inventory.RemoveItem(_item);
                _target.Inventory.AddItem(_item);
                Console.WriteLine($"{_unit.Name} traded {_item.Name} to {_target.Name}");
            }
            else
            {
                Console.WriteLine($"{_unit.Name} cound not trade {_item.Name} to {_target.Name}.");
                Console.WriteLine($"{_target.Name}'s inventory is full.");
            }
        }
    }
}
