using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Heavy_FortifiedArmor = new Armor
        {
            Name = "Fortified Armor",
            Description = "A heavy armor designed to protect the wearer from a wide range of debilitating effects.",
            ArmorType = ArmorType.Heavy,
            Endurance = 10,
            NumberOfReactions = 1,
            SuccessActions = new SuccessAction
            {
                Name = "Endure Assault",
                Description = "You absorb the effects of an attack, reducing its severity or ignoring it entirely.",
                Skills = SetterHelper<Skill>.Set(Skills.Defense),
                ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                Range = 0,
                Tier1 = "You prevent Dazed, Pinned, Prone and Staggered from being applied to you, but you also become Slowed until the end of your next turn.",
                Tier2 = "You prevent Dazed, Pinned, Prone and Staggered from being applied to you.",
                Tier3 = "You prevent Dazed, Pinned, Prone and Staggered from being applied to you, and gain immunity to the next instance of Dazed, Pinned, Prone and Staggered that would be applied to you.",
                Tier4 = "You prevent Dazed, Pinned, Prone and Staggered from being applied to you, and gain immunity to the next instance of Dazed, Pinned, Prone and Staggered that would be applied to you. You also can make a Opportunity against the target that attacked you."
            }
        };
    }
}
