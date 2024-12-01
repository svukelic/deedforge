using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.AdditionalEntities;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry SkyDweller = new Ancestry
        {
            Name = "Sky-Dweller",
            Order = 5,
            AncestryType = AncestryType.Common,
            ImageUrl = "/images/ancestries/sky-dweller.png",
            Quote = "We fly high above the world, for the view is better that way.",
            Description = "Sky-Dwellers are rare creatures which developed the ability to fly, usually through usage of winged appendage.",
            Themes = new List<string> { "Birdfolk", "Winged Lizardfolk", "Bird-related Shapeshifters" },
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Acrobatics,
                Skills.Awareness,
                Skills.Performance,
            },
            PassiveEffect = "You have Flying Speed equal to your Base Movement Speed.",
        };
    }
}
