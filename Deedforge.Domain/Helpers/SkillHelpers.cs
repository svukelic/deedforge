using Deedforge.Domain.CoreRules.Skills;

namespace Deedforge.Domain.Helpers
{
    public static class SkillHelpers
    {
        public static List<Skill> SetSkills(params Skill[] skills)
        {
            return new List<Skill>(skills);
        }
    }
}
