using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Precision_Longbow = new Weapon
        {
            Name = "Longbow",
            Description = "A heavy axe used for combat",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Power, WeaponType.Precision),
            Design = WeaponDesign.Heavy,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Pinning Shot",
                    Description = "You attempt to pin an enemy with a shot to their body.",
                    Skills = SetterHelper<Skill>.Set(Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Ranged),
                    Range = 30,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 1 damage to the target, but you become Staggered until the end of your next turn.",
                    Tier2 = "You deal 1 damage to the target.",
                    Tier3 = "You deal 2 damage to the target, and the target becomes Pinned until they free themselves.",
                    Tier4 = "You deal 3 damage to the target, and the target becomes Pinned until they free themselves."
                },
                new SuccessAction
                {
                    Name = "Long Shot",
                    Description = "You steady your aim and attempt to deal damage to an enemy at a long range.",
                    Skills = SetterHelper<Skill>.Set(Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Ranged),
                    Range = 30,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 1 damage to the target, and you become Staggered until the end of your next turn. You deal an additional 1 damage and the range of this attack is increased by 10 for each additional AP you spent.",
                    Tier2 = "You deal 1 damage to the target. You deal an additional 1 damage and the range of this attack is increased by 10 for each additional AP you spent.",
                    Tier3 = "You deal 2 damage to the target. You deal an additional 2 damage and the range of this attack is increased by 15 for each additional AP you spent.",
                    Tier4 = "You deal 3 damage to the target. You deal an additional 3 damage and the range of this attack is increased by 20 for each additional AP you spent."
                },
                new SuccessAction
                {
                    Name = "Barrage",
                    Description = "You fire a volley of shots at your target.",
                    Skills = SetterHelper<Skill>.Set(Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Ranged, ActionType.Area),
                    Range = 30,
                    ChallengeModifier = Constants.ChallengeModifier_NumberOfTargets(2),
                    Tier1 = "You deal 1 damage all foes within 1 hex radius of your target location, but you become Staggered until the end of your next turn.",
                    Tier2 = "You deal 1 damage all foes within 1 hex radius of your target location.",
                    Tier3 = "You deal 2 damage all foes within 2 hex radius of your target location.",
                    Tier4 = "You deal 3 damage all foes within 3 hex radius of your target location."
                }
            }
        };
    }
}
