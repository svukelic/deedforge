using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CoreRules
{
    public class SuccessActionCollection
    {
        public List<SuccessAction> SuccessActions { get; set; }
    }

    public class SuccessAction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ActionType> ActionTypes { get; set; }
        public string ChallengeModifier { get; set; } = "-";
        public string Tier1 { get; set; }
        public string Tier2 { get; set; }
        public string Tier3 { get; set; }
        public string Tier4 { get; set; }

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
