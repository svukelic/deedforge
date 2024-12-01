using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;
using Deedforge.Domain.AdditionalEntities;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Power_Mace = new Weapon
        {
            Name = "Mace",
            Description = "A heavy mace used for combat",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Power),
            Design = WeaponDesign.Versatile,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Bash",
                    Description = "You swing your mace at your foe.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 1 damage to the target, but you trigger a Opportunity.",
                    Tier2 = "You deal 1 damage to the target.",
                    Tier3 = "You deal 2 damage to the target, and the target becomes Distracted.",
                    Tier4 = "You deal 2 damage to the target, and the target becomes Distracted and Dazed until the end of their next turn."
                },
                new SuccessAction
                {
                    Name = "Dent Armor",
                    Description = "You strike your foe's armor, denting it and weakening it.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "The target becomes Weakened(Defense) until the end of their next turn, but you trigger a Opportunity.",
                    Tier2 = "The target becomes Weakened(Defense) until the end of their next turn.",
                    Tier3 = "The target becomes Weakened(Defense) until the end of their next turn, and you deal 1 damage to the target.",
                    Tier4 = "The target becomes Weakened(Defense) until the end of their next turn, and you deal 2 damage to the target."
                },
            }
        };
    }
}
