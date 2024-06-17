namespace Deedforge.Domain.CoreRules.Attacking
{
    public class MeleeAttacksSheets
    {
        public AttacksSheet Berserker { get; set; }

        public MeleeAttacksSheets()
        {
            Berserker = new Berserker();
        }
    }

    public class BattleDancer : AttacksSheet
    {
        public BattleDancer()
        {
            Name = "Battle Dancer";
            Description = "Combines fluid movement and rhythmic attacks, providing mobility and grace in combat, making it easier to dodge attacks and maintain offensive momentum.";
            Type = FormType.Melee;
            Attacks = new List<Attack>()
            {
                new Attack
                {
                    Name = "Battle Dancer's Bash",
                    Description = "On a hit, the target becomes Numb (attacker chooses Arm or Leg).",
                    BaseForm = BaseAttackForms.Bash
                },
                new Attack
                {
                    Name = "Battle Dancer's Cleave",
                    Description = "When attacking, can attack two additional targets within Melee vicinity of the original target. Afterwards, attacker can move one vicinity tier, away from the original target.",
                    BaseForm = BaseAttackForms.Cleave
                },
                new Attack
                {
                    Name = "Battle Dancer's Disarm",
                    Description = "Doesn't cause damage. On a hit, the target's weapon drops out of their hand and onto the ground. During the target's next turn, if they attempt to pick up the weapon, the attacker can make an Attack of Opportunity against them first.",
                    BaseForm = BaseAttackForms.Disarm
                },
                new Attack
                {
                    Name = "Battle Dancer's Guard Break",
                    Description = "Attacker makes a contested Weapon check against target's Passive DR, the skill of which depends on the targets Reaction: Defense for Block, Reflex for Dodge, and specific Weapon for Riposte. On success, the attacker ignores the target's Reaction and instead lands a hit on them automatically.",
                    BaseForm = BaseAttackForms.GuardBreak
                },
                new Attack
                {
                    Name = "Battle Dancer's Killing Blow",
                    Description = "On a hit, inflicts additional Wound, if applicable.",
                    BaseForm = BaseAttackForms.KillingBlow
                },
                new Attack
                {
                    Name = "Battle Dancer's Overhead Strike",
                    Description = "On a hit, the target becomes Blinded. The attacker also automatically takes Dodge Reaction the next time they are targeted by an attack without expending a Reaction, but they also become Prone.",
                    BaseForm = BaseAttackForms.OverheadStrike
                },
                new Attack
                {
                    Name = "Battle Dancer's Restrain",
                    Description = "Doesn't cause damage. The attacker can Move first before making this attack at no additional AP cost.",
                    BaseForm = BaseAttackForms.Restrain
                },
                new Attack
                {
                    Name = "Battle Dancer's Riposte",
                    Description = "On a sucessful parry, the user of Riposte can choose not to counter-attack and instead take a Move action at no AP cost. If the user of Riposte chooses to attack, they can make one of other Attacks they have available.",
                    BaseForm = BaseAttackForms.Riposte
                },
                new Attack
                {
                    Name = "Battle Dancer's Slash",
                    Description = "On a hit, the attacker can take Move action at no AP cost.",
                    BaseForm = BaseAttackForms.Slash
                },
                new Attack
                {
                    Name = "Battle Dancer's Thrust",
                    Description = "On a hit, the target becomes Clumsy.",
                    BaseForm = BaseAttackForms.Thrust
                },
                new Attack
                {
                    Name = "Battle Dancer's Throw",
                    Description = "On a hit, the target becomes Distracted.",
                    BaseForm = BaseAttackForms.Throw
                },
                new Attack
                {
                    Name = "Battle Dancer's Trip",
                    Description = "Doesn't cause damage. On a hit, the target becomes Prone. The attacker also automatically takes Dodge Reaction the next time they are targeted by the original target with an attack.",
                    BaseForm = BaseAttackForms.Trip
                },
                new Attack
                {
                    Name = "Battle Dancer's Whirlwind",
                    Description = "Attack up to three different targets using the same attack roll. Can take can Move action before each attack at no additional AP cost.",
                    BaseForm = BaseAttackForms.Whirlwind
                }
            };
        }
    }

    public class Berserker : AttacksSheet
    {
        public Berserker()
        {
            Name = "Berserker";
            Description = "Focuses on aggressive, high-damage attacks that overwhelm opponents with sheer brute force, breaking through defenses and causing massive damage.";
            Type = FormType.Melee;
            Attacks = new List<Attack>
            {
                new Attack
                {
                    Name = "Berserker's Bash",
                    Description = "On a hit, the target is inflicted with Daze.",
                    BaseForm = BaseAttackForms.Bash
                },
                new Attack
                {
                    Name = "Berserker's Cleave",
                    Description = "When attacking, can attack two additional targets within Melee vicinity of the original target. On a hit, a target is knocked back one vicinity tier.",
                    BaseForm = BaseAttackForms.Cleave
                },
                new Attack
                {
                    Name = "Berserker's Disarm",
                    Description = "On a hit, the target's weapon flies out of their hand and lands one vicinity tier away, and the target is inflicted with Numb in that arm.",
                    BaseForm = BaseAttackForms.Disarm
                },
                new Attack
                {
                    Name = "Berserker's Guard Break",
                    Description = "On a hit, the target's shield (in case of Block) or weapon (in case of Riposte) becomes Broken. If the item cannot be Broken, then the target is inflicted with Numb (Arm) instead.",
                    BaseForm = BaseAttackForms.GuardBreak
                },
                new Attack
                {
                    Name = "Berserker's Killing Blow",
                    Description = "On a hit, causes double damage. If the target is Exposed, the attack kills them instead, and inflicts Frightened on all enemies within Near vicinity.",
                    BaseForm = BaseAttackForms.KillingBlow
                },
                new Attack
                {
                    Name = "Berserker's Overhead Strike",
                    Description = "On a hit, the target becomes Prone.",
                    BaseForm = BaseAttackForms.OverheadStrike
                },
                new Attack
                {
                    Name = "Berserker's Restrain",
                    Description = "Doesn't cause damage. On a hit, the target becomes both Restrained and Prone.",
                    BaseForm = BaseAttackForms.Restrain
                },
                new Attack
                {
                    Name = "Berserker's Riposte",
                    Description = "On a hit, the target becomes Dazed and Surprised.",
                    BaseForm = BaseAttackForms.Riposte
                },
                new Attack
                {
                    Name = "Berserker's Slash",
                    Description = "On a hit, the target is inflicted with Bleeding.",
                    BaseForm = BaseAttackForms.Slash
                },
                new Attack
                {
                    Name = "Berserker's Thrust",
                    Description = "On a hit, the target is inflicted with Burdened (DR is used weapon's Passive DR).",
                    BaseForm = BaseAttackForms.Thrust
                },
                new Attack
                {
                    Name = "Berserker's Throw",
                    Description = "On a hit, if the target is the attacker's Size or smaller, they become Prone. If they are larger, they become Dazed instead.",
                    BaseForm = BaseAttackForms.Throw
                },
                new Attack
                {
                    Name = "Berserker's Trip",
                    Description = "Doesn't cause damage. On a hit, the target becomes Numb (Leg) and Prone.",
                    BaseForm = BaseAttackForms.Trip
                },
                new Attack
                {
                    Name = "Berserker's Whirlwind",
                    Description = "When attacking, can attack all targets within Melee vicinity of the attacker. On a hit, a target is knocked back one vicinity tier.",
                    BaseForm = BaseAttackForms.Whirlwind
                }
            };
        }
    }

    public class DrunkenMaster : AttacksSheet
    {
        public DrunkenMaster()
        {
            Name = "Drunken Master";
            Description = "Utilizes unpredictable movements and unorthodox techniques to confuse and disorient opponents, making attacks difficult to predict and counter.";
            Type = FormType.Melee;
            Attacks = new List<Attack>
            {
                new Attack
                {
                    Name = "Drunken Master's Bash",
                    Description = "On a hit, the target becomes Confused.",
                    BaseForm = BaseAttackForms.Bash
                },
                new Attack
                {
                    Name = "Drunken Master's Cleave",
                    Description = "Doesn't cause damage. When attacking, can attack two additional targets within Melee vicinity of the original target. On a hit, a target becomes Prone.",
                    BaseForm = BaseAttackForms.Cleave
                },
                new Attack
                {
                    Name = "Drunken Master's Disarm",
                    Description = "Requires a free hand. Doesn't cause damage. On a hit, the target drops their equipped weapon and the attacker grabs it instead with their free hand.",
                    BaseForm = BaseAttackForms.Disarm
                },
                new Attack
                {
                    Name = "Drunken Master's Guard Break",
                    Description = "Doesn't cause damage. On a hit, the target drops their equipped shield (in case of Block) or weapon (in case of Riposte).",
                    BaseForm = BaseAttackForms.GuardBreak
                },
                new Attack
                {
                    Name = "Drunken Master's Killing Blow",
                    Description = "On a hit, the target becomes briefly Exposed. If the target is already Exposed, they become Stunned instead.",
                    BaseForm = BaseAttackForms.KillingBlow
                },
                new Attack
                {
                    Name = "Drunken Master's Overhead Strike",
                    Description = "On a hit, the target becomes Stupefied.",
                    BaseForm = BaseAttackForms.OverheadStrike
                },
                new Attack
                {
                    Name = "Drunken Master's Restrain",
                    Description = "Doesn't cause damage. On a hit, the target becomes Restrained. If this Status persists after the target's second turn, they become Unconscious.",
                    BaseForm = BaseAttackForms.Restrain
                },
                new Attack
                {
                    Name = "Drunken Master's Riposte",
                    Description = "Doesn't cause damage. On a succesful parry, the user of Riposte can knock back the original target one vicinity tier in any direction",
                    BaseForm = BaseAttackForms.Riposte
                },
                new Attack
                {
                    Name = "Drunken Master's Slash",
                    Description = "On a hit, the target becomes Distracted.",
                    BaseForm = BaseAttackForms.Slash
                },
                new Attack
                {
                    Name = "Drunken Master's Thrust",
                    Description = "On a hit, the target becomes Sickened.",
                    BaseForm = BaseAttackForms.Thrust
                },
                new Attack
                {
                    Name = "Drunken Master's Throw",
                    Description = "On hitting a target, the attacker becomes Swiftened.",
                    BaseForm = BaseAttackForms.Throw
                },
                new Attack
                {
                    Name = "Drunken Master's Trip",
                    Description = "Doesn't cause damage. On a hit, the target becomes Crippled and Slowed.",
                    BaseForm = BaseAttackForms.Trip
                },
                new Attack
                {
                    Name = "Drunken Master's Whirlwind",
                    Description = "Doesn't cause damage. When attacking, can attack all targets within Melee vicinity of the attacker. On a hit, a target becomes Pacified, but only against the attacker.",
                    BaseForm = BaseAttackForms.Whirlwind
                }
            };
        }
    }

    public class Dervish : AttacksSheet
    {
        public Dervish()
        {
            Name = "Dervish";
            Description = "Focuses on rapid, spinning attacks to strike multiple foes, making it effective at crowd control and dealing with multiple opponents simultaneously.";
            Type = FormType.Melee;
            Attacks = new List<Attack>
            {
                new Attack
                {
                    Name = "Dervish's Bash",
                    Description = "On a hit, can attack one more target within range using the same attack roll.",
                    BaseForm = BaseAttackForms.Bash
                },
                new Attack
                {
                    Name = "Dervish's Cleave",
                    Description = "When attacking, can attack two additional targets within Melee vicinity of the original target. On a hit, a target is inflicted with Bleeding.",
                    BaseForm = BaseAttackForms.Cleave
                },
                new Attack
                {
                    Name = "Dervish's Disarm",
                    Description = "Doesn't cause damage. On a hit, the target becomes Numb (Arm) and drops their weapon.",
                    BaseForm = BaseAttackForms.Disarm
                },
                new Attack
                {
                    Name = "Dervish's Guard Break",
                    Description = "Doesn't cause damage. On a hit, the target becomes Numb (Arm) and drops their shield (in case of Block) or weapon (in case of Riposte).",
                    BaseForm = BaseAttackForms.GuardBreak
                },
                new Attack
                {
                    Name = "Dervish's Killing Blow",
                    Description = "On a hit, the target becomes Numb (Arm). If the target is already Numb (Arm), they become Numb (Leg) instead.",
                    BaseForm = BaseAttackForms.KillingBlow
                },
                new Attack
                {
                    Name = "Dervish's Overhead Strike",
                    Description = "On a hit, the target becomes Numb (Leg).",
                    BaseForm = BaseAttackForms.OverheadStrike
                },
                new Attack
                {
                    Name = "Dervish's Restrain",
                    Description = "Doesn't cause damage. On a hit, the target becomes Numb (Leg) and Prone.",
                    BaseForm = BaseAttackForms.Restrain
                },
                new Attack
                {
                    Name = "Dervish's Riposte",
                    Description = "Doesn't cause damage. On a hit, the target becomes Numb (Leg) and Distracted.",
                    BaseForm = BaseAttackForms.Riposte
                },
                new Attack
                {
                    Name = "Dervish's Slash",
                    Description = "On a hit, the target becomes Numb (Leg).",
                }
            };
        }
    }

    public class AttacksSheet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FormType Type { get; set; }
        public List<Attack> Attacks { get; set; }
    }
}
