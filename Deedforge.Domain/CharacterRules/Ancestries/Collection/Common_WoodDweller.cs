using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry WoodDweller = new Ancestry
        {
            Name = "Wood-Dweller",
            Order = 2,
            AncestryType = AncestryType.Common,
            ImageUrl = "/images/ancestries/wood-dweller.png",
            Quote = "Forest is a place of life, but also a place of death. It is full of friends, but also full of enemies.",
            Description = "Wood-Dwellers spend their lives stalking in lush forests and woods, living in tune with the nature.",
            Themes = new List<string> { "Wood Elves", "Nomadic Humans", "Woodland Shapeshifters" },
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Subterfuge,
                Skills.Animals,
                Skills.PrecisionWeapons,
            },
            PassiveEffect = "You gain a Companion. This Companion must be a Common, Small or Medium Animal.",
        };
    }
}
