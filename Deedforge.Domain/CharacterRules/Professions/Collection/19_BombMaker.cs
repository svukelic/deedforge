namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession BombMaker = new Profession
        {
            Name = "Bomb Maker",
            Order = 19,
            ImageUrl = "images/professions/bomb-maker.png",
            Description1 = "Bomb Makers are skilled alchemists and engineers who specialize in creating explosive devices of all shapes and sizes. They are able to craft bombs that can deal devastating damage to enemies, destroy structures, and create distractions to aid in escapes.",
            Description2 = "In a party, Bomb Makers are invaluable for their ability to deal significant damage and control the battlefield. They can create explosive traps to defend areas, provide cover fire, or even take out entire groups of enemies with a well-placed bomb. Their knowledge of chemistry also makes them useful for gathering information, as they can analyze substances and identify their properties. However, Bomb Makers must be careful not to cause collateral damage or harm their own allies with their explosive devices.",
            GrantedSkills = "Arcana or Technology",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Imbue Bombs",
                Description = "When throwing one of your Bombs, you can spend one additional AP to imbue that Bomb with an additional effect from the following list:<br /><br />- Shrapnel – All enemies within the radius of the Bomb's explosion must make a Fortitude check contested by your Profession Skill check. If they fail, they gain Crippled Status until the end of their next turn.<br />- Flashbang – All enemies within the radius of the Bomb's explosion must make a Fortitude check contested by your Profession Skill check. If they fail, they gain Blinded Status until the end of their next turn.<br />- Incendiary – All enemies within the radius of the Bomb's explosion must make a Fortitude check contested by your Profession Skill check. If they fail, they gain Imperiled (Fire) Status."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Demolisher",
                Description = "Whenever you explode your Bomb while in a Social Encounter, all characters (other than your party members) within Near vicinity of the explosion gain Frightened Status.<br /><br />Additionally, you gain a special Knowledge (Demolition). With this Knowledge, you have detailed know-how on how to bring down and destroy buildings and large objects, as well how to use various explosives and explosive devices."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Bomb Maker's Craft",
                Description = "You gain Craft Bombs Rest Action.<br /><br />When you take Craft Bombs Rest Action, you spend part of your Rest crafting a set of Bombs. The number of Bombs you craft this way is equal to four times the Proficiency Tier in your Profession Skill. If you take this Rest Action while still having Bombs from previous Rest, they fall apart harmlessly.<br /><br />Your Bombs are considered to be Light Throwable Objects. The Bombs do not explode on their own. When using or throwing one, you can light it up by spending 1 AP, or you can throw it unlit. When a Bomb is thrown while lit, or shot with a Firearm or Magic Weapon while unlit, it explodes.<br /><br />The Bomb explosion is considered to be an Area Effect within Melee vicinity of the impact location. All creatures within the area of explosion gain 1 Wound, in addition to any other effects the Bomb may incur."
            }
        };
    }
}
