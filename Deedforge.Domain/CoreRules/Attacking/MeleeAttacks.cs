namespace Deedforge.Domain.CoreRules.Attacking
{
    public class MeleeAttacks
    {
        public static AttackForm Bash = new AttackForm
        {
            Name = "Bash",
            Description = "A blunt force strike. On hit, the target becomes Dazed until the end of its next turn."
        };

        public static AttackForm Cleave = new AttackForm
        {
            Name = "Cleave",
            Description = "A wide, sweeping attack intended to hit multiple enemies in a single swing. Attacks two additional targets with the same attack roll within Melee vicinty of the original target."
        };

        public static AttackForm Disarm = new AttackForm
        {
            Name = "Disarm",
            Description = "A targeted maneuver intended to knock an opponent’s weapon from their grasp. Doesn't cause damage. On hit, the target drops its weapon within Near vicinity."
        };

        public static AttackForm GuardBreak = new AttackForm
        {
            Name = "Guard Break",
            Description = "An attack focused on penetrating or bypassing an enemy’s defensive posture. Can only be taken when a target takes Block or Parry Reaction. The attacker can then change their original attack to this one. The contested check of this attack against the Block or Parry reaction is done with an Upper Hand. On a hit, the target becomes Maimed until the end of its next turn."
        };

        public static AttackForm KillingBlow = new AttackForm
        {
            Name = "Killing Blow",
            Description = "A lethal strike requiring attacker’s full dedication aimed at a vital area to quickly finish off an opponent. Can only be taken after the attacker has landed an attack since their last turn with the same weapon, or against Exposed targets. On hit, the attacker chooses which Injury is inflicted on the target instead of rolling for it."
        };

        public static AttackForm OverheadStrike = new AttackForm
        {
            Name = "Overhead Strike",
            Description = "A downward attack that brings the weapon crashing down on the opponent with full force. On hit, the target becomes Slowed until the end of its next turn."
        };

        public static AttackForm Slash = new AttackForm
        {
            Name = "Slash",
            Description = "A cutting attack that typically uses the edge of a bladed weapon to inflict damage. On hit, the target is inflicted with Bleeding."
        };

        public static AttackForm Thrust = new AttackForm
        {
            Name = "Thrust",
            Description = "A stabbing motion aimed at piercing an opponent with the point of a weapon. On hit, the target becomes Fatigued until the end of its next turn."
        };

        public static AttackForm Throw = new AttackForm
        {
            Name = "Throw",
            Description = "The act of hurling a weapon at an opponent to strike them from a distance. Throw can be performed from Close vicinity."
        };

        public static AttackForm Trip = new AttackForm
        {
            Name = "Trip",
            Description = "A maneuver designed to knock an opponent off their feet, causing them to fall. Doesn't cause damage. On hit, the target becomes Pinned."
        };
    }
}
