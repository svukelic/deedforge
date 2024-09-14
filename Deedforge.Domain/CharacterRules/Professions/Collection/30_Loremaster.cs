namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Loremaster = new Profession
        {
            Name = "Loremaster",
            Order = 30,
            ImageUrl = "images/professions/loremaster.png",
            Description1 = "Loremasters are the living repositories of knowledge, their minds brimming with the secrets of the ages. They possess a profound understanding of ancient texts, arcane lore, and forgotten histories. These scholarly individuals are adept at unraveling mysteries, deciphering cryptic runes, and crafting powerful magical scrolls that can alter the course of destiny. In a party, Loremasters play the vital role of the arcane scholar and support caster, using their extensive wisdom to decipher riddles, identify magical items, and weave intricate spells from their meticulously crafted scrolls.",
            Description2 = "One of the most extraordinary abilities of a Loremaster is their talent for creating magical scrolls. They can transcribe spells and arcane knowledge onto parchment, turning them into portable and often disposable forms of spellcasting. This ability allows them to provide a diverse range of magical support to their party, from casting protective wards to unleashing devastating spells, all without depleting their own magical reserves. Furthermore, Loremasters are walking encyclopedias of lore and history, making them invaluable when solving puzzles, deciphering ancient scripts, or negotiating with creatures from other planes of existence. With their profound wisdom and unparalleled access to arcane knowledge, Loremasters are the guardians of forgotten secrets and the architects of arcane might in any adventuring party.",
            GrantedSkills = "Trained in Calligraphy",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Arcane Fundamentals",
                Description = "Whenever you cast a Spell (including when casting it from a Magic Scroll), you can choose to invoke one of the following benefits:<br /><br />- If the Spell inflicts Wounds, you can change its damage type to any other damage type<br />- If the Spell is Self-targeted, you can instead choose as a target a willing character within Near vicinity that you can see.<br /><br />Additionally, when casting a Spell from a Magic Scroll, Peril Rating is halved."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Living Repository",
                Description = "For each Proficiency Tier you have in any Intellect Skill, you gain an additional Knowledge corresponding to that Skill's domain (e.g. Veteran in Arcana means you gain three pieces of Knowledge that must be related to magic or spellcasting)."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Scroll-Maker",
                Description = "You gain Craft Magic Scroll Rest Action.<br /><br />When you take Craft Magic Scroll Rest Action, you create a Magic Scroll imbued with a Spell. In order for a Spell to be imbued into a Magic Scroll, one of the following conditions needs to be satisfied:<br /><br />- You have seen the Spell being cast since your last Rest.<br />- You know and can cast the Spell yourself.<br />- One of your party members taking the Rest alongside you knows and can cast the Spell."
            }
        };
    }
}
