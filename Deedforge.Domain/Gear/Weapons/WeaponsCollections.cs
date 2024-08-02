using Deedforge.Domain.CoreRules.Attacking;

namespace Deedforge.Domain.Gear.Weapons
{
    public class WeaponsCollections
    {
        public List<Weapon> SimpleWeapons = new List<Weapon>
        {
            new Weapon
            {
                Name = "Dagger",
                Description = "A small",
                Type = WeaponType.Simple,
                Design = WeaponDesign.Light,
                Forms = new List<AttackForm> { MeleeAttacks.Bash, MeleeAttacks.Cleave, MeleeAttacks.Disarm }
            }
        };

        public List<Weapon> OneHandedWeapons = new List<Weapon>
        {
            new Weapon
            {
                Name = "Battleaxe",
                Description = "A sturdy axe designed for powerful strikes.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Brutal,
                Forms = new List<AttackForm> { MeleeAttacks.Cleave, MeleeAttacks.KillingBlow, MeleeAttacks.OverheadStrike }
            },
            new Weapon
            {
                Name = "Flail",
                Description = "A weapon consisting of one or more heavy weights attached to a handle by a chain.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Sundering,
                Forms = new List<AttackForm> { MeleeAttacks.GuardBreak, MeleeAttacks.OverheadStrike, MeleeAttacks.Trip }
            },
            new Weapon
            {
                Name = "Longsword",
                Description = "A versatile sword with a long blade, used for both cutting and thrusting.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Versatile,
                Forms = new List<AttackForm> { MeleeAttacks.KillingBlow, MeleeAttacks.OverheadStrike, MeleeAttacks.Slash, MeleeAttacks.Thrust }
            },
            new Weapon
            {
                Name = "Mace",
                Description = "A club-like weapon with a heavy head, often spiked, on a solid shaft.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Brutal,
                Forms = new List<AttackForm> { MeleeAttacks.Bash, MeleeAttacks.Disarm, MeleeAttacks.GuardBreak }
            },
            new Weapon
            {
                Name = "Rapier",
                Description = "A slender, sharply pointed sword designed primarily for thrusting.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Swift,
                Forms = new List<AttackForm> { MeleeAttacks.KillingBlow, MeleeAttacks.Disarm, MeleeAttacks.Thrust }
            },
            new Weapon
            {
                Name = "Sabre",
                Description = "A curved, single-edged sword with a slender blade.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Swift,
                Forms = new List<AttackForm> { MeleeAttacks.Cleave, MeleeAttacks.Slash, MeleeAttacks.OverheadStrike }
            },
            new Weapon
            {
                Name = "Shortsword",
                Description = "A lightweight, one-handed sword optimized for close-quarters combat.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Light,
                Forms = new List<AttackForm> { MeleeAttacks.Bash, MeleeAttacks.Cleave, MeleeAttacks.Disarm }
            },
            new Weapon
            {
                Name = "Trident",
                Description = "A three-pronged spear, traditionally used for fishing and in gladiatorial combat.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Sundering,
                Forms = new List<AttackForm> { MeleeAttacks.KillingBlow, MeleeAttacks.Thrust, MeleeAttacks.Throw }
            },
            new Weapon
            {
                Name = "War-pick",
                Description = "A long-handled weapon with a pointed spike, effective at penetrating armor.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Sundering,
                Forms = new List<AttackForm> { MeleeAttacks.KillingBlow, MeleeAttacks.OverheadStrike, MeleeAttacks.Thrust }
            },
            new Weapon
            {
                Name = "Whip",
                Description = "A long, flexible weapon designed to strike or entangle with a quick, lashing motion.",
                Type = WeaponType.OneHanded,
                Design = WeaponDesign.Reaching,
                Forms = new List<AttackForm> { MeleeAttacks.Disarm, MeleeAttacks.Slash, MeleeAttacks.Trip }
            }
        };

        public List<Weapon> TwoHandedWeapons = new List<Weapon>
        {
            new Weapon
            {
                Name = "Greatsword",
                Description = "A large",
                Type = WeaponType.TwoHanded,
                Design = WeaponDesign.Heavy,
                Forms = new List<AttackForm> { MeleeAttacks.Bash, MeleeAttacks.Cleave, MeleeAttacks.Disarm }
            }
        };

        public List<Weapon> RangedWeapons = new List<Weapon>
        {
            new Weapon
            {
                Name = "Bow",
                Description = "A long",
                Type = WeaponType.Ranged,
                Design = WeaponDesign.Flexible,
                Forms = new List<AttackForm> { MeleeAttacks.Bash, MeleeAttacks.Cleave, MeleeAttacks.Disarm }
            }
        };

        public List<Weapon> MagicWeapons = new List<Weapon>
        {
            new Weapon
            {
                Name = "Wand",
                Description = "A slender twig which allows for easy handling.",
                Type = WeaponType.Magic,
                Design = WeaponDesign.Light,
                Forms = new List<AttackForm> { SpellAttacks.Bolt, SpellAttacks.Ward }
            },
            new Weapon
            {
                Name = "Staff",
                Description = "A cumbersome branch that can summon tremendous amounts of magics.",
                Type = WeaponType.Magic,
                Design = WeaponDesign.Heavy,
                Forms = new List<AttackForm> { SpellAttacks.Bolt, SpellAttacks.Ward, SpellAttacks.Wave }
            }
        };

        public List<Weapon> ExoticWeapons = new List<Weapon>
        {
            new Weapon
            {
                Name = "Scythe",
                Description = "A large",
                Type = WeaponType.Exotic,
                Design = WeaponDesign.Reaching,
                Forms = new List<AttackForm> { MeleeAttacks.Bash, MeleeAttacks.Cleave, MeleeAttacks.Disarm }
            }
        };
    }
}
