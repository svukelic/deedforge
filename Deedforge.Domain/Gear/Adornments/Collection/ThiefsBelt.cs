using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment ThiefsBelt = new Adornment
        {
            Name = "Thief's Belt",
            Description = "A belt containing a variety of tools and implements useful for a thief.",
            AdornmentType = AdornmentType.Belt,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Bypass Security",
                    Description = "You bypass a mechanism, such as a lock or trap.",
                    Skills = SetterHelper<Skill>.Set(Skills.Subterfuge),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                    Range = 0,
                    ChallengeModifier = Constants.ChallengeModifier_Difficulty,
                    Tier1 = "You temporarily disable a trap or lock, but you also cause a significant amount of noise while doing so.",
                    Tier2 = "You temporarily disable a trap or lock.",
                    Tier3 = "You permanently disable a trap or lock.",
                    Tier4 = "You permanently disable a trap or lock, and gain a single use of the disabled trap or lock."
                },
            }
        };
    }
}
