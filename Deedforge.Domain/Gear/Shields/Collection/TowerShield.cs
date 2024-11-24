using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Shields.Collection
{
    public partial class Shields
    {
        public static Shield TowerShield = new Shield
        {
            Name = "Tower Shield",
            Description = "A massive rectangular shield that covers most of the body, offering superior protection at the cost of mobility.",
            SuccessActions = new List<SuccessAction>()
            {
                new SuccessAction
                {
                    Name = "Raise Shield",
                    Description = "You raise your Shield to intercept incoming attacks. While the Shield is raised, your movement speed is halved.",
                    Skills = SkillHelpers.SetSkills(Skills.Defense),
                    Tier1 = "You gain 2 Grit, but you are also Staggered until the end of your next turn.",
                    Tier2 = "You gain 2 Grit.",
                    Tier3 = "You gain 4 Grit.",
                    Tier4 = "You gain 6 Grit."
                },
                new SuccessAction
                {
                    Name = "Block Assault",
                    Description = "You block an incoming assault.",
                    Skills = SkillHelpers.SetSkills(Skills.Defense),
                    IsReaction = true,
                    Tier1 = "You reduce the damage taken from the deflected attack by 2, and you become Unyielding until the end of your next turn. You also become Pinned until you either set Tower Shield free or dispose of it.",
                    Tier2 = "You reduce the damage taken from the deflected attack by 2, and you become Unyielding until the end of your next turn.",
                    Tier3 = "You reduce the damage taken from the deflected attack by 4, and you become Unyielding until the end of your next turn.",
                    Tier4 = "You reduce the damage taken from the deflected attack by 6, and you become Unyielding until the end of your next turn."
                }
            }
        };
    }
}
