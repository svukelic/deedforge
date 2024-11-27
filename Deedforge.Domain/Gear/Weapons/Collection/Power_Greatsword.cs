using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Power_Greatsword = new Weapon
        {
            Name = "Greatsword",
            Description = "A two-handed sword with a wide blade.",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Power),
            Design = WeaponDesign.Heavy,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Cleave",
                    Description = "You swing your greatsword in a wide cleave, damaging all foes in your path.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee, ActionType.Area),
                    Range = 1,
                    ChallengeModifier = Constants.ChallengeModifier_NumberOfTargets(2),
                    Tier1 = "You deal 2 damage to your target and up to 2 other targets within 1 hex of them that are within your reach, but you trigger a Retaliation.",
                    Tier2 = "You deal 2 damage to your target and up to 2 other targets within 1 hex of them that are within your reach.",
                    Tier3 = "You deal 4 damage to your target and up to 2 other targets within 1 hex of them that are within your reach.",
                    Tier4 = "You deal 6 damage to your target and up to 2 other targets within 1 hex of them that are within your reach."
                },
                new SuccessAction
                {
                    Name = "Killing Blow",
                    Description = "You deliver a powerful strike to a distraught foe, potentially killing them outright.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 2 damage to your target, but you trigger a Retaliation. The damage is doubled if the target is Crippled, Maimed or Pinned.",
                    Tier2 = "You deal 2 damage to your target. The damage is doubled if the target is Crippled, Maimed or Pinned.",
                    Tier3 = "You deal 4 damage to your target. The damage is doubled if the target is Crippled, Maimed or Pinned.",
                    Tier4 = "You deal 6 damage to your target. The damage is doubled if the target is Crippled, Maimed or Pinned."
                },
                new SuccessAction
                {
                    Name = "Heavy Thrust",
                    Description = "You thrust your greatsword at your foe, potentially causing severe wounds.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "Your target becomes Crippled until the end of their next turn, but you also drop your weapon.",
                    Tier2 = "Your target becomes Crippled until the end of their next turn.",
                    Tier3 = "Your target becomes Crippled and Maimed until the end of their next turn.",
                    Tier4 = "Your target becomes Pinned until the end of their next turn, but you can't use this weapon while it is Pinning the target."
                }
            }
        };
    }
}
