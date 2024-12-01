using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.AdditionalEntities;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry SeaDweller = new Ancestry
        {
            Name = "Sea-Dweller",
            Order = 4,
            AncestryType = AncestryType.Common,
            ImageUrl = "/images/ancestries/sea-dweller.png",
            Quote = "The sea is a big place, and there are many things to see and do. But sometimes, it is good to just stay home.",
            Description = "Sea-Dwellers are marine-life-oriented folk living on islands and the coast. They are naturally adapted to balancing spending their lives between the open seas and the solid land.",
            Themes = new List<string> { "Sea Elves", "Turtlefolk" },
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Athletics,
                Skills.SleightOfHand,
                Skills.Engineering,
            },
            PassiveEffect = "You have Swimming Speed equal to your Base Movement Speed, and you are automatically considered to be Hidden while in water.",
        };
    }
}
