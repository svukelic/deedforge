using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CharacterRules.Ancestries
{
    public class Ancestry : SuccessActionCollection
    {
        public required string Name { get; set; }
        public required int Order { get; set; }
        public required AncestryType AncestryType { get; set; }
        public required string ImageUrl { get; set; }
        public required string Quote { get; set; }
        public required string Description { get; set; }
        public List<string> Themes { get; set; } = new();
        public string? Limitations { get; set; }
        public List<Skill> GrantedTraitCategories { get; set; } = new();
        public string? PassiveEffect { get; set; }
    }

    public enum AncestryType
    {
        Common,
        Exotic
    }
}
