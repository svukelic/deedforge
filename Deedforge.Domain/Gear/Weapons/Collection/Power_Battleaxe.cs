using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Power_Battleaxe = new Weapon
        {
            Name = "Battleaxe",
            Description = "A heavy axe used for combat.",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Power),
            Design = WeaponDesign.Versatile,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Brutal Strike",
                    Description = "You deliver a powerful strike to your foe.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 1 damage to the target, but you trigger a Opportunity.",
                    Tier2 = "You deal 1 damage to the target, and the target becomes Staggered until the end of their next turn.",
                    Tier3 = "You deal 2 damage to the target, and the target becomes Staggered until the end of their next turn.",
                    Tier4 = "You deal 3 damage to the target, and the target becomes Staggered until the end of their next turn."
                },
                new SuccessAction
                {
                    Name = "Guard Break",
                    Description = "You strike your foe's guard, breaking it and leaving them open to attack.",
                    Skills = SetterHelper<Skill>.Set(Skills.PowerWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Melee),
                    Range = 1,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "The target loses the benefits of their Raise Shield Action, but you trigger a Opportunity.",
                    Tier2 = "The target loses the benefits of their Raise Shield Action.",
                    Tier3 = "The target loses the benefits of their Raise Shield Action, and you deal 1 damage to the target.",
                    Tier4 = "The target loses the benefits of their Raise Shield Action, and you deal 2 damage to the target."
                },
            }
        };
    }
}
