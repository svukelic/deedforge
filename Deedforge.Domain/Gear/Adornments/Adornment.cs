using Deedforge.Domain.AdditionalEntities;

namespace Deedforge.Domain.Gear.Adornments
{
    public class Adornment : SuccessActionCollection
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required AdornmentType AdornmentType { get; set; }
    }

    public enum AdornmentType
    {
        Belt,
        Cloak,
        Jewelry,
    }
}
