namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Summoner = new Profession
        {
            Name = "Summoner",
            Order = 28,
            ImageUrl = "images/professions/summoner.png",
            Description1 = "Summoners are arcane practitioners with the extraordinary ability to conjure powerful beings from other realms to aid them in various tasks. Within a party, they assume the role of summoning and controlling these mystical entities to influence the course of battle, enhance their party's abilities, or accomplish tasks that are otherwise impossible. Armed with a deep knowledge of arcane rituals and the wisdom to choose the right summonings for each situation, Summoners are both versatile and strategic assets to their adventuring groups.",
            Description2 = "In the heat of battle, Summoners can call forth an array of creatures, from fire-spewing elementals to ethereal spirits and mighty demons. These summoned beings heed the Summoner's commands, unleashing devastating attacks, defending their allies, or even providing valuable information with their unique abilities. Beyond combat, Summoners excel at solving complex problems by using their summoned creatures' diverse skill sets, such as using a water elemental to douse a raging inferno or calling upon a celestial being to aid in negotiations with otherworldly entities. In essence, Summoners are the masters of calling upon the supernatural to bolster their party's strength and navigate the myriad challenges of their adventures.",
            GrantedSkills = "",
            Limitations = "Cannot wear any Armor, cannot cast any Spells that directly cause Wounds or Injuries",
            CombatFeature = new ProfessionFeature
            {
                Name = "Conjurer's Art",
                Description = "Any creature with \"Summoned\" feature under your control gains the following benefits:<br /><br />- An increase in their AR and Maximum Wounds equal to Proficiency Tier in your Spellcasting Skill.<br />- Can use your Spellcasting Skill for any Skill checks it makes."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Otherworldly Assistance",
                Description = "While in a Social Encounter, your Otherworldly Companion acts as an independent character and has its own turn.<br /><br />The Companion is still under your control, responds to your mental commands and relays anything it hears and sees to you in mental images and vivid details, but cannot move more than Far vicinity from you."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Summoning Ritual",
                Description = "You gain Summoning Ritual Rest Action.<br /><br />When you take Summoning Ritual Rest Action, you summon an otherworldly creature into this world to be your Otherworldly Companion. The creature's type depends on your Archetype:<br /><br />- Wizard – Elemental<br />- Cleric – Celestial<br />- Occultist – Demon or Undead (if you can cast Dark Spells) or Abomination (if you can cast Eldritch Spells)<br /><br />The Otherworldly Companion must have Easy Threat Rating and Foe Tier equal to or lower than your Proficiency Tier in your Spellcasting Skill, and it gains \"Summoned\" feature when bound to you with this effect.<br /><br />You can have one such Otherworldly Companion simultaneously."
            }
        };
    }
}
