using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Shields.Collection
{
    public partial class Shields
    {
        public static Shield KiteShield = new Shield
        {
            Name = "Kite Shield",
            Description = "A tall, teardrop-shaped shield that provides excellent coverage while remaining manageable.",
            SuccessActions = new List<SuccessAction>()
            {
                new SuccessAction
                {
                    Name = "Raise Shield",
                    Description = "You raise your Shield to intercept incoming attacks.",
                    Skills = SetterHelper<Skill>.Set(Skills.Defense),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                    Range = 0,
                    Tier1 = "You gain 1 Grit, but you are also Staggered until the end of your next turn.",
                    Tier2 = "You gain 1 Grit.",
                    Tier3 = "You gain 2 Grit.",
                    Tier4 = "You gain 3 Grit."
                },
                new SuccessAction
                {
                    Name = "Deflect Attack",
                    Description = "You deflect an incoming attack.",
                    Skills = SetterHelper<Skill>.Set(Skills.Defense),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                    Range = 1,
                    Tier1 = "You reduce the damage taken from the deflected attack by 1, but you also lose the benefits of your Raise Shield Action.",
                    Tier2 = "You reduce the damage taken from the deflected attack by 1",
                    Tier3 = "You reduce the damage taken from the deflected attack by 2.",
                    Tier4 = "You reduce the damage taken from the deflected attack by 3."
                }
            }
        };
    }
}
