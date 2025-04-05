using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using CsvHelper.Configuration.Attributes;
using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Commands.UnitCommands;
using w10_assignment_ksteph.Models.Interfaces.UnitBehaviors;
using w10_assignment_ksteph.Models.Inventories;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Units.Monsters;

public class EnemyGhost : Monster, IFlyable
{
    public override string UnitType { get; set; } = "EnemyGhost";
    public EnemyGhost()
    {

    }

    public EnemyGhost(string name, string characterClass, int level, int hitPoints, Inventory inventory, Stat stats)
    {

    }

    [Ignore]
    [JsonIgnore]
    [NotMapped]
    public virtual FlyCommand FlyCommand { get ; set ; } = null!;

    public void Fly()
    {
        FlyCommand = new(this);
        Invoker.ExecuteCommand(FlyCommand);
    }

    public override void Move() => Fly();

}
