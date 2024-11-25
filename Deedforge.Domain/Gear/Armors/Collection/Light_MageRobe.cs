using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Light_MageRobe = new Armor
        {
            Name = "Mage Robe",
            Description = "A lightweight robe providing magical protection.",
            Endurance = 4,
            NumberOfReactions = 3,
            SuccessActions = new SuccessAction
            {
                Name = "Absorb Spell",
                Description = "You nullify a spell targeting you.",
                Skills = SkillHelpers.SetSkills(Skills.Arcana, Skills.Occultism),
                ActionTypes = new List<ActionType> { ActionType.Reaction },
                Tier1 = "You ignore non-damaging effects of a spell targeting or affecting you, but you also become Silenced until the end of your next turn.",
                Tier2 = "You ignore non-damaging effects of a spell targeting or affecting you.",
                Tier3 = "You ignore non-damaging effects of a spell targeting or affecting you, and your next Spell Attack has an Upper Hand.",
                Tier4 = "You ignore all damage and effects of a spell targeting or affecting you, and your next Spell Attack has an Upper Hand."
            }
        };
    }
}
