using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Light_RangersArmor = new Armor
        {
            Name = "Ranger's Armor",
            Description = "A set of armor designed for rangers, providing excellent camouflage and mobility.",
            Endurance = 5,
            NumberOfReactions = 3,
            SuccessActions = new SuccessAction
            {
                Name = "Camouflage",
                Description = "You blend into your surroundings, becoming nearly invisible to enemies.",
                Skills = SkillHelpers.SetSkills(Skills.Subterfuge),
                Tier1 = "You gain partial camouflage, becoming Invisible until you move or until the end of your next turn.",
                Tier2 = "You gain partial camouflage, becoming Invisible until you move.",
                Tier3 = "You gain full camouflage, becoming Invisible.",
                Tier4 = "You gain full camouflage, becoming Invisible. This Invisibility is not broken by attacking."
            }
        };
    }
}
