using Deedforge.Domain.CoreRules.Attacking;
using Deedforge.Domain.Gear;

namespace Deedforge.Shared.Compendium
{
    public class CompendiumData
    {
        public List<Armor> Armors { get; set; } = new List<Armor>();
        public List<Shield> Shields { get; set; } = new List<Shield>();
        public MeleeAttacksSheets MeleeAttackSheets { get; set; } = new MeleeAttacksSheets();
    }
}
