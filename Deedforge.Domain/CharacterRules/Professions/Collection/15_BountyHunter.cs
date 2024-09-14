namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession BountyHunter = new Profession
        {
            Name = "Bounty Hunter",
            Order = 15,
            ImageUrl = "images/professions/bounty-hunter.png",
            Description1 = "In the dense heart of an ancient forest, or the echoing halls of a high-security prison, the Bounty Hunter stands as a sentinel of order and protection. They are the guardians, the jailers who maintain balance and ensure that those who are meant to be confined remain so. With a sturdy shield in one hand and a weapon in the other, a Bounty Hunter might stand as the unyielding barrier between their allies and a rampaging beast, their shield absorbing the brunt of the attack as they strike back with calculated precision. Or they could ensnare a fleeing enemy with ethereal chains, their magic binding the foe and preventing their escape.",
            Description2 = "But a Bounty Hunter's role in a party extends beyond their ability to contain and control. They are the protectors, the watchers, and the tactical defenders. With their keen understanding of strategy and their ability to control the battlefield, they can direct their allies, set up defensive perimeters, and anticipate enemy movements. In a perilous dungeon, they might be the one to spot and disarm a deadly trap, their quick reflexes saving their allies from harm. In a tense standoff, they could position themselves to protect their more vulnerable allies, their presence a deterrent to any who would seek to harm their charges. In essence, the Bounty Hunter is the steadfast guardian, the tactical defender, and the unyielding barrier that stands between their allies and the dangers that seek to harm them.",
            GrantedSkills = "Trained in Investigation or Survival",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Bounty Hunter's Art",
                Description = "You can now take Grapple Action with any weapon. You're considered to have two free hands for the purposes of determining AP cost of this action, and the used weapon's properties are applied as if you took an Attack action.<br /><br />Enemies who are under Restrained Status due to your Grapple also have Imperiled (Physical) Status."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Expert Investigator",
                Description = "Whenever you succeed on an Investigation or Survival check made with the intention of gathering info on a specific person, you gain a Study Point towards Knowledge about that person, as if you took Study Rest Action."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Track Quarries",
                Description = "Whenever you successfully take Scout Exploration Action you also gain immediate insight into any and all groups that recently passed through your immediate area.<br /><br />Additionally, you can now take Scout Exploration Action as Rest Action, and any successful check also counts for your Expert Investigator feature."
            }
        };
    }
}
