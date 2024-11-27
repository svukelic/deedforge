using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Heavy_PlateArmor = new Armor
        {
            Name = "Plate Armor",
            Description = "A set of heavy armor made from solid metal plates, providing excellent protection but limited mobility.",
            ArmorType = ArmorType.Heavy,
            Endurance = 11,
            NumberOfReactions = 1,
            SuccessActions = new SuccessAction
            {
                Name = "Shoulderbash",
                Description = "You charge into an enemy, bashing them with your shoulder. This Attack is done with Upper Hand if you use it immediately after a Move action.",
                Skills = SetterHelper<Skill>.Set(Skills.Athletics),
                ActionTypes = SetterHelper<ActionType>.Set(ActionType.Action),
                Range = 1,
                ChallengeModifier = Constants.ChallengeModifier_Size(3),
                Tier1 = "You deal 1 damage and push back target 1 hex, but you also become Prone.",
                Tier2 = "You deal 1 damage and push back target 1 hex.",
                Tier3 = "You deal 2 damage and the target becomes Prone.",
                Tier4 = "You deal 2 damage and the target becomes Prone, and also Dazed until the end of its next turn."
            }
        };
    }
}
