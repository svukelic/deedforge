namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Revenant = new Profession
        {
            Name = "Revenant",
            Order = 56,
            ImageUrl = "images/professions/revenant.png",
            Description1 = "Revenants are enigmatic figures, caught between the realms of the living and the dead, and they wield ghost-like powers that make them both haunting and formidable. In a party, Revenants take on the role of spectral warriors, using their eerie abilities to protect their comrades, manipulate the environment, and strike fear into the hearts of their enemies. These ghostly powers often stem from a tragic past or a brush with the supernatural, granting them a unique and unsettling connection to the world of spirits.",
            Description2 = "In the midst of battle, Revenants can phase through solid objects, becoming nigh untouchable, and then reemerge to deliver chilling, ethereal strikes to their foes. Beyond combat, Revenants excel at uncovering hidden secrets and interacting with spirits, making them valuable when navigating haunted ruins, deciphering ancient texts, or negotiating with restless souls. With their ability to bridge the gap between life and death, Revenants bring an aura of mystery and power to their party, often serving as both a guardian and a guide in their perilous adventures.",
            GrantedSkills = "Trained in any Charisma Skill",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Ghostwalk",
                Description = "You have an ability to physically manifest your Soul outside of your Body. While in the Ghostwalk, you gain the following effects:<br /><br />- Your Soul is considered to be your character, and your Body follows Companion rules. They both have the same initial statblock (Maximum Wounds, AR, etc.)<br />- The Soul gains the ability to fly, but needs to land at the end of each of its turns. The Soul can also pass through certain walls, as determined by the Guide.<br />- The Soul gains Resistance to Physical damage, while the Body gains Immunity to Psionic damage.<br />- When this feature is activated, the Soul gains an ethereal duplicate of any gear equipped on the Body. This gear cannot be changed or swapped on the Soul for the duration of the Ghostwalk.<br />- Should the Soul become Heavily Wounded, the Ghostwalk immediately ends.<br />- The Soul cannot be further than within Near vicinity from the Body at any time. Should that happen, the Ghostwalk immediately ends.<br />- When the Ghostwalk ends, the Soul and the Body merge together. Any Wounds inflicted on the Soul are ignored and only the Wounds on the Body persist. However, any non-Physical Injuries on Soul persist. Additionally, you must immediately make a Charisma Skill Check of your choice to see whether you suffer a Peril. This Peril has a Peril Rating of 6. When you suffer this Peril, you must roll on Hallowed Injuries table.<br /><br />Additionally, you automatically use this ability whenever you are Heavily Wounded."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Haunt",
                Description = "While in a Social Encounter, you can choose to partially possess a Hostile Participant that you can see.<br /><br />Whenever the possessed creature makes a Skill Check that would add to Encounter's Complexity, you can force them to make a contested Charisma check against your Charisma Skill of your choice. Should the target fail, you inflict them with visions and illusions of your making, causing the result of the Skill Check they made to subtract from the Encounter's Complexity instead of adding to it.<br /><br />You can Haunt only one creature simultaneously."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Ethereal Sight",
                Description = "You gain True Sight.<br /><br />Whenever you take any Exploration or Rest Action, this Sight allows you to immediately see the following things in your vicinity:<br /><br />- Any hidden or concealed Undead creatures.<br />- Any magically-hidden objects or structures."
            }
        };
    }
}
