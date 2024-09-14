namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession DeathKnight = new Profession
        {
            Name = "Death Knight",
            Order = 16,
            ImageUrl = "images/professions/death-knight.png",
            Description1 = "A Death Knight is a sinister warrior who wields dark powers and utilizes them to dominate foes on the battlefield. They are a melee-focused profession that uses fear and intimidation as weapons, often making use of powerful curses, necrotic damage, and debuffs to weaken their enemies. Death Knights also excel at causing chaos in battle, using their abilities to cause confusion among their opponents and create openings for their allies to exploit. They are often seen as the antithesis of the Templar, using their dark powers to further their own interests rather than uphold any code of honor or justice.",
            Description2 = "In a party, a Death Knight can serve as a formidable front-line fighter who can withstand a lot of punishment while dealing out heavy damage. They also bring a unique set of abilities to the table, such as their aura of fear, which can make enemies flee in terror, or their power to inflict debilitating curses that can greatly hinder their foes.",
            GrantedSkills = "Training in Heavy Armor",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Reaper's Piety",
                Description = "You have a pool of d4 dies that represent your Piety. These dies are known as Piety Dies, and the maximum number of these Dies in your pool is equal to Proficiency Tier in your Profession Skill.<br /><br />Whenever a living being dies within Near vicinity of you, you gain 1 Piety Die.<br /><br />With this feature, you gain access to Reaper's Smite.<br /><br />When you attempt to hit an enemy with an attack, you can choose to Smite them by spending and rolling a Piety Die. You add the result of that roll to that Weapon check. If the attack hits, the damage type changes into Profane, and the hit enemy is inflicted with an Imperiled (Profane) Status."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Deathly Presence",
                Description = "You shed an aura of dark presence. Whenever an enemy within Near vicinity of you fails a contested check against you, they gain one level of Exhaustion. The maximum level of Exhaustion that can be inflicted by this feature is equal to twice the Proficiency Tier in your Profession Skill."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Dark Commander",
                Description = "You have an innate ability to sense dark and demonic presence in your vicinity. You feel the presence of any dark or demonic magic or physical entity within Far vicinity of you, although you don't necessarily know their precise location. While in Exploration Encounter, the radius you can sense this presence is equal to Proficiency Tier in your Profession Skill.<br /><br />Unlike normal people, such locations and gatherings of creatures are usually not hostile to you, but rather neutral or even friendly. While Resting in such locations and dark or demonic creatures which are neutral or friendly to you are present, you can treat them as Companions following Horde rules for the duration of the Rest."
            }
        };
    }
}
