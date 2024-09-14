namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession MysticKnight = new Profession
        {
            Name = "Mystic Knight",
            Order = 93,
            ImageUrl = "images/professions/mystic-knight.png",
            Description1 = "The Mystic Knight is a formidable presence on the battlefield, clad in imposing armor and wielding a weapon infused with potent magic. Their role in an adventuring party is that of a versatile frontline fighter and spellcaster, seamlessly blending martial prowess with arcane or divine magic. At the core of their abilities lies the capacity to draw upon specific types of magic, be it holy light, arcane energy, elemental fury, or other mystical forces. This unique connection allows them to infuse their attacks with the chosen magic, turning every swing of their weapon into a devastating display of both physical and magical might.",
            Description2 = "In a party, the Mystic Knight stands as the guardian of their allies, using their enchanted armor to absorb blows and their magically-infused weapon to mete out righteous retribution. They can protect their comrades with powerful defensive spells, erecting protective barriers or healing wounds in the heat of battle. At the same time, they are a force to be reckoned with on the offensive, their attacks searing through enemy lines with the fury of their chosen magic. A Mystic Knight specializing in holy magic might smite undead foes with radiant power, while one attuned to elemental magic could call forth flames to engulf their weapon and immolate their adversaries. Their versatility makes them indispensable in a party, capable of adapting to a wide range of threats and providing both magical and martial support to ensure victory in the most challenging of encounters.",
            GrantedSkills = "Trained in Charisma",
            Limitations = "Choose one Spell Category (Arcane, Elemental, Holy, Nature, Dark or Eldritch) when taking this Profession. You can only cast Spells from that Category, which is referred to as your Mystic Source.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Mystic Harbinger",
                Description = "You know three Spells of your choice, which must be of Category same as your Mystic Source. You use your Charisma Attribute as your Spellcasting Skill.<br /><br />Peril Rating for these Spells is halved for you."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Preternatural Personality",
                Description = "While in a Social Encounter, whenever you succeed on a contested Charisma Skill check, you inflict the other creature involved in the contested check with a Status which lasts until the end of their next turn. The specific Status depends on the Skill you used for the contested check."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Otherworldly Blessing",
                Description = "You gain Bestow Otherworldly Resistance Rest Action.<br /><br />When you take Bestow Otherworldly Resistance Rest Action, you spend part of your Rest performing a magical ritual which bestows a blessing upon your entire party.<br /><br />All members of your party taking a Rest alongside you immediately lose one Injury and gain Resistance which lasts until your next Rest. The damage type of both the Injury which can be cured and the Resistance granted depend on your Mystic Source."
            }
        };
    }
}
