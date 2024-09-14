namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession BeastTamer = new Profession
        {
            Name = "Beast Tamer",
            Order = 13,
            ImageUrl = "images/professions/beast-tamer.png",
            Description1 = "Beast Tamers are skilled at training and commanding various creatures, like wolves and tigers. They often form close bonds with their animal companions and use them in battle to devastating effect. Beast Tamers are usually able to communicate with their animals through some sort of telepathic bond, which allows for a deeper understanding and coordination between them. They also possess a wide range of abilities that allow them to tame, train, and even heal their animal companions. In combat, Beast Tamers can use their animals to attack enemies from afar, distract opponents, or even draw aggro away from other party members. Additionally, they can use their unique abilities to enhance their animal companions, making them stronger and more resilient.",
            Description2 = "Beast Tamers perform powerful two-pronged attacks alongside their companions. They can also use their animal companions to scout ahead, track down enemies, or even detect hidden traps or ambushes. Their role in the party is often that of a versatile support, able to provide a wide range of benefits to their animal companions and party members alike. In addition, they can also provide valuable reconnaissance and utility to the party, making them a valuable asset both in and out of combat.",
            GrantedSkills = "Trained in Animal Handling",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Beast Companion",
                Description = "You gain a Beast Companion. Beast Companion is a creature of Animal type which follows the Companion rules.<br /><br />- You choose the form of your Beast Companion whenever you summon it. It must have Easy Threat Rating and Foe Tier equal to or lower than your Proficiency Tier in Animal Handling. Alternatively, if your Beast Companion has a form with Foe Tier below your Proficiency Tier in Animal Handling, it instead gains an increase in its Maximum Wounds score equal to the difference between the Foe Tier and Proficiency Tier.<br />- Your Beast Companion inherits all your Archetype features. The Guide may decide if a feature isn't applicable to the Companion.<br />- Whenever a magical effect causes you to lose Wound or Injury, your Beast Companion benefits from the same effect.<br />- Your Beast Companion gains two Skill Boosts for each Proficiency Tier you have in Animal Handling. The Skill Boosts can be spent only on Fortitude or Reflex Skills."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Wild Tongue",
                Description = "You have Upper Hand on all checks to interact with Animals while your Beast Companion is near you.<br /><br />Additionally, you are able to communicate basic concepts and emotions to Animals, and are able to understand them being communicated to you by Animals."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Hunting Team",
                Description = "Any feature that you have that affects Rest Actions is also applied to your Beast Companion.<br /><br />Your Beast Companion is limited to the following Rest or Exploration Actions: Assist, Forage, Keep Watch, Scout. Any relevant roles made as part of these Actions can be made using your Animal Handling checks instead of the usual Skill checks."
            }
        };
    }
}
