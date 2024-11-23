namespace Deedforge.Domain.CoreRules.Statuses
{
    public class Conditions
    {
        public static Status Bleeding = new Status
        {
            Name = "Bleeding",
            Description = "The target is bleeding and will take damage over time.",
            Effect = "Lose 1 Endurance every time a Move or Attack action is taken."
        };

        public static Status Blinded = new Status
        {
            Name = "Blinded",
            Description = "The target has lost their vision.",
            Effect = "Automatically fail all sight-based checks, including Attack rolls."
        };

        public static Status Burning = new Status
        {
            Name = "Burning",
            Description = "The target is on fire.",
            Effect = "Lose 1 Endurance at the start of the turn."
        };

        public static Status Clumsy = new Status
        {
            Name = "Clumsy",
            Description = "The target has poor motor control.",
            Effect = "Lower Hand on all Agility and Charisma checks."
        };

        public static Status Confused = new Status
        {
            Name = "Confused",
            Description = "The target has difficulty distinguishing reality.",
            Effect = "Lower Hand on all Awareness and Insight checks."
        };

        public static Status Crippled = new Status
        {
            Name = "Crippled",
            Description = "The target has trouble moving.",
            Effect = "Movement Speed is halved."
        };

        public static Status Dazed = new Status
        {
            Name = "Dazed",
            Description = "The target is having trouble catching up to events.",
            Effect = "Lower Hand on all rolls."
        };

        public static Status Deafened = new Status
        {
            Name = "Deafened",
            Description = "The target cannot hear.",
            Effect = "Automatically fail all hearing-based checks. Cannot benefit from auditory warnings or communications."
        };

        public static Status Distracted = new Status
        {
            Name = "Distracted",
            Description = "The target's attention is diverted.",
            Effect = "Result of the next Execution Roll against the target is increased by one Tier. Unless otherwise specified, the target stops being Distracted when hit or at the start of their turn."
        };

        public static Status Drenched = new Status
        {
            Name = "Drenched",
            Description = "The target is soaked with water.",
            Effect = "Resistance to Fire Damage. Vulnerability to Ice and Lightning Damage."
        };

        public static Status Enraged = new Status
        {
            Name = "Enraged",
            Description = "The target has difficulty controlling their actions.",
            Effect = "Vulnerability to all Damage. Upper Hand on all checks to resist being controlled or emotionally manipulated via magic. If the character's Endurace is less than half of their Maximum Endurance at the start of their turn, they gain 1 Endurance."
        };

        public static Status Fatigued = new Status
        {
            Name = "Fatigued",
            Description = "The target is under physical duress.",
            Effect = "Lower Hand on all Fortitude checks."
        };

        public static Status Frightened = new Status
        {
            Name = "Frightened",
            Description = "The target is overcome with immense fear.",
            Effect = "Cannot willingly move closer to the source of fear. Lower Hand on all Attack rolls while the source of fear is in sight."
        };

        public static Status Illuminated = new Status
        {
            Name = "Illuminated",
            Description = "The target is surrounded by intense light.",
            Effect = "Automatically fail Subterfuge checks. Cannot benefit from Invisibility."
        };

        public static Status Maimed = new Status
        {
            Name = "Maimed",
            Description = "The target has trouble using their arms.",
            Effect = "All actions requiring arms cost 1 additional AP."
        };

        public static Status Pacified = new Status
        {
            Name = "Pacified",
            Description = "The target is unwilling to hurt others.",
            Effect = "Cannot take offensive actions or cast damaging spells. All Influence checks against Pacified characters have Upper Hand."
        };

        public static Status Pinned = new Status
        {
            Name = "Pinned",
            Description = "The target is pinned down.",
            Effect = "Movement Speed becomes 0. Cannot take any Armor action. Attack rolls against Pinned characters have Upper Hand."
        };

        public static Status Prone = new Status
        {
            Name = "Prone",
            Description = "The target is prone.",
            Effect = "Movement Speed is halved. Lower Hand on all Armor actions. Attack rolls against Prone characters have Upper Hand."
        };

        public static Status Sickened = new Status
        {
            Name = "Sickened",
            Description = "The target is afflicted with illness.",
            Effect = "Cannot restore Endurance."
        };

        public static Status Silenced = new Status
        {
            Name = "Silenced",
            Description = "The target's ability to use magic is inhibited.",
            Effect = "Cannot use the Cast Spell or Invoke Spell actions. Automatically fail any check that requires speaking."
        };

        public static Status Slowed = new Status
        {
            Name = "Slowed",
            Description = "The target is experiencing lethargy.",
            Effect = "Start your turn with 1 fewer AP."
        };

        public static Status Stunned = new Status
        {
            Name = "Stunned",
            Description = "The target is unable to act.",
            Effect = "Start your turn with 0 AP and 1 fewer Reaction."
        };

        public static Status Stupefied = new Status
        {
            Name = "Stupefied",
            Description = "The target has issues collecting their thoughts.",
            Effect = "Lower Hand on all Intellect checks."
        };

        public static Status Taunted = new Status
        {
            Name = "Taunted",
            Description = "The target is driven to assault a specific target.",
            Effect = "Must attack the taunting creature if able. Lower Hand on attack rolls against other targets."
        };
    }
}
