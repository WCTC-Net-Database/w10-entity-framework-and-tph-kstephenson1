using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using CsvHelper.Configuration.Attributes;
using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Commands.UnitCommands;
using w10_assignment_ksteph.Models.Interfaces.UnitClasses;
using w10_assignment_ksteph.Models.Inventories;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Units.Monsters;

public class EnemyMage : Monster, IMage
{
    public override string UnitType { get; set; } = "EnemyMage";
    public EnemyMage()
    {

    }

    public EnemyMage(string name, string characterClass, int level, int hitPoints, Inventory inventory, Stat stats)
    {

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
