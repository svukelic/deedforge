namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession TrophyHunter = new Profession
        {
            Name = "Trophy Hunter",
            Order = 81,
            ImageUrl = "images/professions/trophy-hunter.png",
            Description1 = "Trophy Hunters are consummate trackers and skilled hunters, but they differ from common hunters in their pursuit of the extraordinary. In a party, their role is that of a versatile scout and combat specialist, with a knack for finding rare and powerful creatures to both challenge and harvest. These hunters are driven by their relentless quest for legendary beasts and the trophies they can claim from them. They are known for their extraordinary tracking skills, able to discern the most elusive of tracks and signs, leading their party through treacherous terrains.",
            Description2 = "Trophy Hunters excel at pinpointing the weaknesses of their quarry and exploiting them in combat. Armed with an impressive array of specialized weapons and traps, they can incapacitate and subdue even the most fearsome of creatures. When facing formidable adversaries, Trophy Hunters have a knack for crafting unique ammunition, from poisoned bolts to fire-infused arrows, tailored to exploit their target's vulnerabilities. Their skills are not limited to combat alone, as they often possess extensive knowledge of the natural world, including herbalism and alchemy. In a party, a Trophy Hunter offers unmatched versatility, using their expertise to guide their comrades through the wilderness, neutralize threats, and collect valuable resources from their hunts, all while pursuing the most legendary and awe-inspiring of prey.",
            GrantedSkills = "Trained in Intimidation",
            Limitations = "Cannot cast Spells except through Profession Features",
            CombatFeature = new ProfessionFeature
            {
                Name = "Trophy Harvester",
                Description = "Whenever you participate in a Combat Encounter that included a Unique Foe, at the end of it you can harvest a Trophy from that Foe: a fang, a claw, an entire skull, etc.<br /><br />You can keep a number of Trophies obtained this way equal to three times your Proficiency Tier in Intimidation. You also have a special Trophy Belt, which is an Accessory with Weight of 1. The Trophy Belt is a Container which can hold a number of Trophies equal to your Proficiency Tier in Intimidation.<br /><br />Each Trophy grants you a special Action related to what the slain Foe could do in life. For example, maybe they had a special form of Attack, knew a specific Spell, etc. When harvesting a Trophy, discuss with your Guide which action will be granted by the Trophy.<br /><br />You can only use Trophy Actions of the Trophies equipped on your Trophy Belt, and each Trophy Action can be used only once per Rest. However, you never suffer from any Perils when using these Trophy Actions."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Boogeyman",
                Description = "You have Bolstered Status on all Intimidation checks and you can use Intimidation instead of other Charisma Skills when interacting with a kind of creature of which you have a Unique Foe's Trophy equipped on your Trophy Belt."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Legend-Hunter",
                Description = "You can take Work Rest Action by retelling tales of hunts. You roll either Intimidation or Survival as part of this Rest Action. Whenever you take Work Rest Action, you also gain the following benefits:<br /><br />- You gain information of at least one notable Unique Foe in the immediate region.<br />- You are considered to have taken Study Rest Action with a specific creature kind prominent in the immediate region as the Study Focus."
            }
        };
    }
}
