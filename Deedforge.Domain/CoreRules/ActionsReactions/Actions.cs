namespace Deedforge.Domain.CoreRules.ActionsReactions
{
    public class Action
    {
        public string Name { get; set; }
        public string Description { get; set; }
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
    }
}
