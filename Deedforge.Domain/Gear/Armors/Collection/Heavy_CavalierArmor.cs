using Deedforge.Domain.AdditionalEntities;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Helpers;

namespace Deedforge.Domain.Gear.Armors.Collection
{
    public partial class Armors
    {
        public static Armor Heavy_CavalierArmor = new Armor
        {
            Name = "Cavalier Armor",
            Description = "A set of heavy armor designed for cavalry combat, providing protection and mobility for mounted warriors.",
            ArmorType = ArmorType.Heavy,
            Endurance = 10,
            NumberOfReactions = 1,
            SuccessActions = new SuccessAction
            {
                Name = "Protect Mount",
                Description = "You protect your mount from damage when it is targeted by an attack.",
                Skills = SetterHelper<Skill>.Set(Skills.Defense),
                ActionTypes = SetterHelper<ActionType>.Set(ActionType.Reaction),
                Range = 0,
                Tier1 = "Your mount gains +3 Grit until the start of your next turn, but you also trigger Opportunity.",
                Tier2 = "Your mount gains +3 Grit until the start of your next turn.",
                Tier3 = "Your mount gains +5 Grit until the start of your next turn.",
                Tier4 = "Your mount gains +5 Grit until the start of your next turn, and you can make a Opportunity against the target that attacked your mount."
            }
        };
    }
}
