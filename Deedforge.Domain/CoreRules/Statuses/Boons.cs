namespace Deedforge.Domain.CoreRules.Statuses
{
    public class Boons
    {
        public static Status Empowered = new Status
        {
            Name = "Empowered",
            Description = "A surge of confidence flows through the character, steadying their hand and sharpening their mind. Their actions feel more assured, as if guided by an unseen force.",
            Effect = "Next Skill Check is done with Upper Hand."
        };

        public static Status Hidden = new Status
        {
            Name = "Hidden",
            Description = "Shadows cling to the character like a second skin, blurring their outline and masking their presence. They become one with the darkness, a whisper in the night.",
            Effect = "Attacks while Hidden are done with Upper Hand. Attacking removes this Boon."
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
            Effect = "Immune to Pinned, Prone and Stunned, and all forced movement effects."
        };
    }
}
