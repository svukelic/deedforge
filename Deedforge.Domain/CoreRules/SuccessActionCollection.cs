using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CoreRules
{
    public class SuccessActionCollection
    {
        public List<SuccessAction>? SuccessActions { get; set; }
    }

    public class SuccessAction
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required List<Skill> Skills { get; set; } = new List<Skill>();
        public required List<ActionType> ActionTypes { get; set; } = new List<ActionType>();
        public string? ChallengeModifier { get; set; } = "-";
        public required string Tier1 { get; set; }
        public required string Tier2 { get; set; }
        public required string Tier3 { get; set; }
        public required string Tier4 { get; set; }

        public static implicit operator List<SuccessAction>(SuccessAction v)
        {
            return new List<SuccessAction> { v };
        }
    }

    public enum ActionType
    {
        Action,
        Reaction,
        Melee,
        Ranged,
        Spell,
        Area
    }
}
