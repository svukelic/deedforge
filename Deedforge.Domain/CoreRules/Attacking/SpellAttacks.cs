using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deedforge.Domain.CoreRules.Attacking
{
    public static class SpellAttacks
    {
        public static AttackForm Bolt = new AttackForm
        {
            Name = "Bolt",
            Description = "A quick and focused attack that can pierce through defenses."
        };

        public static AttackForm Ward = new AttackForm
        {
            Name = "Ward",
            Description = "A defensive spell that can protect the caster from harm."
        };

        public static AttackForm Wave = new AttackForm
        {
            Name = "Wave",
            Description = "A wide and powerful attack that can hit multiple targets."
        };
    }
}
