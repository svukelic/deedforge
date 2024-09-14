namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Shaman = new Profession
        {
            Name = "Shaman",
            Order = 45,
            ImageUrl = "images/professions/shaman.png",
            Description1 = "Shamans are mystical practitioners deeply rooted in the ancient traditions of herbalism and spiritual communion. They harness the power of nature through their profound understanding of plants and their potent visions. In a party, Shamans play the roles of healers, mystics, and spellcasters, offering a unique blend of curative abilities and magical prowess.",
            Description2 = "Shamans can induce visions that reveal hidden truths. Through their vision quests, they can see glimpses of the past, present, and future, offering valuable insights to their comrades. In dire circumstances, a Shaman might brew a potion that grants them the power to briefly step into the spirit world, becoming intangible and immune to harm. Their role in a party is one of versatile support and mystical guidance. They offer vital healing and protective spells, uncover hidden secrets, and tap into the primal forces of nature to turn the tide of battle in their favor. Shamans are often revered as the spiritual pillars of their groups, bridging the gap between the mundane and the supernatural with their unique abilities.",
            GrantedSkills = "Trained in Herbalism",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Sylvan Attunement",
                Description = "When learning or preparing Spells granted by your Wizard's or Occultist's Archetype, you can now also choose Spells from Nature category.<br /><br />Additionally, you can also use Herbalism as your Spellcasting Skill."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Ancestral Wisdom",
                Description = "If you have a Knowledge about a specific geographical region, it also counts as if you have Knowledge about denizens living in that region, as well as common animals and plants from that region.<br /><br />While in a Social Encounter, whenever you succeed on a contested Intellect Skill, Charisma Skill or Herbalism check against a Hostile Participant, that Participant has Lower Hand on their next check within the same Encounter."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Visionary's Path",
                Description = "You gain Vision Quest Rest Action.<br /><br />When you take Vision Quest Rest Action, you prepare special herbs that allow you to undertake a magical vision quest during your Rest.<br /><br />Vision Quest Rest Action counts as both Study Rest Action and Scout Exploration Action, and inherits any additional effects applicable to either of those Actions. Additionally, you use your Proficiency Tier in Herbalism instead of usual checks for this Action.<br /><br />However, the only Study Focus you can take is either your immediate geographical region, or a specific creature or plant that is known to be found in the same region. If your Herbalism check as part of this Rest Action is twice the DR set by the Guide or Exploration DR, you immediately finish the chosen Study Focus and gain the associated Knowledge.<br /><br />Any party member resting alongside you can join you in the Vision Quest, using your Herbalism Proficiency Tier for the checks and benefiting from the same effects.<br /><br />This Rest Action costs 1 Ration per participant."
            }
        };
    }
}
