using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Shields.Collection
{
    public partial class Shields
    {
        public static Shield SerratedShield = new Shield
        {
            Name = "Serrated Shield",
            Description = "A shield with jagged edges designed to catch and trap enemy weapons.",
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
                    Name = "Shield Snare",
                    Description = "You snare an incoming Melee attack, damaging and potentially disarming the enemy.",
                    Skills = SetterHelper<Skill>.Set(Skills.Defense),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction, ActionType.Melee),
                    Range = 1,
                    Tier1 = "You deal 1 damage to the triggering enemy, but you also lose the benefits of your Raise Shield Action.",
                    Tier2 = "You deal 1 damage to the triggering enemy.",
                    Tier3 = "You deal 2 damage to the triggering enemy, and you Disarm them.",
                    Tier4 = "You deal 3 damage to the triggering enemy, and you Disarm them."
                }
            }
        };
    }
}
