using Deedforge.Domain.CoreRules;

namespace Deedforge.Domain.Gear.Armors
{
    public class Armor : SuccessActionCollection
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required ArmorType ArmorType { get; set; }
        public required int Endurance { get; set; }
        public required int NumberOfReactions { get; set; }
    }

    public enum ArmorType
    {
        Light,
        Medium,
        Heavy
    }
}
