namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Oathsworn = new Profession
        {
            Name = "Oathsworn",
            Order = 70,
            ImageUrl = "images/professions/oathsworn.png",
            Description1 = "The Oathsworn is a steadfast and unwavering champion of their chosen ideals, bound by solemn oaths that grant them extraordinary power. Their role within a party is that of an unyielding protector and an embodiment of their chosen cause. Oathsworns are known for their unshakable resolve, standing as beacons of righteousness and determination. Clad in armor adorned with symbols of their oath, they wield powerful, often magically-enhanced weaponry that embodies the essence of their cause.",
            Description2 = "In the midst of battle, Oathsworns become formidable guardians, defending their allies with unwavering valor. They can take on the brunt of enemy assaults, using their incredible martial skills to intercept attacks meant for their comrades. Oathsworns also possess unique abilities tied to their oath, which can range from harnessing divine powers to summoning ethereal allies. These abilities make them potent adversaries against any who oppose their cause. Beyond combat, they serve as moral compasses for their party, guiding their actions and decisions in accordance with their oath's principles. Oathsworns inspire their companions through their unwavering commitment, reminding them of the higher purpose they all strive to fulfill. With an Oathsworn in your party, you gain not only a stalwart protector but also a beacon of unwavering dedication, ensuring that your group stays true to its shared ideals, no matter the challenges faced on your quest.",
            GrantedSkills = "Trained in any Charisma Skill",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Oathsworn's Piety",
                Description = "You have a pool of dies that represent your Piety. These dies are known as Piety Dies, and the maximum number of these Dies in your pool is equal to Proficiency Tier in your Profession Skill.<br /><br />Whenever you are making any Skill check on which you don't already have Lower Hand, you can spend a Piety Die to gain Upper Hand on that check.<br /><br />Alternatively, whenever you are declared as a target of an attack, you can spend a Piety Die to gain Resistance against that attack."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Sworn Tenets",
                Description = "You have sworn an oath to uphold a set of Tenets. Discuss with the Guide which three tenets you have sworn to uphold.<br /><br />Each Tenet should consists of a principle or concept that you always actively strive to uphold and fight for.<br /><br />E.g. freedom, love, truth, etc.<br /><br />Whenever you make an effort to uphold a Tenet, as deemed fitting by the Guide, you gain a Piety Die. Whenever you refuse or turn away from upholding a Tenet, you gain Lower Hand on all your Attribute checks until you finish a Rest.<br /><br />Additionally, whenever you finish a Rest, and you haven't failed at upholding your Tenets the day before, you gain maximum number of Piety Dies your pool can hold."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Guiding Oath",
                Description = "You gain Ask for Guidance Rest Action.<br /><br />When you take Ask for Guidance Rest Action, you immediately gain knowledge of direction of someone in the immediate region who is in dire need of help. You also gain vague knowledge of what troubles this person, but this help always entails something that is related to one or more of your Tenets.<br /><br />E.g. if you have sworn to uphold principles of freedom, perhaps someone is being forced into slavery and require help.<br /><br />If you take this Rest Action while you're actively in process of providing assistance in accordance with your Tenets to someone, you instead gain an insight into tidbits of information on how to best accomplish your current goal."
            }
        };
    }
}
