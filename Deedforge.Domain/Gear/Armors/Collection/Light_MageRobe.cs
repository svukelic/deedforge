using Deedforge.Domain.AdditionalEntities;
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
            ArmorType = ArmorType.Light,
            Endurance = 4,
            NumberOfReactions = 3,
            SuccessActions = new SuccessAction
            {
                Name = "Absorb Spell",
                Description = "You nullify a spell targeting you.",
                Skills = SetterHelper<Skill>.Set(Skills.Arcana, Skills.Occultism),
                ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                Range = 0,
                Tier1 = "You ignore non-damaging effects of a spell targeting or affecting you, but you also become Silenced until the end of your next turn.",
                Tier2 = "You ignore non-damaging effects of a spell targeting or affecting you.",
                Tier3 = "You ignore non-damaging effects of a spell targeting or affecting you, and your next Spell Attack has an Upper Hand.",
                Tier4 = "You ignore all damage and effects of a spell targeting or affecting you, and your next Spell Attack has an Upper Hand."
            }
        };
    }
}
