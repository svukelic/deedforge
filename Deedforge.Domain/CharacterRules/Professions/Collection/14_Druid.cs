namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Druid = new Profession
        {
            Name = "Druid",
            Order = 14,
            ImageUrl = "images/professions/druid.png",
            Description1 = "Druids are powerful spellcasters who draw their magic from the natural world. They have a deep connection to the earth and its creatures, and can call upon the forces of nature to aid them in battle. Additionally, they have the ability to call upon the powers of nature to heal themselves and their allies, making them valuable members of any party.",
            Description2 = "In addition to their magical abilities, druids are also skilled in survival and wilderness lore. They are able to track their prey through dense forests and navigate treacherous terrain with ease. Druids also have a deep understanding of the natural world, and are often called upon to act as stewards of the land, protecting it from those who would seek to exploit it for their own gain. With their combination of magical prowess and wilderness expertise, druids are a force to be reckoned with, and a valuable asset to any adventuring party.",
            GrantedSkills = "Trained in Nature",
            Limitations = "Cannot wear Heavy Armor",
            CombatFeature = new ProfessionFeature
            {
                Name = "Forest Speaker",
                Description = "You have the ability to cast spells, for which you use Nature as a spellcasting skill.<br /><br />You learn spells from Nature category, the number of which you can know is equal to double your Nature Proficiency Tier."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Nature's Blessing",
                Description = "Whenever you target an ally with a Nature Spell, they gain Bolstered Status in one Skill, other than Weapon Skills, of your choice. This Bolstered Status lasts until a check is made in the chosen Skill or until the start of the next Rest, whichever comes first, and a character can benefit from this effect only once per Rest.<br /><br />Additionally, you can use Nature instead of Medicine checks for the purpose of treating Injuries."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Far Traveler",
                Description = "Whenever you spend three Rests in a row in same Environment, you gain Acclimated to that Environment.<br /><br />Whenever you finish a Rest in an Environment you are Acclimated to, you can cast a Nature Spell without interrupting your Rest or suffering from a Peril. If the cast Spell has Sustained property, it now lasts until your next Rest without the need to Sustain it."
            }
        };
    }
}
