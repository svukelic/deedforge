using Deedforge.Domain.CoreRules.Attacking;
using System.ComponentModel;

namespace Deedforge.Domain.Gear.Weapons
{
    public class Weapon
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required WeaponType Type { get; set; }
        public required WeaponDesign Design { get; set; }
        public required List<AttackForm> Forms { get; set; }
    }

    public enum WeaponType
    {
        [Description("")]
        Simple,
        [Description("")]
        OneHanded,
        [Description("")]
        TwoHanded,
        [Description("")]
        Ranged,
        [Description("")]
        Magic,
        [Description("")]
        Exotic,
    }

    public enum WeaponDesign
    {
        [Description("Target of this weapon's attack is treated as having 1 less Endurance than they have.")]
        Brutal,
        [Description("Wielder of this weapon can take Parry reaction with it.")]
        Dueling,
        [Description("(Ranged Only) This weapon doesn’t suffer from Lower Hand when attacking a target within Melee vicinity.")]
        Flexible,
        [Description("This weapon requires two hands and Trained in Athletics to be properly used.")]
        Heavy,
        [Description("This weapon is exceptionally light and can be equipped at the same time as another Light or Focus weapon.")]
        Light,
        [Description("(Melee Only) This weapon can be used to attack from Near vicinity.")]
        Reaching,
        [Description("(Magic Weapons Only) This weapon does not have a Primary Attack. However, it provides an additional Spell Form instead.")]
        Focus,
        [Description("This weapon ignores any bonuses to targets AR above their baseline AR.")]
        Sundering,
        [Description("Dodging or Parrying against this weapon is done with a Lower Hand.")]
        Swift,
        [Description("This weapon can use multiple Primary Attacks.")]
        Versatile,
    }
}
