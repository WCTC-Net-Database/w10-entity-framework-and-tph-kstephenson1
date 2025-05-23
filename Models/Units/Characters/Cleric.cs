﻿using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Commands.UnitCommands;
using w10_assignment_ksteph.Models.Interfaces.UnitClasses;
using w10_assignment_ksteph.Models.Inventories;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Units.Characters;

public class Cleric : Character, ICleric
{
    public override string UnitType { get; set; } = "Cleric";

    public Cleric()
    {
        
    }
    public Cleric(string name, string characterClass, int level, Inventory inventory, Stat stats)
    {
        Name = name;
        Class = characterClass;
        Level = level;
        Inventory = inventory;
        Stat = stats;
        Inventory.Unit = this;
    }

    [Ignore]
    [JsonIgnore]
    [NotMapped]
    public virtual CastCommand CastCommand { get; set; } = null!;

    public void Cast(string spellName)
    {
        CastCommand = new(this, spellName);
        Invoker.ExecuteCommand(CastCommand);
    }
}
