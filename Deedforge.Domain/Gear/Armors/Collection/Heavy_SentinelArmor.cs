using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Heavy_SentinelArmor = new Armor
        {
            Name = "Sentinel Armor",
            Description = "A heavy box-shaped armor with wide shoulder plates, designed for warrior archers.",
            Endurance = 10,
            NumberOfReactions = 1,
            SuccessActions = new SuccessAction
            {
                Name = "Ward & Counter",
                Description = "You deflect a Ranged Attack with your armor, reducing the damage taken.",
                Skills = SkillHelpers.SetSkills(Skills.Defense),
                IsReaction = true,
                Tier1 = "You reduce the damage taken from the deflected attack by 2, but you also become Maimed until the end of your next turn.",
                Tier2 = "You reduce the damage taken from the deflected attack by 2.",
                Tier3 = "You reduce the damage taken by 3, and you can make a Retaliation against the target that attacked you.",
                Tier4 = "You reduce the damage taken by 4, and you can make a Retaliation against the target that attacked you."
            }
        };
    }
}
