namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Priest = new Profession
        {
            Name = "Priest",
            Order = 11,
            ImageUrl = "images/professions/priest.png",
            Description1 = "Priests are holy warriors who dedicate their lives to serving their deity and spreading their faith. They are powerful healers and can use divine magic to bless their allies and smite their enemies. Priests often serve as spiritual leaders in their communities and are looked up to for their wisdom and guidance. Their primary role in a party is to provide support through healing and buffing spells, and to assist in combat through offensive spells and turning undead.",
            Description2 = "In combat, priests use their divine magic to heal their allies and damage their enemies. They can also use their spells to create barriers or summon celestial creatures to fight for them. Outside of combat, priests can use their abilities to detect evil, bless items, and perform rituals such as weddings or funerals. Overall, the priest is a versatile and essential member of any party, providing both spiritual guidance and powerful magic to aid their allies.",
            GrantedSkills = "",
            Limitations = "Cannot wear Medium or Heavy Armor",
            CombatFeature = new ProfessionFeature
            {
                Name = "Divine Conduit",
                Description = "You have the ability to cast spells, for which you use Religion as a spellcasting skill.<br /><br />You learn spells from Holy category, the number of which you can know is equal to double your Religion Proficiency Tier."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Holy Reverence",
                Description = "You don't suffer from Perils when casting Spells that do not inflict Wounds or Injuries while in a Social Encounter."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Inspiration of the Faithful",
                Description = "You and anyone who starts a Rest alongside you immediately loses 1 Wound and recovers from one level of Exhaustion.<br /><br />Additionally, when you use your Prayer Rest Action granted by the Cleric Archetype, you can now ask for Redemption instead:<br /><br />- Redemption – You ask your deity to tell you how to save your companions. Designate a member of your party who is suffering from a permanent Injury, Curse and/or Cursed Item. Make a Religion check, for which GM determines Difficulty Rating depending on severity of the afflictions. On a successful check, conditions needed to treat the affliction are considered to be magically satisfied."
            }
        };
    }
}
