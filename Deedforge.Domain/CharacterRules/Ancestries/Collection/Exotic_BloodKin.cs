using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry BloodKin = new Ancestry
        {
            Name = "Blood-Kin",
            Order = 2,
            AncestryType = AncestryType.Exotic,
            ImageUrl = "/images/ancestries/blood-kin.png",
            Quote = "",
            Description = "Blood-Kin are individuals with a connection to creatures of the night, such as half-vampires or lycanthropes. They grapple with the duality of their nature, possessing both human and monstrous traits, and must confront the challenges and prejudices that come with their lineage.",
            Themes = new List<string> { "Half-vampire", "Lycanthrope" },
            Limitations = "You can only consume remains of humanoids who died no more than 24 hours ago, and consuming regular food makes you violently sick. However, you need to feed only once per week. You also have Vulnerability to Silvered damage.",
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Health,
                Skills.Subterfuge,
                Skills.Intimidation,
            },
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Monstrous Form",
                    Description = "You transform into a monstrous form based on your bloodline.",
                    Skills = new List<Skill> { Skills.Subterfuge, Skills.Intimidation },
                    ActionTypes = new List<ActionType> { ActionType.Action },
                    Range = 0,
                    Tier1 = "You transform into either a Werewolf or a Vampire until the end the current Encounter, but you also become Enraged until the end of your next turn.",
                    Tier2 = "You transform into either a Werewolf or a Vampire until the end the current Encounter.",
                    Tier3 = "You transform into either a Werewolf or a Vampire until the end the current Encounter. All enemies within 5 hexes of you are Frightened until the end of your next turn.",
                    Tier4 = "You transform into either a Werewolf or a Vampire until the end the current Encounter. All enemies within 5 hexes of you are Frightened until the end of the current Encounter.",
                }
            }
        };
    }
}
