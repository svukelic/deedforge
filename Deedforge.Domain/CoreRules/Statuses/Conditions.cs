namespace Deedforge.Domain.CoreRules.Statuses
{
    public class Conditions
    {
        public static Status Bleeding = new Status
        {
            Name = "Bleeding",
            Description = "The target is bleeding and will take damage over time.",
            Effect = "At the start of the target's turn, they take 1d4 damage."
        };
    }
}
