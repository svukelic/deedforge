namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Elementalist = new Profession
        {
            Name = "Elementalist",
            Order = 5,
            ImageUrl = "images/professions/elementalist.png",
            Description1 = "The Elementalist harnesses the power of the elements to cast spells and control the battlefield. With mastery over the forces of nature, an Elementalist can conjure forth devastating lightning bolts, raging fires, icy blasts, and powerful gusts of wind. They are also skilled in manipulating the environment, and can use their spells to create walls of stone or water, cause earthquakes, and alter the terrain in other ways. In combat, an Elementalist is a formidable force, able to control the battlefield and deal massive damage to their foes.",
            Description2 = "The Elementalist's role in a party is typically that of a primary spellcaster, providing powerful magical support to their allies while dealing significant damage to their enemies. They excel at area-of-effect spells, making them a valuable asset in battles against groups of enemies. Their elemental spells also provide utility outside of combat, such as creating bridges over gaps or freezing a body of water to cross. However, an Elementalist's spells often require preparation and can be limited by their chosen element, making them reliant on their party to cover their weaknesses and support them in battle.",
            GrantedSkills = "",
            Limitations = "Can only cast Spells from Elemental Category",
            CombatFeature = new ProfessionFeature
            {
                Name = "Elemental Attunement",
                Description = "You cannot cast any Spell unless you are attuned to that particular Spell Subcategory.<br /><br />You gain Attune to Element action.<br /><br />Attune to Element<br />AP Cost: 1<br />Restriction: –<br />You enter a state of attunement that corresponds to one of four Elemental subcategories: Fire, Ice, Lightning or Acid. While attuned in this manner, you can cast only Spell with subcategory corresponding to your attuned Element. Additionally, whenever you use this Action you also gain Empowered Status (see Status Effects page), which lasts until the end of your next turn or until you cast a Spell.<br /><br />Once attuned, it lasts until the end of your next turn or until you use this Action again."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Friend of the Primordial",
                Description = "You gain a special Knowledge (Elementals). With this Knowledge, you have a supernatural ability to communicate with Elementals, no matter which form of communication they usually use.<br /><br />Additionally, whenever you need to make any Charisma Skill check against an Elemental, you can instead make a check using your Spellcasting Skill."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Elemental Summons",
                Description = "You gain Summon Elemental Majordomo Rest Action.<br /><br />When you take Summon Elemental Majordomo Rest Action, you summon one of the following forms of an Elemental Majordomo to assist you and your party throughout the Rest and which dissipates once their work is done or the Rest is done:<br /><br />- Fire Elemental – Negates all effects of cold Environment and Weather for the duration of the Rest. Additionally all Blacksmithing, Cooking and Trap-making checks over the course of the Rest are done with an Upper Hand.<br />- Earth Elemental – Takes Fortify Camp Rest Action, and uses your Spellcasting Skill for any relevant checks (you choose the specific benefit, no matter which Skill was used for the check). Additionally all Cartwrighting, Herbalism and Woodworking checks over the course of the Rest are done with an Upper Hand.<br />- Water Elemental – Negates all effects of hot Environment and Weather for the duration of the Rest. Additionally all Enchanting, Leatherworking and Shipwrighting checks over the course of the Rest are done with an Upper Hand.<br />- Wind Elemental – Expedites all the Forage Rest Actions and Scout Exploration Actions, granting Bolstered Status on all checks done as part of the listed actions. Additionally all Alchemy, Calligraphy and Gunsmithing checks over the course of the Rest are done with an Upper Hand."
            }
        };
    }
}
