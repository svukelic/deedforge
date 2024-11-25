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
            Endurance = 7,
            NumberOfReactions = 2,
            SuccessActions = new SuccessAction
            {
                Name = "Scale Lock",
                Description = "You lock your armor's scales in place for enhanced protection.",
                Skills = SkillHelpers.SetSkills(Skills.Defense),
                ActionTypes = new List<ActionType> { ActionType.Action },
                Tier1 = "Until the start of your next turn, gain +2 Grit, but you also become Staggered.",
                Tier2 = "Until the start of your next turn, gain +2 Grit.",
                Tier3 = "Until the start of your next turn, gain +4 Grit.",
                Tier4 = "Until the start of your next turn, gain +4 Grit and become Unyielding."
            }
        };
    }
}
