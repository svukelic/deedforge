using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Light_LeatherArmor = new Armor
        {
            Name = "Leather Armor",
            Description = "A set of armor made from tanned animal hides, offering a balance between protection and mobility.",
            Endurance = 4,
            NumberOfReactions = 3,
            SuccessActions = new SuccessAction
            {
                Name = "Dodge",
                Description = "You dodge an attack targeting you, moving out of the way just in time.",
                Skills = SkillHelpers.SetSkills(Skills.Acrobatics),
                ActionTypes = new List<ActionType> { ActionType.Reaction },
                Tier1 = "You ignore the triggering attack and move 2 hexes, but you trigger Retaliation.",
                Tier2 = "You ignore the triggering attack and move 2 hexes.",
                Tier3 = "You ignore the triggering attack and move 2 hexes, and the movement doesn't trigger any Reactions.",
                Tier4 = "You ignore the triggering attack and move 3 hexes, and the movement doesn't trigger any Reactions."
            }
        };
    }
}
