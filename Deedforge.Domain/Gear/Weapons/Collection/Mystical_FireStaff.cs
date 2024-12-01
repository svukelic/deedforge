using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;
using Deedforge.Domain.AdditionalEntities;

namespace Deedforge.Domain.Gear.Weapons.Collection
{
    public partial class Weapons
    {
        public static Weapon Mystical_FireStaff = new Weapon
        {
            Name = "Fire Staff",
            Description = "A staff made of fire-resistant wood, with a fiery source of power.",
            Types = SetterHelper<WeaponType>.Set(WeaponType.Mystical),
            Design = WeaponDesign.Heavy,
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Fire Blast",
                    Description = "You unleash a blast of fire from your staff.",
                    Skills = SetterHelper<Skill>.Set(Skills.MysticalWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Ranged, ActionType.Spell, ActionType.Area),
                    Range = 5,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You deal 1 damage to the target and they start Burning until the end of their next turn, but you trigger a Opportunity.",
                    Tier2 = "You deal 1 damage to the target and they start Burning until the end of their next turn.",
                    Tier3 = "You deal 1 damage to the target as well as all targets within 2 hexes of the target and they start Burning until the end of their next turn.",
                    Tier4 = "You deal 1 damage to the target as well as all targets within 3 hexes of the target and they start Burning until the end of their next turn."
                },
                new SuccessAction
                {
                    Name = "Wall of Fire",
                    Description = "You create a wall of fire at the target location within range.",
                    Skills = SetterHelper<Skill>.Set(Skills.MysticalWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Ranged, ActionType.Spell, ActionType.Area),
                    Range = 5,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You summon a Wall of Fire on 3 connected hexes in a line on the target location. Any target that moves through the Wall of Fire starts Burning until the end of their next turn. However, you also summon a Wall of Fire on the hex you are currently on. Wall of Fire lasts until the start of your next turn.",
                    Tier2 = "You summon a Wall of Fire on 4 connected hexes in a line on the target location. Any target that moves through the Wall of Fire starts Burning until the end of their next turn.",
                    Tier3 = "You summon a Wall of Fire on 5 connected hexes in a line on the target location. Any target that moves through the Wall of Fire starts Burning until the end of their next turn.",
                    Tier4 = "You summon a Wall of Fire on 6 connected hexes in a line on the target location. Any target that moves through the Wall of Fire starts Burning until the end of their next turn."
                },
                new SuccessAction
                {
                    Name = "Lesser Fire Elemental",
                    Description = "You summon a Lesser Fire Elemental to temporarily fight for you. You can only summon one Lesser Fire Elemental per battle with this weapon.",
                    Skills = SetterHelper<Skill>.Set(Skills.MysticalWeapons),
                    ActionTypes = SetterHelper<ActionType>.Set(ActionType.Ranged, ActionType.Spell, ActionType.Area),
                    Range = 5,
                    ChallengeModifier = Constants.ChallengeModifier_Endurance,
                    Tier1 = "You summon a Lesser Fire Elemental to fight for you.",
                    Tier2 = "You summon a Lesser Fire Elemental to fight for you.",
                    Tier3 = "You summon a Lesser Fire Elemental to fight for you.",
                    Tier4 = "You summon a Lesser Fire Elemental to fight for you."
                }
            }
        };
    }
}
