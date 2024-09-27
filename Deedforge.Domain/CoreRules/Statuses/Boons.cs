namespace Deedforge.Domain.CoreRules.Statuses
{
    public class Boons
    {
        public static Status Bolstered = new Status
        {
            Name = "Bolstered",
            Description = "A surge of confidence flows through the character, steadying their hand and sharpening their mind. Their actions feel more assured, as if guided by an unseen force.",
            Effect = "When making any Skill Check, roll Base Die twice and take the higher result."
        };

        public static Status Empowered = new Status
        {
            Name = "Empowered",
            Description = "Raw energy courses through the character's veins, focusing into a singular point of power. Their next action crackles with potential, ready to be unleashed.",
            Effect = "Upper Hand on the next Skill Check with a specific Skill."
        };

        public static Status FleetFooted = new Status
        {
            Name = "Fleet-Footed",
            Description = "The character's feet barely touch the ground as they move with impossible grace and speed. Distance becomes meaningless in the face of their swiftness.",
            Effect = "Can take Move action at the start of the turn at no AP cost."
        };

        public static Status Focused = new Status
        {
            Name = "Focused",
            Description = "Time seems to slow as the character's senses heighten to an uncanny degree. They perceive vulnerabilities in their target with crystal clarity.",
            Effect = "Next attack is done as if the target is Exposed, regardless of their current Endurance."
        };

        public static Status Hastened = new Status
        {
            Name = "Hastened",
            Description = "The world around the character appears to move in slow motion. Their reflexes are supercharged, allowing them to act with preternatural speed.",
            Effect = "Start turn with 1 additional AP."
        };

        public static Status Hidden = new Status
        {
            Name = "Hidden",
            Description = "Shadows cling to the character like a second skin, blurring their outline and masking their presence. They become one with the darkness, a whisper in the night.",
            Effect = "Attack against target against whom you are Hidden is done with Upper Hand. Attacking removes this Boon. Taking Move Action while Hidden prompts a Stealth check."
        };

        public static Status Invisible = new Status
        {
            Name = "Invisible",
            Description = "The character's form shimmers and fades from view, leaving behind only a slight distortion in the air. They move unseen, a ghost among the living.",
            Effect = "Automatically succeed on all Subterfuge checks against targets that do not have Tremor Sensitivity or True Sight. Attacking while Invisible is done with Upper Hand, and also removes this Boon."
        };

        public static Status Mending = new Status
        {
            Name = "Mending",
            Description = "A soft, golden glow envelops the character's body. Their wounds begin to close on their own, flesh knitting together as vitality flows through them like a gentle stream.",
            Effect = "Recover 1 Endurance at the start of the turn."
        };

        public static Status Reinforced = new Status
        {
            Name = "Reinforced",
            Description = "The character's body becomes a bastion of strength, their muscles hardening like steel. Their skin toughens, and they can withstand blows that would fell lesser warriors.",
            Effect = "Maximum Endurance is increased by +2."
        };

        public static Status Unyielding = new Status
        {
            Name = "Unyielding",
            Description = "An indomitable will suffuses the character's being. They become an immovable force, standing firm against any attempt to hinder or move them.",
            Effect = "Immune to Pinned and Stunned, and all knock-back effects."
        };
    }
}
