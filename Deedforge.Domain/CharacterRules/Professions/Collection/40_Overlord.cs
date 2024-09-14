namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Overlord = new Profession
        {
            Name = "Overlord",
            Order = 40,
            ImageUrl = "images/professions/overlord.png",
            Description1 = "Overlords are formidable leaders on the battlefield, commanding not just the respect but often the fear of those who serve them. In a party, their role is that of a charismatic and strategic mastermind, capable of rallying allies and instilling discipline even in the direst of situations. Armed with both a mastery of martial combat and a natural gift for leadership, Overlords inspire those around them to reach new heights of courage and efficiency.",
            Description2 = "On the battlefield, an Overlord's presence alone can turn the tide of battle. They are skilled in both offense and defense, wielding weapons and armor with unmatched precision. An Overlord's battle cry can bolster the spirits of their comrades, granting them enhanced strength and resilience, while their tactical insight allows them to discern enemy weaknesses and exploit them to devastating effect. Whether leading a charge into the heart of the enemy or coordinating a well-timed retreat, an Overlord's decisions are often the difference between victory and defeat. Beyond combat, their leadership extends to diplomacy and strategy, where they excel in negotiating alliances, navigating political intrigue, and devising cunning plans to overcome even the most insurmountable odds. In a party, an Overlord is the steadfast pillar upon which the group's hopes and victories are built, making them an invaluable asset to any adventuring party.",
            GrantedSkills = "Trained in Intellect or Charisma, Training in Heavy Armor",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Loyal Minions",
                Description = "You have a brigade of Loyal Minions which follow the Companion rules at your disposal.<br /><br />- The number of Loyal Minions you have is equal to the Proficiency Tier in your Profession Skill, and they follow the Horde rules.<br />- Loyal Minions are creatures of Foe Tier 1, Easy Threat Rating, Small size, and must be of Humanoid type.<br />- Loyal Minions know a number of Warrior's Combat Techniques equal to the Proficiency Tier in your Profession Skill.<br />- You can Issue Order to your Loyal Minions twice per turn.<br />- Your Loyal Minions have Bolstered Status on all Attribute Checks against creatures or creatures belonging to an organization for which you have Knowledge about."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Conqueror's Will",
                Description = "Whenever a Combat Encounter ends, the Guide determines which creature, creature kind, or organization was considered to be the dominant enemy participant, or can give you the choice between multiple possible choices.<br /><br />You are considered to have taken Study Rest Action with the chosen enemy participant as the Study Focus."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Tyrant's Path",
                Description = "You relish the chance to impose your prowess upon anyone standing in your way. You gain the following benefits:<br /><br />- When entering a Combat Encounter while in an Exploration Encounter, all enemies are considered to have Weakened Status during the Tactical Round.<br />- All hostile participants have Lower Hand on all checks to spot Ambush prepared by you and your party.<br />- You and your party have Upper Hand on any checks made as part of the Ambush Party Action against any creatures or creatures belonging to an organization for which you have Knowledge about.<br />- When entering a Combat Encounter while in an Exploration Encounter, you are immune to Surprised Status."
            }
        };
    }
}
