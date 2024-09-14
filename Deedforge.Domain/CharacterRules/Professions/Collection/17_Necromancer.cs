namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Necromancer = new Profession
        {
            Name = "Necromancer",
            Order = 17,
            ImageUrl = "images/professions/necromancer.png",
            Description1 = "Necromancers are dark magic users who have the power to manipulate death and the undead. They are known for their ability to reanimate corpses and create powerful undead minions to do their bidding. In battle, necromancers can summon skeletons and zombies to fight for them, as well as use powerful spells that can drain life from their enemies. They are also skilled at manipulating the life force of others, and can use their powers to heal themselves or their allies.",
            Description2 = "In a party, a necromancer can provide powerful support by summoning undead minions to fight for the group, allowing them to focus on other tasks. Their power and versatility make them valuable additions to any adventuring group.",
            GrantedSkills = "",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Bound Minions",
                Description = "You gain Bind Minions Rest Action.<br /><br />When you take Bind Minions Rest Action, you spend part of your Rest performing rituals to turn a corpse (or several of them) into creatures that are then considered to be your Bound Minions, which follow the Companion rules.<br /><br />- You can either bind a single creature of Foe Tier equal to Proficiency Tier in your Spellcasting Skill, or a number of creatures of Foe Tier 1 equal to Proficiency Tier in your Spellcasting Skill. In case of latter, those creatures follow Horde rules.<br />- The chosen creatures must be of Easy Threat Rating and must be of Undead, Demon or Eldritch Type.<br />- For the process to take place, you need to have access to a number of corpses equal to the total Foe Tier of the targeted Bound Minions.<br />- Maximum Foe Tier of Bound Minions is equal to Proficiency Tier in your Spellcasting Skill.<br />- When attacking, your Bound Minions can use your Spellcasting Skill instead, unless their own Skill for attacking is already higher.<br />- As part of this Rest Action, you can also unbind from any existing Bound Minions, which harmlessly turn into ashes."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Gravedigger",
                Description = "You gain a special Knowledge (Necromancy). With this Knowledge, you have a supernatural ability to communicate with Undead creatures, no matter which form of communication they usually use.<br /><br />Whenever you need to make any Charisma Skill Check against an Undead, you can instead make a check using your Spellcasting Skill.<br /><br />Additionally, that Knowledge also provides you various info about graves and gravedigging, and allows you to take Raid Graves Rest Action.<br /><br />When you take Raid Graves Rest Action, you spend part of your Rest unearthing a nearby grave or graves.<br /><br />- This Rest Action counts as Work Rest Action and inherits all of its effects.<br />- You must make an Athletics check to determine your success. The Guide decides the Difficulty Rating.<br />- Alternatively, you can instruct your Bound Minion to perform the check instead of you.<br />- On success, in addition to Work benefits, you also gain access to corpses and any potential items they were buried with. The Guide determines the befitting loot."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Undead Servants",
                Description = "Any feature that you have that affects Rest Actions is also applied to your Bound Minions.<br /><br />Your Bound Minions are limited to the following Rest or Exploration Actions: Assist, Fortify Camp, Keep Watch, Work. Any relevant roles made as part of these Actions can be made using your Spellcasting checks instead of the usual Skill checks."
            }
        };
    }
}
