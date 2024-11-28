using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment ToughCloak = new Adornment
        {
            Name = "Tough Cloak",
            Description = "A cloak that provides protection against damaging effects.",
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Resist Conditions",
                    Description = "You block the effects of a damaging condition.",
                    Skills = SetterHelper<Skill>.Set(Skills.Defense, Skills.Acrobatics, Skills.Arcana, Skills.Occultism),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                    Range = 0,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You prevent Bleeding and Burning from being applied to you, but you also become Slowed until the end of your next turn.",
                    Tier2 = "You prevent Bleeding and Burning from being applied to you.",
                    Tier3 = "You prevent Bleeding and Burning from being applied to you, and gain immunity to the next instance of Bleeding and Burning that would be applied to you.",
                    Tier4 = "You prevent Bleeding and Burning from being applied to you, and gain immunity to the next instance of Bleeding and Burning that would be applied to you. You also can make a Retaliation against the target that attacked you."
                },
            }
        };
    }
}
