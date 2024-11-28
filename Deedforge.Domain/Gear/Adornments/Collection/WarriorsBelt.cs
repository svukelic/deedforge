using Deedforge.Domain.CoreRules;

namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment WarriorsBelt = new Adornment
        {
            Name = "Warrior's Belt",
            Description = "A belt that allows for a quick draw of a weapon. While wearing this Adornment, you can take a Swap Weapon action at the start of your turn without spending any AP.",
            SuccessActions = new List<SuccessAction>(),
        };
    }
}
