namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Ritualist = new Profession
        {
            Name = "Ritualist",
            Order = 29,
            ImageUrl = "images/professions/ritualist.png",
            Description1 = "The Ritualist is a mystic practitioner who delves deep into ancient, arcane traditions to harness the power of rituals and incantations. Their role in a party is that of a versatile and enigmatic spellcaster, capable of weaving intricate ceremonies to manipulate the very fabric of reality. Ritualists are often draped in ornate robes adorned with symbolic sigils, and they carry with them an assortment of esoteric tools and components.",
            Description2 = "In the heart of adventure, Ritualists unveil the secrets of their ancient craft. They can perform elaborate ceremonies to summon protective barriers, bind spirits, or unveil hidden truths. For example, they might conduct a ritual to ward against dark forces, creating a protective aura that shields their party from malevolent magic. Ritualists also excel in divination, using mystical rites to scry into the future or decipher cryptic messages. Their spells often involve elaborate incantations, the scattering of sacred herbs, or the arrangement of symbolic objects, making their magic a captivating spectacle to witness. Beyond their mystical prowess, Ritualists play a crucial role in uncovering hidden lore and solving ancient mysteries. They decipher forgotten texts, decipher riddles, and unlock ancient vaults, guiding their party toward the heart of enigmatic quests. With a Ritualist in your group, you gain access to a wellspring of arcane knowledge and a guardian of ancient traditions, ensuring that your party can navigate the most arcane and mystical challenges that lie ahead.",
            GrantedSkills = "",
            Limitations = "Cannot cast any Spells except through the Profession Features",
            CombatFeature = new ProfessionFeature
            {
                Name = "Ceremonial Invoker",
                Description = "You gain Prepare Ritual and Invoke Ritual Actions.<br /><br />Prepare Ritual<br />AP Cost: 1<br />Restriction: –<br /><br />You inscribe a circle of magical runes representing a Spell around your current location. If the Spell has Area Effect property, then the circle matches that Area Effect's size. If it doesn't, then the circle is roughly the width of an average person.<br /><br />These runes last until used or your next Rest, whichever happens first.<br /><br />Invoke Ritual<br />AP Cost: 1 (2 for Spells with Heavy property)<br />Restriction: –<br /><br />You activate one of your runic circles created with your Prepare Ritual Action, causing the chosen Spell to be cast within the area of the circle. This Action can also be taken as a Reaction upon a person entering the circle."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Familiar's Bond",
                Description = "As part of your Rest (no Rest Action needed), you can declare a number of willing party members as your Familiars. This number is equal to Proficiency Tier in your Spellcasting skill.<br /><br />You gain the following benefits:<br /><br />- Whenever you cast a Spell which inflicts any sort of harm in an Area Effect, you can choose to make your Familiars immune to it.<br />- Whenever you cast a Spell which targets yourself, you can choose to bestow the effect upon your Familiars as well.<br />- You can choose to look and listen through any of your Familiar's senses, as long as they are within Far Vicinity. This costs 1 AP if done during a combat Encounter. While using this effect, you cannot see nor hear with your own body. Additionally, while using this effect, you can also use Actions granted to you by your Ceremonial Invoker feature."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Ritualist's Art",
                Description = "You gain Study Spell and Ritual Casting Rest Actions.<br /><br />Study Spell<br />When you take Study Spell Rest Action, you spend a portion of your Rest learning about a specific Spell from either a magic scroll containing that Spell or a fellow spellcaster who knows that Spell. At the end of the Rest, you learn that Spell.<br /><br />You can have a maximum number of Spells learned this way equal to Proficiency Tier in your Spellcasting skill. If you're trying to learn a new Spell while at maximum number of learned Spells, you can choose to replace an existing Spell with a new one.<br /><br />Ritual Casting<br />When you take Ritual Casting Rest Action, you spend a portion of your Rest casting one of your Spells that you know. The chosen Spell must have either Duration or Sustained property.<br /><br />When the chosen Spell is cast this way, it lasts until your next Rest without the need to Sustain it."
            }
        };
    }
}
