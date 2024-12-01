using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry DemonKin = new Ancestry
        {
            Name = "Demon-Kin",
            Order = 1,
            AncestryType = AncestryType.Exotic,
            ImageUrl = "/images/ancestries/demon-kin.png",
            Quote = "",
            Description = "Demon-Kin represent individuals tied to demons, often as Half-demons or those afflicted by a demonic curse. Their existence is marked by unearthly abilities, dark temptations, and a struggle to reconcile their dual nature in a world where darkness and light collide.",
            Themes = new List<string> { "Half-demon", "Demonic curse" },
            Limitations = "As long as you occupy a holy or a sanctified location, you are considered to be Burning and Sickened. You also have Vulnerability to Hallowed damage.",
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Occultism,
                Skills.Influence,
                Skills.Intimidation,
            },
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Demonic Face",
                    Description = "You reveal a piece of your true nature to another, either charming or terrifying them.",
                    Skills = new List<Skill> { Skills.Occultism, Skills.Influence, Skills.Intimidation },
                    ActionTypes = new List<ActionType> { ActionType.Action, ActionType.Ranged },
                    Range = 5,
                    Tier1 = "You make a target character within range either Pacified, Taunted, or Frightened until the end of their next turn, but you also trigger an Opportunity and become Sickened until the end of your next turn.",
                    Tier2 = "You make a target character within range either Pacified, Taunted, or Frightened until the end of their next turn.",
                    Tier3 = "You make 2 target characters within range either Pacified, Taunted, or Frightened until the end of their next turn.",
                    Tier4 = "You make 3 target characters within range either Pacified, Taunted, or Frightened until the end of their next turn.",
                }
            }
        };
    }
}
