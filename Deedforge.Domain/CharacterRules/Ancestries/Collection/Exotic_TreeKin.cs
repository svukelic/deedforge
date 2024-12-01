using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CharacterRules.Ancestries.Collection
{
    public partial class Ancestries
    {
        public static Ancestry TreeKin = new Ancestry
        {
            Name = "Tree-Kin",
            Order = 3,
            AncestryType = AncestryType.Exotic,
            ImageUrl = "/images/ancestries/tree-kin.png",
            Quote = "",
            Description = "Tree-Kin are beings tied to the natural world, often resembling ents, dryads, or those blessed by forest spirits. They guard the secrets of the wilderness, nurturing the land and its inhabitants, and drawing strength from the ancient spirits of the forest.",
            Themes = new List<string> { "Ent", "Dryad", "Blessed by forest spirits" },
            Limitations = "You don't have to eat, but you do have to spend at least 1 hour every day in sunlight to recharge. Failing to do so makes you Sickened until you recharge. You also have Vulnerability to Fire damage.",
            GrantedTraitCategories = new List<Skill>
            {
                Skills.Health,
                Skills.Forestry,
                Skills.Faith,
            },
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Call of the Forest",
                    Description = "You call upon the spirits of the forest to come to your aid.",
                    Skills = new List<Skill> { Skills.Forestry, Skills.Faith },
                    ActionTypes = new List<ActionType> { ActionType.Action },
                    Range = 5,
                    Tier1 = "You summon a Common Plant which lasts until the end of current Encounter, but you also become Sickened and Slowed until the end of your next turn.",
                    Tier2 = "You summon a Common Plant which lasts until the end of current Encounter.",
                    Tier3 = "You summon an Uncommon Plant which lasts until the end of current Encounter.",
                    Tier4 = "You summon a Rare Plant which lasts until the end of current Encounter.",
                }
            }
        };
    }
}
