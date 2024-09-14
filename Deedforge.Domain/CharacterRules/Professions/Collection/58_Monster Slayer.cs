namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession MonsterSlayer = new Profession
        {
            Name = "Monster Slayer",
            Order = 58,
            ImageUrl = "images/professions/monster-slayer.png",
            Description1 = "The Monster Slayer is a fearless warrior who specializes in hunting down and defeating the most dangerous creatures that threaten the world. In a party, they are the vanguards against supernatural threats, taking on monstrous adversaries with unparalleled skill and determination. Armed with specialized knowledge and combat techniques, Monster Slayers are the group's ultimate protectors against the horrors that lurk in the shadows.",
            Description2 = "Monster Slayers possess an extensive understanding of supernatural creatures, their weaknesses, and their habits. They use this knowledge to track, confront, and ultimately defeat these foes. Whether it's a bloodthirsty vampire, a rampaging werewolf, or an ancient dragon, the Monster Slayer stands unwavering in the face of terror. Their combat skills are honed to perfection, allowing them to strike with precision and deliver devastating blows to their monstrous adversaries. In a party, the Monster Slayer takes on the role of the guardian, ensuring the safety of their companions by eliminating supernatural threats that could otherwise spell doom. They are the experts in the occult and the paranormal, making them indispensable when facing the unknown and the nightmarish.",
            GrantedSkills = "Trained in Reflex",
            Limitations = "The Guide determines which creatures count as \"monsters\" within the setting",
            CombatFeature = new ProfessionFeature
            {
                Name = "Slayer's Art",
                Description = "You roll an additional d4 dice per Size Category difference whenever you forced to make a contested Reflex or Reflex Skill check against a creature larger than you. Maximum number of additional d4 dices you can roll is equal to your Proficiency Tier in Reflex.<br /><br />Additionally, whenever you make a Weapon Attack against a monster for which you have a specific Knowledge, you can use a Reflex Skill for that check. Depending on which Skill you use, the attack gains additional effects:"
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Monstrous Lore",
                Description = "You have an uncanny ability to spot danger. Your Passive Perception DR is increased by an amount equal to your Reflex Proficiency Tier, and all hostile shapeshifters and changelings maintaining a form other than their true form must make a Deception or Subterfuge check while within your line of sight. The check is made against your Passive Perception DR, and on fail you immediately know of presence of said creatures.<br /><br />If you have a specific Knowledge pertaining to that particular creature, you also immediately learn of the creature's type, even if they still maintain a different form."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Tracker of Evil",
                Description = "Whenever you successfully take Map Area or Scout Exploration Actions, you are immediately informed by the Guide whether you notice presence of any monster for which you have specific Knowledge.<br /><br />Additionally, whenever you take Study Rest Action with a specific monster as a Study Focus, you immediately gain that Knowledge, no matter how many Study Points you usually earn when taking the Study Rest Action."
            }
        };
    }
}
