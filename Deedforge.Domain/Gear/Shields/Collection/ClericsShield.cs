using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Shields.Collection
{
    public partial class Shields
    {
        public static Shield ClericsShield = new Shield
        {
            Name = "Cleric's Shield",
            Description = "A shield usually carried by Clerics, ",
            SuccessActions = new List<SuccessAction>()
            {
                new SuccessAction
                {
                    Name = "Raise Shield",
                    Description = "You raise your Shield to intercept incoming attacks.",
                    Skills = SetterHelper<Skill>.Set(Skills.Defense, Skills.Faith, Skills.SymbolicWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                    Range = 0,
                    Tier1 = "You gain 1 Grit, but you are also Staggered until the end of your next turn.",
                    Tier2 = "You gain 1 Grit.",
                    Tier3 = "You gain 2 Grit.",
                    Tier4 = "You gain 3 Grit."
                },
                new SuccessAction
                {
                    Name = "Divine Inspiration",
                    Description = "You grant temporary defenses to your allies.",
                    Skills = SetterHelper<Skill>.Set(Skills.Defense, Skills.Faith, Skills.SymbolicWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                    Range = 5,
                    ChallengeModifier = Constants.ChallengeModifier_NumberOfTargets(2),
                    Tier1 = "All allies of your choice within range gain +2 Grit until the start of your next turn, but you also trigger Retaliation.",
                    Tier2 = "All allies of your choice within range gain +2 Grit until the start of your next turn.",
                    Tier3 = "All allies of your choice within range gain +4 Grit until the start of your next turn.",
                    Tier4 = "All allies of your choice within range gain +4 Grit until the start of your next turn. The range is increased to 10 hexes."
                }
            }
        };
    }
}
