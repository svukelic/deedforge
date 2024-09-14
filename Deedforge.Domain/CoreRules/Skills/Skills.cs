namespace Deedforge.Domain.CoreRules.Skills
{
    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Attribute GoverningAttribute { get; set; }
    }

    public class Skills
    {
        public static Skill Athletics = new Skill
        {
            Name = "Athletics",
            Description = "Applies knowledge of body mechanics and training techniques to effectively move or lift heavy objects and increase carrying capacity. Understanding of muscle groups and proper form enhances physical performance across various activities.",
            GoverningAttribute = Attributes.Fortitude
        };

        public static Skill Defense = new Skill
        {
            Name = "Defense",
            Description = "Utilizes understanding of armor types, materials, and defensive techniques to effectively protect oneself. Knowledge of weak points in armor and tactical positioning contributes to optimal defense strategies.",
            GoverningAttribute = Attributes.Fortitude
        };

        public static Skill Health = new Skill
        {
            Name = "Health",
            Description = "Encompasses the body's resilience and immune system to maximize Wound capacity and resist various poisons and diseases. Awareness of nutrition, recovery processes, and common toxins bolsters overall physical hardiness.",
            GoverningAttribute = Attributes.Fortitude
        };

        public static Skill PowerWeapons = new Skill
        {
            Name = "Power Weapons",
            Description = "Applies understanding of leverage, momentum, and brute force to effectively wield heavier, strength-based weapons. Knowledge of weapon balance, impact points, and follow-through techniques enhances combat effectiveness with these arms.",
            GoverningAttribute = Attributes.Fortitude
        };

        public static Skill Acrobatics = new Skill
        {
            Name = "Acrobatics",
            Description = "Applies principles of body control and spatial awareness to maintain balance and perform complex physical maneuvers. Knowledge of momentum and center of gravity enhances ability to navigate challenging terrains and execute stunts.",
            GoverningAttribute = Attributes.Agility
        };

        public static Skill Awareness = new Skill
        {
            Name = "Awareness",
            Description = "Utilizes understanding of sensory cues and environmental patterns to maintain vigilance of surroundings. Knowledge of common camouflage techniques and behavioral indicators improves ability to detect hidden or subtle presences.",
            GoverningAttribute = Attributes.Agility
        };

        public static Skill PrecisionWeapons = new Skill
        {
            Name = "Precision Weapons",
            Description = "Employs knowledge of accuracy, timing, and finesse to effectively use weapons requiring dexterity and careful aim. Understanding of trajectories, wind effects, and subtle body control enhances proficiency with ranged and light melee weapons.",
            GoverningAttribute = Attributes.Agility
        };

        public static Skill Stealth = new Skill
        {
            Name = "Stealth",
            Description = "Employs knowledge of light, shadow, and sound propagation to move undetected and conceal oneself effectively. Understanding of typical patrol patterns and attention spans enhances ability to avoid detection.",
            GoverningAttribute = Attributes.Agility
        };

        public static Skill Trickery = new Skill
        {
            Name = "Trickery",
            Description = "Applies fine motor control and misdirection techniques for sleight of hand, forgery, and trap-setting. Knowledge of common security measures and psychological tendencies aids in concealing objects and creating convincing deceptions.",
            GoverningAttribute = Attributes.Agility
        };

        public static Skill Arcana = new Skill
        {
            Name = "Arcana",
            Description = "Analyzing and manipulating magical forces, utilizing spells and magical items effectively.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill Engineering = new Skill
        {
            Name = "Engineering",
            Description = "Assessing and working with structures, materials, and mechanical systems.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill Forestry = new Skill
        {
            Name = "Forestry",
            Description = "Navigating and utilizing natural environments, as well as possessing knowledge about plants, animals, and various terrains.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill Investigation = new Skill
        {
            Name = "Investigation",
            Description = "Applying forensic techniques and behavioral knowledge to search for clues and form deductions.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill Lore = new Skill
        {
            Name = "Lore",
            Description = "Applying historical knowledge to interpret current events and cultural contexts.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill Medicine = new Skill
        {
            Name = "Medicine",
            Description = "Diagnosing and treating wounds and illnesses using medical knowledge.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill MysticalWeapons = new Skill
        {
            Name = "Mystical Weapons",
            Description = "Applies arcane knowledge and spiritual attunement to effectively wield magic-imbued or inherently magical weapons. Understanding of magical resonances, energy channeling, and metaphysical principles enhances combat prowess with these supernatural arms.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill Occultism = new Skill
        {
            Name = "Occultism",
            Description = "Understanding and manipulating esoteric knowledge, rituals, and supernatural phenomena.",
            GoverningAttribute = Attributes.Intellect
        };

        public static Skill Animals = new Skill
        {
            Name = "Animals",
            Description = "Utilizes knowledge of animal behavior and communication to interact with and influence non-intelligent creatures. Understanding of species-specific body language and needs improves ability to train, calm, or direct animals.",
            GoverningAttribute = Attributes.Charisma
        };

        public static Skill Faith = new Skill
        {
            Name = "Faith",
            Description = "Channels spiritual knowledge and religious doctrine to interpret divine signs and interact with religious institutions. Understanding of theological concepts and ritualistic practices enhances ability to draw upon divine inspiration or influence.",
            GoverningAttribute = Attributes.Charisma
        };

        public static Skill Influence = new Skill
        {
            Name = "Influence",
            Description = "Applies understanding of human psychology and social dynamics to persuade, mislead, or manipulate others. Knowledge of body language, cultural norms, and rhetorical techniques enhances ability to achieve desired outcomes in social interactions.",
            GoverningAttribute = Attributes.Charisma
        };

        public static Skill Insight = new Skill
        {
            Name = "Insight",
            Description = "Utilizes knowledge of behavioral cues and psychological patterns to discern true intentions and detect deception. Understanding of common tells and emotional indicators improves ability to read people and situations accurately.",
            GoverningAttribute = Attributes.Charisma
        };

        public static Skill Intimidation = new Skill
        {
            Name = "Intimidation",
            Description = "Employs knowledge of fear responses and power dynamics to exert influence through threats and implied consequences. Understanding of body language and vocal techniques enhances ability to project an imposing presence.",
            GoverningAttribute = Attributes.Charisma
        };

        public static Skill Performance = new Skill
        {
            Name = "Performance",
            Description = "Applies artistic techniques and cultural knowledge to captivate audiences through various forms of expression. Understanding of crowd psychology and performance theory enhances ability to evoke desired emotional responses.",
            GoverningAttribute = Attributes.Charisma
        };

        public static Skill SymbolicWeapons = new Skill
        {
            Name = "Symbolic Weapons",
            Description = "Harnesses the power of culturally significant or personally meaningful objects to amplify one's charismatic presence and influence. Understanding of symbolism, cultural iconography, and personal totems enhances the wielder's ability to inspire, intimidate, or sway others through the display or use of these charged items.",
            GoverningAttribute = Attributes.Charisma
        };
    }
}
