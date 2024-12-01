using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry UnderDweller = new Ancestry
        {
            Name = "Under-Dweller",
            Order = 3,
            AncestryType = AncestryType.Common,
            ImageUrl = "/images/ancestries/under-dweller.png",
            Quote = "From darkness below, and into the darkness within.",
            Description = "Under-Dwellers are stealthy folk that live underground. They have developed special kinds of adaptation, including vision and other senses, as part of their mostly lightless lives.",
            Themes = new List<string> { "Dwarves", "Goblins", "Dark Elves" },
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Subterfuge,
                Skills.Defense,
                Skills.Intimidation,
            },
            PassiveEffect = "You have Heat Vision.",
        };
    }
}
