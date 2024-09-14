namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Marauder = new Profession
        {
            Name = "Marauder",
            Order = 1,
            ImageUrl = "images/professions/marauder.png",
            Description1 = "The Marauder is a primal warrior who taps into their inner fury to unleash devastating attacks upon their foes. They are a fearless and fierce member of any adventuring party, charging into battle with little concern for their own safety. The Marauder’s fury is a key component of their combat abilities, granting them a boost in strength, durability, and speed. While in this state of frenzy, they are capable of feats of physical prowess that would be impossible for most other warriors.",
            Description2 = "Marauders excel in close-quarters combat, using their strength to deliver powerful melee attacks with weapons or their bare hands. They can also serve as tanks for the party, absorbing enemy attacks while dealing heavy damage in return. A Marauder’s role in a party is to be the front line of defense and a relentless force in battle, inspiring fear and awe in their foes.",
            GrantedSkills = "Trained in any two Fortitude Skills.",
            Limitations = "None.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Battle Fury",
                Description = "You have the ability to enter a furious stance known as the Battle Fury as a Preparation Action, and it lasts until the end of your next turn. While you are in Battle Fury, you gain the following effects:<br /> - You gain Enraged Status that cannot be stripped from you in any way while you are in Battle Fury.<br /> - You have Upper Hand on all Fortitude checks.<br /> - If you have suffered a Wound since your last turn, the first time you hit an enemy in current turn is considered a Severe Hit."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Conquering Presence",
                Description = "You can now use Athletics checks instead of Intimidation for same purposes, and any effect or feature that affects Intimidation checks also affects Fortitude Skill checks for you."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Wilderness Sherpa",
                Description = "While in an Exploration Encounter, if you or an ally of yours is making a Skill check for which the Exploration DR is increased by presence of hazardous Environment or Weather, you can halve the DR on that check. You can do so after seeing the result of the roll.\r\n\r\nHowever, whenever you use this feature, you gain a level of Exhaustion."
            }
        };
    }
}
