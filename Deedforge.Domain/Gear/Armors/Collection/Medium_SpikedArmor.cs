using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Medium_SpikedArmor = new Armor
        {
            Name = "Spiked Armor",
            Description = "A set of armor with spikes, providing both protection and intimidation.",
            ArmorType = ArmorType.Medium,
            Endurance = 6,
            NumberOfReactions = 2,
            SuccessActions = new SuccessAction
            {
                Name = "Counter-grapple",
                Description = "You attempt to grapple an enemy that struck you.",
                Skills = SetterHelper<Skill>.Set(Skills.Athletics),
                ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction, ActionType.Melee),
                Range = 1,
                ChallengeModifier = Constants.ChallengeModifier_Endurance,
                Tier1 = "You grapple an enemy that hit you with a Melee Attack. Both you and the target enemy become Pinned while grappled.",
                Tier2 = "You grapple an enemy that hit you with a Melee Attack. The target enemy becomes Pinned while grappled.",
                Tier3 = "You grapple an enemy that hit you with a Melee Attack. The target enemy becomes Pinned and takes 1 damage at the start of each of its turns while grappled.",
                Tier4 = "You grapple an enemy that hit you with a Melee Attack. The target enemy becomes Pinned and takes 2 damage at the start of each of its turns while grappled."
            }
        };
    }
}
