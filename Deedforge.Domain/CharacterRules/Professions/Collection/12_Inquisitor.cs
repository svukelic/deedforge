namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Inquisitor = new Profession
        {
            Name = "Inquisitor",
            Order = 12,
            ImageUrl = "images/professions/inquisitor.png",
            Description1 = "In the echoing halls of a heretic's hideout, or the shadowy corners of a demon-infested ruin, the Inquisitor stands as a beacon of truth and justice. They are the relentless seekers, the divine detectives who root out corruption and evil with unwavering determination. With a holy symbol in one hand and a weapon in the other, an Inquisitor is a formidable force against the forces of darkness. They might confront a cult leader in his own lair, their words of condemnation ringing out as they dispel illusions and reveal the truth, or stand firm against a horde of the undead, their holy symbol shining with divine light that sends the creatures recoiling.",
            Description2 = "But an Inquisitor's role in a party extends beyond their ability to confront and combat evil. With their deep knowledge of religion, arcane lore, and the supernatural, they can identify cursed objects, decipher ancient religious texts, or detect the presence of otherworldly entities. In a haunted castle, they might be the one to identify the nature of the ghostly inhabitant and find a way to lay it to rest. In a negotiation with a celestial being, they could be the one to step forward, using their knowledge of celestial hierarchies and customs to guide the conversation. In essence, the Inquisitor is the light in the darkness, the relentless seeker of truth, and the stalwart defender against the forces of evil.",
            GrantedSkills = "Trained in Charisma",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Inquisitor's Piety",
                Description = "You have a pool of d4 dies that represent your Piety. These dies are known as Piety Dies, and the maximum number of these Dies in your pool is equal to your Proficiency Tier in Religion.<br /><br />Whenever you hit an enemy with a Weapon attack, you gain 1 Piety Die.<br /><br />With this feature, you gain access to Fiery Smite.<br /><br />When you attempt to hit an enemy with an attack, you can choose to Smite them by spending and rolling a Piety Die. You add the result of that roll to that Weapon check. If the attack hits, the damage type changes into Fire, which also ignores any Resistance to Fire."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Hunter of Sins",
                Description = "Whenever you succeed on an Insight check while in a Social Encounter, the target also briefly becomes terrified of you, gaining Frightened Status.<br /><br />Additionally, you immediately gain innate knowledge of the general nature, but not necessarily the details, of any major sins or evil acts that the people you Frightened have committed."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Nobody Expects the Inquisition",
                Description = "You have an innate ability to sense dark and demonic presence in your vicinity. You feel the presence of any dark or demonic magic or physical entity within Far vicinity of you, although you don't necessarily know their precise location.<br /><br />Whenever you take Scout Exploration Action, you can instead make a Religion check. On success, you gain the usual benefits of the action, as well as gain insight into direction of any powerful dark or demonic presence within a specific radius from the party. That radius is number hexes equal to your Proficiency Tier in Religion Skill."
            }
        };
    }
}
