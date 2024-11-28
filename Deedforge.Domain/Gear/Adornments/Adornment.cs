using Deedforge.Domain.CoreRules;

namespace Deedforge.Domain.Gear.Adornments
{
    public class Adornment : SuccessActionCollection
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
