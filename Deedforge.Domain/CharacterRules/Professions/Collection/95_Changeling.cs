namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Changeling = new Profession
        {
            Name = "Changeling",
            Order = 95,
            ImageUrl = "images/professions/changeling.png",
            Description1 = "Changelings are enigmatic shape-shifters, their true forms hidden behind an ever-shifting facade of illusion. In a party, Changelings are the ultimate infiltrators and masters of subterfuge. Their ability to change appearance and mimic voices allows them to seamlessly blend into any environment or situation, making them invaluable for espionage, reconnaissance, and manipulation.",
            Description2 = "Changelings excel at espionage and information gathering. They can assume the appearance of allies or enemies, slipping into secret meetings, gathering critical intel, and then effortlessly slipping away unnoticed. Their mimicry extends beyond the visual realm; they can imitate voices and even replicate handwriting, adding an extra layer of deception to their arsenal. In combat, Changelings can confound opponents by transforming into unpredictable combatants. The Changeling's role in a party is one of versatility and misdirection, where their unique skills shine in situations requiring espionage, subterfuge, or social manipulation. They are the party's secret weapon, using their ever-shifting nature to outwit enemies and gather crucial information.",
            GrantedSkills = "Trained in Deception",
            Limitations = "Cannot cast Spells, Cannot invest any Skill Boosts into Weaponry Skills",
            CombatFeature = new ProfessionFeature
            {
                Name = "Memetic Learner",
                Description = "You inherit Weaponry Skills from the Personality you currently have active. The inherited Skill's Proficiency Tier cannot be higher than your Proficiency Tier in Deception."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Doppelganger",
                Description = "Whenever you touch an intelligent humanoid, you can choose to immediately imprint onto their appearance and capabilities, and Store their Personality.<br /><br />You can have a maximum number of Stored Personalities equal to your Proficiency Tier in Deception. Whenever you want to Store a new one, you can choose to permanently forget an existing Stored Personality.<br /><br />You can change from and into one of your Stored Personalities at any time, an action which costs 2 AP if done during a Combat Encounter. Whenever you do so, you adopt the appearance, voice and mannerisms of the Stored Personality."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Master of Forms",
                Description = "You can use your Proficiency Tier in Deception instead of Intellect to determine the number of Study Points you gain whenever you Study about intelligent humanoids.<br /><br />Additionally, you gain Adopt Ancestry Rest Action.<br /><br />When you take Adopt Ancestry Rest Action, you spend part of your Rest adapting your internal physiology to the Ancestry of one of your Stored Personalities. When you do so, you gain the features of the new Ancestry and lose the features of the previous one.<br /><br />You can at the end of any Rest, without taking this Rest Action, choose to revert to your original Ancestry."
            }
        };
    }
}
