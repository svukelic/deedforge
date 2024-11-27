using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Power_Halberd = new Weapon
        {
            Name = "Halberd",
            Description = "A versatile polearm combining an axe blade with a spike and hook.",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Power),
            Design = WeaponDesign.Heavy,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Thrust",
                    Description = "You stab the target with the spike.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 2,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 1 damage to the target, but you trigger a Retaliation.",
                    Tier2 = "You deal 1 damage to the target.",
                    Tier3 = "You deal 2 damage to the target.",
                    Tier4 = "You deal 3 damage to the target."
                },
                new SuccessAction
                {
                    Name = "Armorbane",
                    Description = "You deliver a powerful blow with the axe head.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    Tier1 = "You deal 1 damage to the target and an additional 1 damage if the target is wearing a Heavy armor, but you trigger a Retaliation.",
                    Tier2 = "You deal 1 damage to the target and an additional 1 damage if the target is wearing a Heavy armor.",
                    Tier3 = "You deal 1 damage to the target and an additional 3 damage if the target is wearing a Heavy armor.",
                    Tier4 = "You deal 1 damage to the target and an additional 5 damage if the target is wearing a Heavy armor."
                },
                new SuccessAction
                {
                    Name = "Hook Strike",
                    Description = "You use the hook to pull the target towards you.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 2,
                    ChallengeModifier = Constants.ChallengeModifier_Size(3),
                    Tier1 = "You pull the target 1 hex towards you, but you drop your weapon.",
                    Tier2 = "You pull the target 1 hex towards you.",
                    Tier3 = "You pull the target 1 hex towards you, and the target becomes Prone.",
                    Tier4 = "You pull the target 1 hex towards you, and the target becomes Pinned."
                }
            }
        };
    }
}
