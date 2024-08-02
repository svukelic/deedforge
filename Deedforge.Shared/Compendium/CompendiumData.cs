using Deedforge.Domain.CoreRules.Attacking;
using Deedforge.Domain.Gear;

namespace Deedforge.Shared.Compendium
{
    public class CompendiumData
    {
        public List<Armor> Armors { get; set; } = new List<Armor>();
        public List<Shield> Shields { get; set; } = new List<Shield>();
        public List<AttackForm> MeleeAttacks { get; set; } = new List<AttackForm>();
        public List<AttackForm> RangedAttacks { get; set; } = new List<AttackForm>();
        public List<AttackForm> SpellAttacks { get; set; } = new List<AttackForm>();
    }
}
