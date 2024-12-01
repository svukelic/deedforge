using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;
using Deedforge.Domain.AdditionalEntities;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon PowerPrecision_Glaive = new Weapon
        {
            Name = "Glaive",
            Description = "A heavy axe used for combat",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Power, WeaponType.Precision),
            Design = WeaponDesign.Versatile,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Arcing Slash",
                    Description = "You slash your foes with a wide arc.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons, Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee, ActionType.Area),
                    Range = 2,
                    ChallengeModifier = Constants.ChallengeModifier_NumberOfTargets(2),
                    Tier1 = "You deal 1 damage to your target and any other targets within 1 hex of them that are within your reach, but you trigger a Opportunity.",
                    Tier2 = "You deal 1 damage to your target and any other targets within 1 hex of them that are within your reach.",
                    Tier3 = "You deal 2 damage to your target and any other targets within 1 hex of them that are within your reach.",
                    Tier4 = "You deal 3 damage to your target and any other targets within 1 hex of them that are within your reach."
                },
                new SuccessAction
                {
                    Name = "Thrust",
                    Description = "You stab the target with the top of the glaive.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons, Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 2,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 1 damage to the target, but you trigger a Opportunity.",
                    Tier2 = "You deal 1 damage to the target.",
                    Tier3 = "You deal 2 damage to the target.",
                    Tier4 = "You deal 3 damage to the target."
                },
                new SuccessAction
                {
                    Name = "Leg Sweep",
                    Description = "You sweep the target's legs, knocking them down.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons, Skills.PrecisionWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 2,
                    Tier1 = "You knock the target Prone, but you drop your weapon.",
                    Tier2 = "You knock the target Prone.",
                    Tier3 = "You knock the target Prone, and you deal 1 damage to the target.",
                    Tier4 = "You knock the target Prone, and you deal 2 damage to the target."
                }
            }
        };
    }
}
