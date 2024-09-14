namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Lancer = new Profession
        {
            Name = "Lancer",
            Order = 26,
            ImageUrl = "images/professions/lancer.png",
            Description1 = "The Lancers are an elite class of warriors who specialize in mounted combat, wielding their lances with unparalleled skill while astride powerful steeds. In a party, they serve as the vanguard, leading charges into the heart of enemy formations and wreaking havoc with their devastating cavalry charges. Lancers are renowned for their exceptional horsemanship, and their symbiotic bond with their mounts allows them to execute unparalleled feats of precision and ferocity on the battlefield.",
            Description2 = "In battle, Lancers are a sight to behold as they thunder across the field on their swift and formidable mounts. Their role is to break through enemy lines, disrupting formations and sowing chaos among their foes. With a lance in hand, they can impale multiple adversaries with a single thrust, sending enemies sprawling and creating openings for their allies to exploit. Whether it's charging headlong into the fray, routing enemy cavalry, or executing precision strikes against high-priority targets, the Lancer's role in a party is to be the relentless force of mounted mayhem, turning the tide of battle with each thunderous charge.",
            GrantedSkills = "Trained in Animal Handling",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Mounted Combatant",
                Description = "You gain a Mount Companion. Mount Companion is a creature of Animal type which follows the Companion and Mount rules.<br /><br />- You choose the form of your Mount Companion whenever you summon it. It must have Easy Threat Rating and Foe Tier equal to or lower than your Proficiency Tier in Animal Handling, and it must have \"Mount\" feature. Alternatively, if your Mount Companion has a form with Foe Tier below your Proficiency Tier in Animal Handling, it instead gains an increase in its Maximum Wounds score equal to the difference between the Foe Tier and Proficiency Tier.<br />- Whenever a magical effect causes you to lose Wound or Injury, your Mount Companion benefits from the same effect.<br />- Your Mount Companion gains two Skill Boosts for each Proficiency Tier you have in Animal Handling. The Skill Boosts can be spent only on Fortitude or Reflex Skills.<br /><br />Additionally, you gain the following benefits:<br /><br />- You can mount or dismount your Mount once per turn when next to it at no AP cost.<br />- You have Bolstered Status to resist being knocked off your Mount.<br />- If you take a Move action while mounted and move up a Vicinity Tier towards an enemy target before using one of your Warrior's Combat Techniques, you have an Upper Hand on any related check."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Honorable Challenge",
                Description = "While in a Social Encounter, you can declare a Hostile Participant that you can see as a Challenged.<br /><br />For the duration of the Encounter, the Challenged cannot initiate contested checks against anyone other than you. Any time the Challenged rolls to add to Encounter's Complexity, the result is halved.<br /><br />You can have only one Challenged simultaneously."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Master of Mounts",
                Description = "Whenever your party rolls a Travel Die to move using mounts or animal-drawn vehicles during an Exploration Encounter, you can roll that Die one more time and take the higher result.<br /><br />Additionally, the number of Rations spent by the animals in your party is reduced by a number equal to your Proficiency Tier in Animal Handling, to a minimum of 1."
            }
        };
    }
}
