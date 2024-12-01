namespace Deedforge.Domain.Helpers
{
    public static class Constants
    {
        public const string ChallengeModifier_Endurance = "Equal to target's Endurance";
        public const string ChallengeModifier_Difficulty = "Equal to Difficulty estimated by the Guide";
        public static string ChallengeModifier_NumberOfTargets(int modifier)
        {
            return $"-{modifier} per each affected target.";
        }
        public static string ChallengeModifier_Size(int modifier)
        {
            return $"-{modifier} for each Size Category higher than your own.";
        }
    }
}
