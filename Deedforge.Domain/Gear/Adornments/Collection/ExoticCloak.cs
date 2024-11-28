using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment HoodedCloak = new Adornment
        {
            Name = "Hooded Cloak",
            Description = "A cloak with a hood, providing anonymity.",
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Blend In",
                    Description = "You can hide in plain sight, making it difficult for others to notice you.",
                    Skills = SetterHelper<Skill>.Set(Skills.Subterfuge),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                    Range = 0,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "While in a crowd, you can accomplish one task, but you also noticed while doing so. The Guide decides on specific details.",
                    Tier2 = "While in a crowd, you can accomplish one task without being noticed.",
                    Tier3 = "While in a crowd, you can accomplish two tasks without being noticed.",
                    Tier4 = "While in a crowd, you can accomplish three tasks without being noticed."
                },
            }
        };
    }
}
