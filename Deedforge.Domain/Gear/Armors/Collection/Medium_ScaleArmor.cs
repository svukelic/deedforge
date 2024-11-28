using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Medium_ScaleArmor = new Armor
        {
            Name = "Scale Armor",
            Description = "A set of armor made from interlocking metal or bestial scales, providing good protection against ranged attacks.",
            ArmorType = ArmorType.Medium,
            Endurance = 7,
            NumberOfReactions = 2,
            SuccessActions = new SuccessAction
            {
                Name = "Scale Lock",
                Description = "You lock your armor's scales in place for enhanced protection.",
                Skills = SetterHelper<Skill>.Set(Skills.Defense),
                ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                Range = 0,
                Tier1 = "Gain +2 Grit until the start of your next turn, but you also become Staggered.",
                Tier2 = "Gain +2 Grit until the start of your next turn.",
                Tier3 = "Gain +4 Grit until the start of your next turn.",
                Tier4 = "Gain +4 Grit until the start of your next turn and become Unyielding."
            }
        };
    }
}
