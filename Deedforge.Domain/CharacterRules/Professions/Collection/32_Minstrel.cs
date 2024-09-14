namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Minstrel = new Profession
        {
            Name = "Minstrel",
            Order = 32,
            ImageUrl = "images/professions/minstrel.png",
            Description1 = "The Minstrel is the heart and soul of any adventuring party, a masterful performer who wields the power of music and storytelling to inspire, soothe, and rally their companions. In a party, they play the role of the morale-boosting troubadour, using their musical talents to uplift spirits and forge unbreakable bonds among their comrades. Minstrels are known for their versatility, wielding instruments to cast spells, provide healing through their harmonious melodies, and even striking fear into the hearts of foes with their mesmerizing performances.",
            Description2 = "When the party faces danger, the Minstrel's skills shine brightest. They can inspire courage, enhancing their allies' combat prowess, or play haunting tunes to sap the will of their enemies. With a well-timed song, they can mend wounds, cure ailments, and rejuvenate their party members, ensuring that they stay in fighting shape. In the darkest of dungeons or the direst of battles, the Minstrel's music provides a beacon of hope and a source of strength. Beyond the battlefield, Minstrels are the diplomats, using their charm and charisma to negotiate with kings and sway the masses with their stirring ballads. With a Minstrel in your party, you not only gain a talented entertainer but also a powerful force for unity and inspiration, ensuring that your group's spirit remains unbroken, no matter the odds.",
            GrantedSkills = "Trained in Performance",
            Limitations = "Cannot wear Heavy Armor, Requires a musical instrument to use any of the Profession Features",
            CombatFeature = new ProfessionFeature
            {
                Name = "Minstrel's Hymn",
                Description = "Your music carries unbelievable weight. You can take Combine Attacks, Disarm, Grapple, Shove, and Trip actions from afar, as long as your intended target of those actions can hear you. You use Performance for any associated Skill checks of those actions.<br /><br />Additionally, when an ally of yours within Near vicinity of you fails a Skill check, you can as a Reaction make a Performance check against the same contested check or DR. If you succeed, then it is considered that the original check succeeded. You can do this once per Encounter per ally (which must be a player character)."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Mesmerizing Performance",
                Description = "You have the ability to play a tune of immense beauty and charm, so much so that anyone listening to it easily forgets all their current worries.<br /><br />When you start your performance, all non-player characters that can hear you will be drawn to you. You need to make a Performance check against DR defined by the Guide.<br /><br />If you succeed on that check, the drawn characters will be mesmerized by your tune. They are considered to be Pacified and Stunned, and any Hostile Participant skips their turn while under the effect of the performance.<br /><br />However, you need to maintain the performance on your turn, repeating the check every time.<br /><br />Additionally, while performing you can give subtle hints undetectable by anyone other than your party members who can hear you, thus being able to communicate without stopping the performance."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Teller of Legends",
                Description = "While traveling, whenever you end up spending your Rest alongside other travelers, you can attempt to gain information from them in exchange for a personal performance.<br /><br />Make a Performance check against Exploration DR. If you have Knowledge pertaining to local legends or myths, you make this check with Upper Hand. On success, you are allowed to take Map Area or Scout Exploration Action as if you were in a different field on the Exploration map (you use your previous Performance check result instead of rolling again as part of the Exploration Action). The Guide deems whether chosen field is something the travelers you're talking to would have knowledge about.<br /><br />Additionally, whenever you take Study Rest Action with a Study Focus pertaining to local legends and myths, you can use your Proficiency Tier in Performance to determine the number of Study Points you gain."
            }
        };
    }
}
