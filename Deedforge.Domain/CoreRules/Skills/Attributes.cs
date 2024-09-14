namespace Deedforge.Domain.CoreRules.Skills
{
    public class Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Attributes
    {
        public static Attribute Fortitude = new Attribute
        {
            Name = "Fortitude",
            Description = "Determines your ability to resist physically restraining effects and effects of exhaustion, as well as your ability to hold your breath."
        };

        public static Attribute Agility = new Attribute
        {
            Name = "Agility",
            Description = "Determines your ability to react quickly and dodge out of the way of danger."
        };

        public static Attribute Intellect = new Attribute
        {
            Name = "Intellect",
            Description = "Determines your ability to resist mentally-debilitating effects."
        };

        public static Attribute Charisma = new Attribute
        {
            Name = "Charisma",
            Description = "Determines your ability to resist effects that would influence or control your behavior and emotions."
        };
    }
}
