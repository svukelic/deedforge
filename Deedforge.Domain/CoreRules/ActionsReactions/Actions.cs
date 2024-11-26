using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.CoreRules.ActionsReactions
{
    public class Action : SuccessActionCollection
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public bool IsReaction { get; set; } = false;
    }

    public class Actions
    {
        public static Action Attack = new Action
        {
            Name = "Attack",
            Description = "Make an Attack against a target using one of the Attacks available to the character."

        };

        public static Action Move = new Action
        {
            Name = "Move",
            Description = "Move up to your Movement Speed. TBD: Obstacles"
        };

        public static Action KnowledgeCheck = new Action
        {
            Name = "Knowledge Check",
            Description = "Make a Knowledge Check using one of the Skills available to the character.",
            SuccessActions = new List<SuccessAction>
            {
                new SuccessAction
                {
                    Name = "Knowledge Check",
                    Description = "Make a Knowledge Check using one of the Skills available to the character.",
                    Skills = new List<Skill>(),
                    ActionTypes = new List<ActionType> { ActionType.Action },
                    ChallengeModifier = "The Guide can determine the appropriate Challenge Modifier in case of more esoteric subjects.",
                    Tier1 = "You learn 1 true information and 1 false information about the subject, but you do not know which is which.",
                    Tier2 = "You learn 1 true information about the subject.",
                    Tier3 = "You learn 2 true information about the subject.",
                    Tier4 = "You learn 3 true information about the subject."
                }
            }
        };
    }
}
