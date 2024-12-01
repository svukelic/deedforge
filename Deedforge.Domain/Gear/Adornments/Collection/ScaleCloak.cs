using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment ScaleCloak = new Adornment
        {
            Name = "Scale Cloak",
            Description = "A cloak made from resilient scales, providing protection from area attacks.",
            AdornmentType = AdornmentType.Cloak,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Scale Ward",
                    Description = "You envelope yourself in a protective barrier of scales, deflecting the damage of an area attack.",
                    Skills = SetterHelper<Skill>.Set(Skills.Defense, Skills.Acrobatics, Skills.Arcana, Skills.Occultism),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                    Range = 0,
                    ChallengeModifier = Constants.ChallengeModifier_Difficulty,
                    Tier1 = "You reduce the damage taken from the deflected attack by 2, but you also become Slowed until the end of your next turn.",
                    Tier2 = "You reduce the damage taken from the deflected attack by 2.",
                    Tier3 = "You reduce the damage taken by 4.",
                    Tier4 = "You reduce the damage taken by 8."
                },
            }
        };
    }
}
