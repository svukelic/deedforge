namespace Deedforge.Domain.CoreRules.Attacking
{
    public static class MeleeFightingStyles
    {
        public static FightingStyle BattleDancer = new FightingStyle
        {
            Name = "Battle Dancer",
            Description = "Combines fluid movement and rhythmic attacks, providing mobility and grace in combat, making it easier to dodge attacks and maintain offensive momentum.",
            Properties = new List<string>()
        };

        public static FightingStyle Berserker = new FightingStyle
        {
            Name = "Berserker",
            Description = "Focuses on aggressive, high-damage attacks that overwhelm opponents with sheer brute force, breaking through defenses and causing massive damage.",
            Properties = new List<string>()
        };

        public static FightingStyle DrunkenMaster = new FightingStyle
        {
            Name = "Drunken Master",
            Description = "Utilizes unpredictable movements and unorthodox techniques to confuse and disorient opponents, making attacks difficult to predict and counter.",
            Properties = new List<string>()
        };

        public static FightingStyle Dervish = new FightingStyle
        {
            Name = "Dervish",
            Description = "Focuses on rapid, spinning attacks to strike multiple foes, making it effective at crowd control and dealing with multiple opponents simultaneously.",
            Properties = new List<string>()
        };
    }
}
