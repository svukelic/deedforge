using Deedforge.Domain.CoreRules;

namespace Deedforge.Domain.Gear.Shields
{
    public class Shield : SuccessActionCollection
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
