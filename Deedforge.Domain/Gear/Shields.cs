namespace Deedforge.Domain.Gear
{
    public class Shields
    {
        public static Shield Buckler = new Shield
        {
            Name = "Buckler Shield",
            Description = "A small, lightweight shield designed for quick, agile maneuvers. It is often used for deflecting attacks rather than absorbing them.",
            Grit = 0,
            Property = "While wielding a Buckler Shield alongside a weapon, that weapon is considered to also have <i>Dueling</i> property.\r\nIf the weapon already has the <i>Dueling</i> property, then you have an Upper Hand on <i>Parry</i> checks instead."
        };

        public static Shield Kite = new Shield
        {
            Name = "Kite Shield",
            Description = "A medium-sized shield that offers a balance between protection and maneuverability. It is often used by cavalry and infantry for its versatility.",
            Grit = 2,
            Property = "While wielding a Kite Shield, whenever you take <i>Brace</i> Action, you automatically take <i>Block</i> Reaction against next single attack without expending a Reaction."
        };

        public static Shield Tower = new Shield
        {
            Name = "Tower Shield",
            Description = "A large, heavy shield designed for maximum protection. It covers a significant portion of the body, making it ideal for defensive stances.",
            Grit = 4,
            Property = "While wielding a Tower Shield, you have Lower Hand on all <i>Reflex</i> and <i>Subterfuge</i> checks.\r\n\r\nWhenever you are forced to make a Reflex check against an Area Effect, you can now as a Reaction make a contested Defense check. On a successful check, the Shield absorbs the Damage instead of you and you are unaffected by any additional effect usually incurred by the triggering Area Effect."
        };
    }

    public class Shield
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Grit { get; set; }
        public required string Property { get; set; }
    }
}
