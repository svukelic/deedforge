namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Witch = new Profession
        {
            Name = "Witch",
            Order = 53,
            ImageUrl = "images/professions/witch.png",
            Description1 = "Witches are enigmatic spellcasters who draw upon the hidden forces of the natural world and ancient rituals to wield powerful and sometimes eerie magic. Within an adventuring party, their role is that of the mystical and versatile caster, often walking the fine line between light and dark magic. Witches possess a deep understanding of herbs, potions, and incantations, which allows them to brew elixirs, concoct curses, and cast spells that manipulate the elements and fate itself. Their spellbook is a grimoire of arcane knowledge that extends beyond the conventional boundaries of wizardry, delving into the realms of the supernatural and the unknown.",
            Description2 = "In the heat of battle, a Witch can be a mesmerizing and fearsome presence. They might chant incantations that call forth swirling storms or twist the threads of destiny to ensnare their foes in ethereal snares. Some witches have been known to brew potions that heal wounds or enhance the abilities of their allies, while others are experts in hexes that weaken and confound their enemies. When the situation takes a dire turn, a Witch can summon the spirits of nature to come to their aid, manifesting as spectral familiars or spectral creatures that can strike terror into the hearts of their adversaries. While their spells are diverse and potent, Witches often face scrutiny and suspicion due to their association with the mysterious and uncanny, but their knowledge and abilities make them an indispensable asset to any party daring to traverse the realms of magic and the unknown.",
            GrantedSkills = "",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Harbinger of Curses",
                Description = "You have Upper Hand on all Spellcasting checks when casting a Spell against a target that is currently afflicted by your Hex action.<br /><br />Additionally, you ignore requirements for Hexxer Improvement Traits, allowing you to take any number of them as your Traits should you wish."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Spirit Familiar",
                Description = "You have a magical connection with a Spirit Familiar, which is a Critter of your choice. The Spirit Familiar follows Companion rules.<br /><br />Should your Spirit Familiar ever be killed, it comes back to life during your next Rest. The Familiar knows all languages that you know, possesses all Knowledge that you also possess, and gains a Skill Boost in an Intellect Skill of your choice for each Proficiency Tier you have in your Spellcasting Skill.<br /><br />Additionally, you can also telepathically perceive anything that your Familiar perceives, and whenever you cast a Spell or use Hex action, you can choose to do so originating from your Familiar."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Witch's Cauldron",
                Description = "You have access to a magical Cauldron, which you store in an extra-dimensional space and can conjure to your location whenever you start a Rest.<br /><br />For each Proficiency Tier you have in your Spellcasting Skill, you learn two Crafting Recipes. These Recipes must be related to Alchemy, Cooking or Herbalism Skills. When crafting these Recipes, you use your Spellcasting Skill Proficiency Tier to determine the number of Progress Points you gain, and you immediately produce a number of the items equal to the amount of Progress Points you would usually earn when taking Craft Rest Action."
            }
        };
    }
}
