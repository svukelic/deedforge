using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Power_Battleaxe = new Weapon
        {
            Name = "Battleaxe",
            Description = "A heavy axe used for combat",
            Type = WeaponType.Power,
            Design = WeaponDesign.Versatile,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Brutal Strike",
                    Description = "You swing your weapon in a wide arc, hitting multiple foes at once.",
                    Skills = SkillHelpers.SetSkills(Skills.PowerWeapons),
                    ActionTypes = new List<ActionType> { ActionType.Melee },
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "TBD",
                    Tier2 = "TBD",
                    Tier3 = "TBD",
                    Tier4 = "TBD"
                },
                new SuccessAction
                {
                    Name = "Guard Break",
                    Description = "You strike your foe's guard, breaking it and leaving them open to attack.",
                    Skills = SkillHelpers.SetSkills(Skills.PowerWeapons),
                    ActionTypes = new List<ActionType> { ActionType.Melee },
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "TBD",
                    Tier2 = "TBD",
                    Tier3 = "TBD",
                    Tier4 = "TBD"
                }
            }
        };
    }
}
