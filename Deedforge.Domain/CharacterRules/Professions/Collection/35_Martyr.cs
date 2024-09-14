namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Martyr = new Profession
        {
            Name = "Martyr",
            Order = 35,
            ImageUrl = "images/professions/martyr.png",
            Description1 = "The Martyr is a unique and self-sacrificing figure that draws its power from the wounds and suffering it endures. Their role in a party is that of a resilient and tenacious protector, capable of withstanding incredible amounts of harm and channeling that suffering into potent divine abilities. Martyrs are often seen as both a shield and a beacon of hope, willing to endure excruciating pain and injury to ensure the safety of their comrades.",
            Description2 = "One of the most remarkable aspects of the Martyr's abilities is their capacity to turn their own suffering into divine energy. When wounded in battle, Martyrs can harness that pain to heal themselves or even unleash powerful offensive spells, all while acting as an unyielding bulwark against their enemies. In the darkest of moments, the Martyr stands firm, a symbol of unwavering dedication and a testament to the incredible power that can be drawn from one's own suffering.",
            GrantedSkills = "Trained in Health",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Martyr's Piety",
                Description = "You have a pool of dies that represent your Piety. These dies are known as Piety Dies, and the maximum number of these Dies in your pool is equal to your Proficiency Tier in Health.<br /><br />Whenever you receive a Wound, you gain 1 Piety Die. If you become Heavily Wounded, you gain 1 additional Piety Die.<br /><br />Whenever you use Cleric's Beseech Deity feature, you can spend a Piety Die in order to immediately succeed on the associated Religion check. Additionally, you can also choose to immediately cast the granted Spell at no additional AP cost."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Divine Resolve",
                Description = "While in a Social Encounter, actions done by Hostile Participants targeting you do not add anything to Encounter Complexity.<br /><br />Additionally, also while in a Social Encounter, whenever you are forced to make a contested check and you succeed, you have Upper Hand on the next check against the source of the original contested check."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Benevolent Sacrifice",
                Description = "You gain Benevolent Sacrifice Rest Action.<br /><br />When you take Benevolent Sacrifice Rest Action, you decide to take suffering of your party members onto yourself.<br /><br />Designate any number of party members taking Rest alongside you. For each designated target, you gain 1 Wound and they lose 2 Wounds."
            }
        };
    }
}
