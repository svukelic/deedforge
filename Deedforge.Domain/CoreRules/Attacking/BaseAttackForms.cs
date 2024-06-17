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

        public static BaseAttackForm Disarm = new BaseAttackForm
        {
            Name = "Disarm",
            Type = FormType.Melee,
            Description = "A targeted maneuver intended to knock an opponent’s weapon from their grasp."
        };

        public static BaseAttackForm GuardBreak = new BaseAttackForm
        {
            Name = "Guard Break",
            Type = FormType.Melee,
            Description = "An attack focused on penetrating or bypassing an enemy’s defensive posture. Prerequisite: Can only be taken when a target takes Block, Dodge or Riposte Reaction. The attacker can then change their original attack to this one."
        };

        public static BaseAttackForm KillingBlow = new BaseAttackForm
        {
            Name = "Killing Blow",
            Type = FormType.Melee,
            Description = "A lethal strike requiring attacker’s full dedication aimed at a vital area to quickly finish off an opponent. Prerequisite: Can only be taken after the attacker has landed a Wounding Attack since their last turn, or against Exposed targets."
        };

        public static BaseAttackForm OverheadStrike = new BaseAttackForm
        {
            Name = "Overhead Strike",
            Type = FormType.Melee,
            Description = "A downward attack that brings the weapon crashing down on the opponent with full force."
        };

        public static BaseAttackForm Restrain = new BaseAttackForm
        {
            Name = "Restrain",
            Type = FormType.Melee,
            Description = "A technique aimed at immobilizing or significantly hindering an opponent’s movement."
        };

        public static BaseAttackForm Riposte = new BaseAttackForm
        {
            Name = "Riposte",
            Type = FormType.Melee,
            Description = "A quick, precise counterattack made as response to an enemy’s attack. Prerequisite: Can only be taken as a Reaction. When done so, the user of Riposte must make a contested Weapon check against the enemy's Weapon check to see if they parry. On a successful parry, the user of Riposte can counter-attack the original enemy with a Riposte attack."
        };

        public static BaseAttackForm Slash = new BaseAttackForm
        {
            Name = "Slash",
            Type = FormType.Melee,
            Description = "A cutting attack that typically uses the edge of a bladed weapon to inflict damage."
        };

        public static BaseAttackForm Thrust = new BaseAttackForm
        {
            Name = "Thrust",
            Type = FormType.Melee,
            Description = "A stabbing motion aimed at piercing an opponent with the point of a weapon."
        };

        public static BaseAttackForm Throw = new BaseAttackForm
        {
            Name = "Throw",
            Type = FormType.Melee,
            Description = "The act of hurling a weapon at an opponent to strike them from a distance."
        };

        public static BaseAttackForm Trip = new BaseAttackForm
        {
            Name = "Trip",
            Type = FormType.Melee,
            Description = "A maneuver designed to knock an opponent off their feet, causing them to fall."
        };

        public static BaseAttackForm Whirlwind = new BaseAttackForm
        {
            Name = "Whirlwind",
            Type = FormType.Melee,
            Description = "A spinning attack that targets multiple enemies surrounding the attacker."
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
