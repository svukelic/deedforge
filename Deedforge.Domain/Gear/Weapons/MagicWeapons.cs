using Deedforge.Domain.CoreRules.Attacking;

namespace Deedforge.Domain.Gear.Weapons
{
    public class MagicWeapons
    {
        public Weapon Wand = new Weapon
        {
            Name = "Wand",
            Description = "A slender twig which allows for easy handling.",
            Type = WeaponType.Magic,
            Design = WeaponDesign.Light,
            Forms = new List<BaseAttackForm> { BaseAttackForms.Bolt, BaseAttackForms.Ward }
        };

        public Weapon Staff = new Weapon
        {
            Name = "Staff",
            Description = "A cumbersome branch that can summon tremendous amounts of magics.",
            Type = WeaponType.Magic,
            Design = WeaponDesign.Heavy,
            Forms = new List<BaseAttackForm> { BaseAttackForms.Bolt, BaseAttackForms.Ward, BaseAttackForms.Wave }
        };
    }
}
