using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment RangersCloak = new Adornment
        {
            Name = "Ranger's Cloak",
            Description = "A cloak designed for rangers, providing excellent camouflage.",
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Camouflage",
                    Description = "You blend into your surroundings, becoming nearly invisible to enemies.",
                    Skills = SetterHelper<Skill>.Set(Skills.Subterfuge),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                    Range = 0,
                    Tier1 = "You gain partial camouflage, becoming Invisible until you move or until the end of your next turn.",
                    Tier2 = "You gain partial camouflage, becoming Invisible until you move.",
                    Tier3 = "You gain full camouflage, becoming Invisible.",
                    Tier4 = "You gain full camouflage, becoming Invisible. This Invisibility is not broken by attacking."
                },
            }
        };
    }
}
