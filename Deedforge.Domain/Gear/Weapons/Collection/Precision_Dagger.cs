using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Precision_Dagger = new Weapon
        {
            Name = "Dagger",
            Description = "A heavy axe used for combat",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Precision),
            Design = WeaponDesign.Light,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Precision Strike",
                    Description = "You deliver a precise strike to your foe, aiming for a vital spot.",
                    Skills = SetterHelper<Skill>.Set(Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    Tier1 = "You deal 1 damage to the target, but you trigger a Retaliation. The damage is doubled if you attack while Hidden.",
                    Tier2 = "You deal 1 damage to the target. The damage is doubled if you attack while Hidden.",
                    Tier3 = "You deal 2 damage to the target. The damage is doubled if you attack while Hidden.",
                    Tier4 = "You deal 3 damage to the target. The damage is doubled if you attack while Hidden."
                },
                new SuccessAction
                {
                    Name = "Throw",
                    Description = "You throw your dagger at your target.",
                    Skills = SetterHelper<Skill>.Set(Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Ranged),
                    Range = 5,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You miss the target, but cause it to become Distracted.",
                    Tier2 = "You deal 1 damage to the target.",
                    Tier3 = "You deal 1 damage to the target, and the target becomes Maimed until the end of their next turn.",
                    Tier4 = "You deal 1 damage to the target, and the target becomes Blinded until the end of their next turn."
                },
                new SuccessAction
                {
                    Name = "Quick Guard",
                    Description = "(Offhand only) You use your dagger to parry an attack.",
                    Skills = SetterHelper<Skill>.Set(Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                    Range = 1,
                    Tier1 = "You reduce the damage taken from the parried attack by 1, but you also drop your weapon.",
                    Tier2 = "You reduce the damage taken from the parried attack by 1.",
                    Tier3 = "You reduce the damage taken from the parried attack by 1, and you can Retaliate against the enemy.",
                    Tier4 = "You reduce the damage taken from the parried attack by 1, and the enemy becomes Staggered until the end of their next turn."
                }
            }
        };
    }
}
