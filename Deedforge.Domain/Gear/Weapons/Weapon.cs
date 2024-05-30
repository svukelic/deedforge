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
        public required List<BaseAttackForm> Forms { get; set; }
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
        [Description("")]
        Brutal,
        [Description("(Ranged Only) This weapon doesn’t suffer from Lower Hand when attacking a target within Melee vicinity.")]
        Flexible,
        [Description("")]
        Heavy,
        [Description("")]
        Light,
        [Description("")]
        Reaching,
        [Description("")]
        Focus,
        [Description("")]
        Sundering,
        [Description("")]
        Swift,
        [Description("")]
        Versatile,
    }
}
