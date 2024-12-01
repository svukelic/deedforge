using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry ValleyDweller = new Ancestry
        {
            Name = "Valley-Dweller",
            Order = 1,
            AncestryType = AncestryType.Common,
            ImageUrl = "/images/ancestries/valley-dweller.png",
            Quote = "Once a suitable home is found, it rarely left. Roots grow deep and memories long. And even in travels, one makes sure to return.",
            Description = "The Valley-Dwellers tend to be hardy people who have lived in the valley for generations. They are usually known for their strength and resilience, and for their deep connection to the land.",
            Themes = new List<string> { "Humans", "Elves", "Halflings" },
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Athletics,
                Skills.Forestry,
                Skills.Influence,
            },
            PassiveEffect = "You gain a +1 Glimpse per Adventure.",
        };
    }
}
