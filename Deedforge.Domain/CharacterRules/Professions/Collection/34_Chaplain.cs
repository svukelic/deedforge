namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Chaplain = new Profession
        {
            Name = "Chaplain",
            Order = 34,
            ImageUrl = "images/professions/chaplain.png",
            Description1 = "The Chaplain is a devoted spiritual leader within an adventuring party, responsible for the spiritual and emotional welfare of their comrades. With unwavering faith and a deep connection to the divine, Chaplains offer guidance, solace, and protection to their fellow adventurers. They lead prayers before embarking on perilous quests, bestow blessings to shield their companions from harm, and offer counsel in times of moral quandary. When darkness falls and morale wanes, it's the Chaplain's soothing words and unwavering faith that rekindle the party's spirit, reminding them of their higher purpose.",
            Description2 = "In a party, the Chaplain assumes the role of both spiritual guide and guardian. They are the moral compass of the group, ensuring that the party's actions remain true to their values and principles. Their divine magic provides healing and protection, allowing the party to endure the rigors of adventuring life. In the heat of battle, Chaplains call upon the power of their faith to smite foes and bolster the resolve of their comrades. Beyond their spiritual duties, Chaplains are often skilled diplomats and negotiators, diffusing tense situations and forging alliances through their unwavering commitment to righteousness. With their presence, the party finds strength not only in their weapons but also in their hearts and souls.",
            GrantedSkills = "Trained in Insight",
            Limitations = "Cannot take any Martial Trait. Instead, you must pick a Social Trait.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Chaplain's Piety",
                Description = "You have a pool of d4 dies that represent your Piety. These dies are known as Piety Dies, and the maximum number of these Dies in your pool is equal to your Proficiency Tier in Insight.<br /><br />Whenever you succeed on a contested check or a check against fixed DR, you gain 1 Piety Die.<br /><br />With this feature, you gain access to Divine Guidance.<br /><br />Whenever a friendly character within Near vicinity is making any Skill Check, you can as a Reaction spend and roll a Piety Die. The target friendly character adds the result of that roll to their Skill Check."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Insightful Friend",
                Description = "You have Bolstered Status on all Charisma Skill checks against characters belonging to a religion or faith you have Knowledge about."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Theologist",
                Description = "You and your Party members have DR of all Hallowed and Profane Injuries halved.<br /><br />Additionally, whenever you take Study Rest Action with a focus pertaining to faiths, religions, cults, etc., you can use your Proficiency Tier in Charisma instead of Intellect to determine the number of Study Points you gain."
            }
        };
    }
}
