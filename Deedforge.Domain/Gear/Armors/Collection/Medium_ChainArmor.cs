using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Medium_ChainArmor = new Armor
        {
            Name = "Chain Armor",
            Description = "A set of armor made from interlocking metal rings, providing good protection without sacrificing mobility.",
            ArmorType = ArmorType.Medium,
            Endurance = 7,
            NumberOfReactions = 2,
            SuccessActions = new SuccessAction
            {
                Name = "Sidestep",
                Description = "You sidestep upon being hit by a melee attack, and potentially reducing taken damage.",
                Skills = SetterHelper<Skill>.Set(Skills.Defense),
                ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                Range = 0,
                Tier1 = "You move 1 hex, but you become Distracted.",
                Tier2 = "You move 1 hex.",
                Tier3 = "You move 1 hex, and you reduce the damage taken from the triggering attack by 1.",
                Tier4 = "You move 1 hex, and you reduce the damage taken from the triggering attack by 2.",
            }
        };
    }
}
