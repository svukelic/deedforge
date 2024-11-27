using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Symbolic_BattleHorn = new Weapon
        {
            Name = "Battlehorn",
            Description = "A heavy axe used for combat",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Symbolic),
            Design = WeaponDesign.Versatile,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Charge!",
                    Description = "You let out a powerful bellow that calls for a charge. You cannot use this Action while Silenced.",
                    Skills = SetterHelper<Skill>.Set(Skills.SymbolicWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Area),
                    Range = 5,
                    ChallengeModifier = Constants.ChallengeModifier_NumberOfTargets(2),
                    Tier1 = "All affected allies within range can immediately as a Reaction take Move action. However, you become Silenced until the end of your next turn.",
                    Tier2 = "All affected allies within range can immediately as a Reaction take Move action.",
                    Tier3 = "All affected allies within range can immediately as a Reaction take Move or Attack action.",
                    Tier4 = "All affected allies within range can immediately as a Reaction take Move or Attack action. The range is increased to 10 hexes."
                },
                new SuccessAction
                {
                    Name = "Terrifying Wail",
                    Description = "You let out a terrifying wail that shakes your foes' resolve. You cannot use this Action while Silenced.",
                    Skills = SetterHelper<Skill>.Set(Skills.SymbolicWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Area),
                    Range = 5,
                    ChallengeModifier = Constants.ChallengeModifier_NumberOfTargets(2),
                    Tier1 = "All affected enemies within range become Frightened until the end of their next turn. However, you become Silenced until the end of your next turn.",
                    Tier2 = "All affected enemies within range become Frightened until the end of their next turn.",
                    Tier3 = "All affected enemies within range become Distracted and Frightened until the end of their next turn.",
                    Tier4 = "All affected enemies within range become Distracted and Frightened until the end of their next turn. The range is increased to 10 hexes."
                },
            }
        };
    }
}
