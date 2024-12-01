namespace Deedforge.Domain.CoreRules.Statuses
{
    public class Conditions
    {
        #region Damaging Effects

        public static Status Bleeding = new Status
        {
            Name = "Bleeding",
            Description = "The target is bleeding and will take damage over time.",
            Effect = "Lose 1 Endurance every time a Move action is taken."
        };

        public static Status Burning = new Status
        {
            Name = "Burning",
            Description = "The target is on fire.",
            Effect = "Lose 1 Endurance at the start of the turn."
        };
        #endregion

        #region Physical Impairments

        public static Status Crippled = new Status
        {
            Name = "Crippled",
            Description = "The target has trouble moving.",
            Effect = "Movement Speed is halved."
        };

        public static Status Blinded = new Status
        {
            Name = "Blinded",
            Description = "The target has lost their vision.",
            Effect = "Automatically fail all sight-based checks, including Attack checks."
        };

        public static Status Deafened = new Status
        {
            Name = "Deafened",
            Description = "The target cannot hear.",
            Effect = "Automatically fail all hearing-based checks. Cannot benefit from auditory warnings or communications."
        };

        public static Status Maimed = new Status
        {
            Name = "Maimed",
            Description = "The target has trouble using their arms.",
            Effect = "All actions requiring arms cost 1 additional AP."
        };

        public static Status Pinned = new Status
        {
            Name = "Pinned",
            Description = "The target is pinned down.",
            Effect = "Cannot take Move action. Cannot take any Actions granted by Armor. Attack rolls against Pinned characters have Upper Hand."
        };

        public static Status Prone = new Status
        {
            Name = "Prone",
            Description = "The target is prone.",
            Effect = "Movement Speed is halved. Lower Hand on all Actions granted by Armor. Attack rolls against Prone characters have Upper Hand."
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

        public static Status Staggered = new Status
        {
            Name = "Staggered",
            Description = "The target is unable to react.",
            Effect = "Cannot take any Reaction."
        };

        public static Status Stupefied = new Status
        {
            Name = "Stupefied",
            Description = "The target has trouble collecting their thoughts.",
            Effect = "Lower Hand on all Knowledge Checks."
        };

        #endregion

        #region Skill Impairments

        public static Status Dazed = new Status
        {
            Name = "Dazed",
            Description = "The target is having trouble catching up to events.",
            Effect = "Lower Hand on all Attack checks."
        };

        public static Status Weakened = new Status
        {
            Name = "Weakened",
            Description = "The target's capability in one specific skill is diminished.",
            Effect = "Lower Hand on checks with specific Skill."
        };

        #endregion

        #region Other Effects

        public static Status Distracted = new Status
        {
            Name = "Distracted",
            Description = "The target's attention is diverted.",
            Effect = "Next Attack check against the target has Upper Hand. Unless otherwise specified, the target stops being Distracted when hit or at the start of their turn."
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
            Effect = "All Attack checks against Enraged characters have Upper Hand. Upper Hand on all checks to resist being controlled or emotionally manipulated via magic. If the character's Endurance is less than half of their Maximum Endurance at the start of their turn, they gain 1 Endurance."
        };

        public static Status Frightened = new Status
        {
            Name = "Frightened",
            Description = "The target is overcome with immense fear.",
            Effect = "Cannot willingly move closer to the source of fear. Lower Hand on all Attack checks while the source of fear is in sight."
        };

        public static Status Illuminated = new Status
        {
            Name = "Illuminated",
            Description = "The target is surrounded by intense light.",
            Effect = "Automatically fail Subterfuge checks. Cannot benefit from Invisibility."
        };

        public static Status Pacified = new Status
        {
            Name = "Pacified",
            Description = "The target is unwilling to hurt others.",
            Effect = "Cannot take offensive actions or cast damaging spells. All Influence checks against Pacified characters have Upper Hand."
        };

        public static Status Sickened = new Status
        {
            Name = "Sickened",
            Description = "The target is afflicted with illness.",
            Effect = "Cannot restore Endurance."
        };

        public static Status Taunted = new Status
        {
            Name = "Taunted",
            Description = "The target is driven to assault a specific target.",
            Effect = "Must attack the taunting character if able. Lower Hand on Attack checks against other targets. Lasts until the end of the taunted character's turn."
        };

        #endregion
    }
}
