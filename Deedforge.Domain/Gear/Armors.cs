namespace Deedforge.Domain.Gear
{
    public class Armors
    {
        public static Armor Light = new Armor
        {
            Name = "Light Armor",
            Description = "A set of armor designed for agility and flexibility, offering minimal protection but allowing for maximum movement and speed.",
            Endurance = 7,
            NumberOfReactions = 3
        };

        public static Armor Medium = new Armor
        {
            Name = "Medium Armor",
            Description = "A set of armor which strikes a balance between protection and mobility. It offers moderate defense without significantly hindering movement.",
            Endurance = 9,
            NumberOfReactions = 2
        };

        public static Armor Heavy = new Armor
        {
            Name = "Heavy Armor",
            Description = "A set of armor built for maximum protection, often at the expense of mobility. It is best suited for absorbing heavy attacks.",
            Endurance = 11,
            NumberOfReactions = 1
        };
    }

    public class Armor
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Endurance { get; set; }
        public required int NumberOfReactions { get; set; }
    }
}
