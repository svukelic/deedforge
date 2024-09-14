namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Brawler = new Profession
        {
            Name = "Brawler",
            Order = 25,
            ImageUrl = "images/professions/brawler.png",
            Description1 = "The Brawler is a relentless combatant who thrives in the midst of physical conflict. Within a party, they serve as the front-line warriors, relying on their raw strength and combat prowess to engage and overwhelm opponents. Brawlers are masters of hand-to-hand combat, capable of delivering bone-crushing punches and bone-shattering kicks. Their fists are their weapons, and they are known for their incredible stamina and resilience, enduring even the most punishing blows. In battle, Brawlers often take on the role of a vanguard, charging headfirst into the fray to draw the enemy's attention away from their more fragile allies.",
            Description2 = "A Brawler's fighting style is as diverse as it is devastating. They may employ a variety of martial arts techniques, using their agility to dodge attacks and strike with lightning-fast punches. Some Brawlers favor a more brute force approach, relying on sheer strength to break through enemy lines. In addition to their martial skills, Brawlers often possess an unshakable determination that drives them to push past their limits in the heat of battle. Their role in the party is that of a relentless front-line combatant, absorbing damage, disrupting enemy formations, and ensuring that their allies have the time and space they need to unleash their own abilities. When a Brawler is on your side, you can rest assured that they will fight tooth and nail to secure victory, no matter the odds.",
            GrantedSkills = "",
            Limitations = "Cannot cast Spells",
            CombatFeature = new ProfessionFeature
            {
                Name = "Pugilist",
                Description = "Your Fists gain the following Weapon Properties: Brutal, Daze, and Parry.<br /><br />Additionally, you can now bind to one additional Enchanted Item to Weapon slot, provided both bound Enchanted Items in the Weapon Slot specifically benefit attacks with Fists."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Establish Dominance",
                Description = "While in a Social Encounter, you can challenge any Hostile Participant to a contest of physical prowess.<br /><br />Choose a Fortitude or a Reflex Skill and describe the details of the contest that requires usage of the chosen Skill.<br /><br />As part of the contest, your opponent must make a Skill check with the chosen Skill contested by your Skill check in the same Skill.<br /><br />If your opponent refuses or loses this contest, they have Lower Hand on all Attribute Checks for the duration of the Social Encounter."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Rigorous Training",
                Description = "You gain Train Rest Action.<br /><br />When you take Train Rest Action, you spend part of your Rest undergoing a rigorous training session. At the end of it, you choose one Fortitude or Reflex Skill. Until your next Rest, you gain Bolstered Status in the chosen Skill.<br /><br />Additionally, any party member that is also Resting alongside you can join you in training and gaining the same benefit, but this activity also uses their Rest Action."
            }
        };
    }
}
