namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Runesmith = new Profession
        {
            Name = "Runesmith",
            Order = 68,
            ImageUrl = "images/professions/runesmith.png",
            Description1 = "The Runesmith is a master of ancient, mystical symbols and inscriptions, wielding the power of runic magic to shape reality. Within a party, they play the role of both arcane scholar and formidable spellcaster. Runesmiths possess the unique ability to inscribe runes onto objects, weapons, and even creatures, infusing them with potent magic. These inscriptions can enhance the strength, speed, or resilience of their allies, or unleash destructive forces upon their enemies. A Runesmith's rune magic is versatile and adaptable, allowing them to adapt to a wide range of situations and challenges.",
            Description2 = "In a party, the Runesmith serves as a versatile support and damage-dealing spellcaster. They can empower their comrades with protective runes, bolstering their defenses and augmenting their combat abilities. When the party faces formidable foes, the Runesmith can inscribe runes of destruction, creating devastating area-of-effect spells or enhancing their own attacks with destructive power. Runesmiths also excel at enchanting items, imbuing weapons with magical properties or enhancing armor with protective runes. They are the party's magical artisans, crafting solutions to both combat and non-combat challenges through their intricate understanding of ancient runes. In times of need, a Runesmith can even invoke the power of ancient, forgotten runes to perform feats of extraordinary magic, whether it's creating barriers of energy, teleporting allies to safety, or summoning arcane creatures to aid in battle. Their mystical expertise and versatile spellcasting make Runesmiths invaluable assets to any adventuring group.",
            GrantedSkills = "Trained in Enchanting",
            Limitations = "Cannot cast Spells except the ones stored in Runestones.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Mystic Power",
                Description = "You must use Enchanting as your Spellcasting Skill.<br /><br />You also have the ability to draw the innate power from the Runestones to their uttermost limits. Whenever you cast a Spell stored in in a Runestone, the Spell is now Empowered to its maximum tier, but not above your Proficiency Tier in Enchanting.<br /><br />Additionally, any attempts to prevent the casting or counter the Spells you cast from Runestones are done with Lower Hand."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Soulbound Stones",
                Description = "You have an innate magical connection to any Runestone you crafted. When a Spell is cast from a Runestone you crafted by someone other than you, you immediately gain insight into the following details:<br /><br />- Vague knowledge of the identity of the Runestone's user.<br />- General direction and distance of the user from your location.<br />- General emotional state of the user.<br /><br />Additionally, the magical charge in any Runestone you have crafted can be expended by its wielder to send a message of up to 25 words to you or any other wielder of your Runestones. This action counts as if the Spell was cast from a Runestone."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Art of Runes",
                Description = "You automatically learn Crafting Recipe for Magic Weapon (Runestone) when you take this Profession. You also gain a special container which has a Weight of 1 and Capacity equal to three times your Proficiency Tier in Enchanting, and can only store Runestones. Retrieving a Runestone from this container has no AP cost for you.<br /><br />Whenever you take Craft Rest Action to craft Runestones, you immediately produce a number of Runestones equal to the amount of Progress Points you would usually earn when taking Craft Rest Action."
            }
        };
    }
}
