using Deedforge.Domain.CoreRules.Attacking;
using Deedforge.Domain.CoreRules.Statuses;
using Deedforge.Domain.Gear;

namespace Deedforge.Shared.Compendium
{
    public class CompendiumData
    {
        public List<Status> Boons { get; set; } = new List<Status>();
        public List<Status> Conditions { get; set; } = new List<Status>();
        public List<Armor> Armors { get; set; } = new List<Armor>();
        public List<Shield> Shields { get; set; } = new List<Shield>();
        public List<AttackForm> MeleeAttacks { get; set; } = new List<AttackForm>();
        public List<AttackForm> RangedAttacks { get; set; } = new List<AttackForm>();
        public List<AttackForm> SpellAttacks { get; set; } = new List<AttackForm>();
    }
}
