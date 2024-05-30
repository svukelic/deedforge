namespace Deedforge.Domain.CoreRules.Attacking
{
    public class MeleeAttacksSheet
    {
        public static class MeleeStyle_Berserker
        {
            public static Attack RampartSmash = new Attack
            {
                Name = "Rampart Smash",
                Description = "A powerful overhead strike that can break through enemy defenses.",
                BaseForm = BaseAttackForms.Bash
            };
        }
    }
}
