using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Light_Unarmored = new Armor
        {
            Name = "Unarmored",
            Description = "A set of furs and clothes, letting you display your muscles. The Base Endurance of this 'armor' is equal to 3 + your Health Proficiency Tier.",
            Endurance = 3,
            NumberOfReactions = 3,
            SuccessActions = new SuccessAction
            {
                Name = "Rage",
                Description = "You enter a state of primal fury, gaining increased strength and resistance.",
                Skills = SkillHelpers.SetSkills(Skills.Health),
                ActionTypes = new List<ActionType> { ActionType.Reaction },
                Tier1 = "You reduce the damage taken from the triggering attack by 1, and can Retaliate against the triggering enemy, but you also trigger a Retaliation.",
                Tier2 = "You reduce the damage taken from the triggering attack by 1, and can Retaliate against the triggering enemy.",
                Tier3 = "You reduce the damage taken from the triggering attack by 2, and can Retaliate against the triggering enemy.",
                Tier4 = "You reduce the damage taken from the triggering attack by 3, and can Retaliate against the triggering enemy."
            }
        };
    }
}
