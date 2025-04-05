using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using CsvHelper.Configuration.Attributes;
using w10_assignment_ksteph.Models.Combat;
using w10_assignment_ksteph.Models.Commands.UnitCommands;
using w10_assignment_ksteph.Models.Interfaces;
using w10_assignment_ksteph.Models.Interfaces.UnitClasses;
using w10_assignment_ksteph.Models.Inventories;
using w10_assignment_ksteph.Models.Units.Abstracts;

namespace w10_assignment_ksteph.Models.Units.Monsters;

public class EnemyArcher : Monster, IArcher
{
    public override string UnitType { get; set; } = "EnemyArcher";

    public EnemyArcher()
    {

    }

    public EnemyArcher(string name, string characterClass, int level, int hitPoints, Inventory inventory, Stat stats)
    {

    }

    [Ignore]
    [JsonIgnore]
    [NotMapped]
    public virtual ShootCommand ShootCommand { get; set; }

    public void Shoot(IUnit target)
    {
        ShootCommand = new(this, target);
        Invoker.ExecuteCommand(ShootCommand);
    }

    public override void Attack(IUnit target) => Shoot(target);
}
