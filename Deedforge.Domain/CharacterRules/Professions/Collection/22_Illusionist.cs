namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Illusionist = new Profession
        {
            Name = "Illusionist",
            Order = 22,
            ImageUrl = "images/professions/illusionist.png",
            Description1 = "The Illusionist is a master of deception and misdirection, wielding the arcane arts to create illusions that confound the senses and manipulate reality itself. In a party, they play the role of the trickster and strategist, using their spells to outwit adversaries and control the battlefield. Illusionists are skilled in crafting lifelike illusions that can make allies appear as fearsome foes or render themselves invisible to the enemy's eyes. They can conjure illusory barriers to shield their allies from harm or create phantom threats to divert enemy attention.",
            Description2 = "In the heat of battle, an Illusionist's abilities are nothing short of magical artistry. They can make entire armies believe they're facing insurmountable odds or turn a treacherous battlefield into a confusing maze of shifting images. Their illusions can sow discord among enemy ranks, causing chaos and disarray. Beyond combat, Illusionists are also valuable in espionage and diplomacy, as they can disguise themselves or others and manipulate perceptions to achieve their objectives. When you have an Illusionist in your party, expect the unexpected, for they are the puppeteers of reality, pulling the strings from behind the scenes to secure victory through cleverly woven illusions and enchantments.",
            GrantedSkills = "",
            Limitations = "Cannot wear any Armor",
            CombatFeature = new ProfessionFeature
            {
                Name = "Master of Mirages",
                Description = "You have the ability to conjure Mirages of yourself and your allies in order to confuse your enemies.<br /><br />Whenever an enemy attacks you or an ally of yours within Near vicinity, you can as a Reaction conjure a Mirage with the likeness of attack's target. The attacking enemy needs to make a Perception or Investigation check contested by your Profession Skill check. If they fail, the attack is redirected towards the Mirage.<br /><br />A Mirage has 1 Maximum Wound and an AR equal to the AR of the character it copied its likeness from. If a redirected attack fails to hit the Mirage, the Mirage persists until the end of the Encounter (or for the next 10 minutes, whichever comes first). An enemy is under no compulsion to attack a Mirage, although they first need to make a Perception or Investigation check contested by your Profession Skill check if they want to discern which target is a Mirage and which one is a real character. You can also take Issue Order action and target all of your active Mirages, but the only Action they can take it Move.<br /><br />Additionally, whenever you are casting a Wizard Spell or using a Psionic Discipline, you can choose to make it originate from one of your Mirages location instead."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Mindscape Theater",
                Description = "While in a Social Encounter, whenever a Hostile Participant fails a contested check against you or an ally of yours within Near vicinity of you, you subtract the triggering roll result from the current Encounter Complexity.<br /><br />Additionally, whenever you are making a Subterfuge check, you can instead make a check with your Profession skill."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Shrouded Presence",
                Description = "You are able to weave illusions around your party whenever you are traveling. You gain the following benefits:<br /><br />- Whenever the party takes Travel or March Party Action, you can make Skill check with your Profession Skill against the Exploration DR. On success, your party gains the benefits of the Sneak Party Action.<br />- Whenever Hostile Participant in an Exploration Encounter try to track you and your Party, you can make them roll their checks contested against your Profession Skill check. On fail, Hostile Participants completely lose your party tracks, and potentially even get lost. The Guide determines the details of this situation."
            }
        };
    }
}
