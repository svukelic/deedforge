using Deedforge.Domain.AdditionalEntities;
using System.ComponentModel;

namespace Deedforge.Domain.Gear.Weapons
{
    public class Weapon : SuccessActionCollection
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required List<WeaponType> Types { get; set; }
        public required WeaponDesign Design { get; set; }
    }

    public enum WeaponType
    {
        [Description("Weapons which use raw might to overpower foes.")]
        Power,
        [Description("Weapons which use precision to strike at weak spots.")]
        Precision,
        [Description("Weapons which use magic to deal damage to foes.")]
        Mystical,
        [Description("Weapons which are used to empower and bolster allies.")]
        Symbolic,
    }

    public enum WeaponDesign
    {
        [Description("This weapon requires two hands and Trained in Athletics to be properly used. Heavy weapons usually either deal more damage, or can hit multiple targets at once, and they provide one additional Attack Action.")]
        Heavy,
        [Description("This weapon is exceptionally light and can be used in either main hand or off-hand. When carried in off-hand, it grants a specific Reaction instead of its usual Attacks.")]
        Light,
        [Description("This weapon requires only one hand, and is particularly quick. It has Upper Hand on all Attack checks done as part of a Opportunity.")]
        Swift,
        [Description("This weapon requires only one hand, but can also be used with two hands. When used with two hands, it has Upper Hand on the Attack check.")]
        Versatile,
    }
}
