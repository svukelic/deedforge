namespace Deedforge.Domain.CoreRules.Attacking
{
    public class BaseAttackForm
    {
        public required string Name { get; set; }
        public required FormType Type { get; set; }
        public required string Description { get; set; }
    }

    public class Attack
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required BaseAttackForm BaseForm { get; set; }
    }

    public static class BaseAttackForms
    {
        #region Melee Attack Forms
        public static BaseAttackForm Bash = new BaseAttackForm
        {
            Name = "Bash",
            Type = FormType.Melee,
            Description = "A powerful, blunt force strike aimed at causing impact damage or stunning an opponent."
        };

        public static BaseAttackForm Cleave = new BaseAttackForm
        {
            Name = "Cleave",
            Type = FormType.Melee,
            Description = "A wide, sweeping attack intended to hit multiple enemies in a single swing."
        };

        public static BaseAttackForm Slash = new BaseAttackForm
        {
            Name = "Slash",
            Type = FormType.Melee,
            Description = "A cutting attack that typically uses the edge of a bladed weapon to inflict damage."
        };
        #endregion

        #region Ranged Attack Forms

        #endregion

        #region Magic Attack Forms
        public static BaseAttackForm Bolt = new BaseAttackForm
        {
            Name = "Bolt",
            Type = FormType.Magic,
            Description = "A quick and focused attack that can pierce through defenses."
        };

        public static BaseAttackForm Ward = new BaseAttackForm
        {
            Name = "Ward",
            Type = FormType.Magic,
            Description = "A defensive spell that can protect the caster from harm."
        };

        public static BaseAttackForm Wave = new BaseAttackForm
        {
            Name = "Wave",
            Type = FormType.Magic,
            Description = "A wide and powerful attack that can hit multiple targets."
        };
        #endregion
    }

    public enum FormType
    {
        Melee,
        Ranged,
        Magic,
    }
}
