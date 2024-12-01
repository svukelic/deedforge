using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment ExoticCloak = new Adornment
        {
            Name = "Exotic Cloak",
            Description = "A flamboyant cloak adorned with vibrant feathers, shimmering patterns, and eye-catching embellishments designed to command attention and make a striking visual impact.",
            AdornmentType = AdornmentType.Cloak,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Distracting Flourish",
                    Description = "You perform a dramatic display of your cloak, distracting nearby enemies.",
                    Skills = SetterHelper<Skill>.Set(Skills.Subterfuge),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                    Range = 3,
                    ChallengeModifier = Constants.ChallengeModifier_NumberOfTargets(2),
                    Tier1 = "You Distract all enemies within range, but you also trigger an Opportunity.",
                    Tier2 = "You Distract all enemies within range.",
                    Tier3 = "You Distract and Taunt all enemies within range.",
                    Tier4 = "You Distract and Taunt all enemies within range. The range is increased to 5 hexes."
                },
            }
        };
    }
}
