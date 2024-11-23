using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deedforge.Domain.CoreRules
{
    public enum InjuryLocation
    {
        None,
        Arm,
        Leg,
        Eye,
        Ear,
        Heart,
        Liver,
        Brain,
        Lungs,
        Spine,
        Abdomen,
        Throat,
        Skin,
    }

    public class Injury
    {
        public string Name { get; set; }
        public InjuryLocation InjuryLocation { get; set; }
        public DamageType DamageType { get; set; }
        public Tuple<int, int> RollRange { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }
    }

    public class Injuries
    {
        #region Physical Injuries
        public static Injury Physical_Arm = new Injury
        {
            Name = "Broken Arm",
            InjuryLocation = InjuryLocation.Arm,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(1, 0),
            Description = "The character loses the use of their arm.",
            Effect = "Permanent Maimed condition."
        };

        public static Injury Physical_Leg = new Injury
        {
            Name = "Broken Leg",
            InjuryLocation = InjuryLocation.Leg,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(2, 0),
            Description = "The character loses the use of their leg.",
            Effect = "Permanent Crippled condition."
        };

        public static Injury Physical_Eye = new Injury
        {
            Name = "Blinded Eye",
            InjuryLocation = InjuryLocation.Eye,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(3, 0),
            Description = "The character loses the use of their eye.",
            Effect = "Permanent Lower Hand on all Awareness check relying on sight. If both eyes are injured, then permanent Blinded condition."
        };

        public static Injury Physical_Ear = new Injury
        {
            Name = "Deafened Ear",
            InjuryLocation = InjuryLocation.Ear,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(4, 0),
            Description = "The character loses the use of their ear.",
            Effect = "Permanent Lower Hand on all Awareness check relying on hearing. If both ears are injured, then permanent Deafened condition."
        };

        public static Injury Physical_Heart = new Injury
        {
            Name = "Damaged Heart",
            InjuryLocation = InjuryLocation.Heart,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(5, 0),
            Description = "The character's heart is damaged.",
            Effect = "Permanent Fatigued condition. Second heart injury results in death."
        };

        public static Injury Physical_Liver = new Injury
        {
            Name = "Damaged Liver",
            InjuryLocation = InjuryLocation.Liver,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(6, 0),
            Description = "The character's liver is damaged.",
            Effect = "Permanent Bleeding condition while in Combat. Second liver injury results in death if not healed within 24 hours."
        };

        public static Injury Physical_Brain = new Injury
        {
            Name = "Damaged Brain",
            InjuryLocation = InjuryLocation.Brain,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(7, 0),
            Description = "The character's brain is damaged.",
            Effect = "Permanent Stupefied condition. Second brain injury results in death."
        };

        public static Injury Physical_Lungs = new Injury
        {
            Name = "Damaged Lungs",
            InjuryLocation = InjuryLocation.Lungs,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(8, 0),
            Description = "The character's lungs are damaged.",
            Effect = "Permanent Slowed condition. Second lung injury results in death."
        };

        public static Injury Physical_Spine = new Injury
        {
            Name = "Damaged Spine",
            InjuryLocation = InjuryLocation.Spine,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(9, 0),
            Description = "The character's spine is damaged.",
            Effect = "Permanent Lower Hand on all Athletics checks and checks to resist being Pinned or Stunned. Second spine injury results in death."
        };

        public static Injury Physical_Abdomen = new Injury
        {
            Name = "Damaged Abdomen",
            InjuryLocation = InjuryLocation.Abdomen,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(10, 0),
            Description = "The character's abdomen is damaged.",
            Effect = "Permanently reduces Carrying Capacity by 2. Second abdomen injury results in death."
        };

        public static Injury Physical_Throat = new Injury
        {
            Name = "Damaged Throat",
            InjuryLocation = InjuryLocation.Throat,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(11, 0),
            Description = "The character's throat is damaged.",
            Effect = "Character's reach with his voice is limited to Close vicinity. Casting Spells costs one additional AP."
        };

        public static Injury Physical_Skin = new Injury
        {
            Name = "Damaged Skin",
            InjuryLocation = InjuryLocation.Skin,
            DamageType = DamageType.Physical,
            RollRange = new Tuple<int, int>(12, 0),
            Description = "The character's skin is damaged.",
            Effect = "Permanent Lower Hand on all Influence checks."
        };
        #endregion

        #region Poison Injuries
        public static Injury Poison_Neurotoxin = new Injury
        {
            Name = "Neurotoxin",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Poison,
            RollRange = new Tuple<int, int>(1, 2),
            Description = "The character's nerves are poisoned, causing them to twitch uncontrollably at random intervals.",
            Effect = "Permanent Sickened condition. Whenever the character rolls a 3 or less on a Base Die on a Movement-related check, they immediately fail that check and instead become Pinned until the start of their next turn."
        };

        public static Injury Poison_Hemotoxin = new Injury
        {
            Name = "Hemotoxin",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Poison,
            RollRange = new Tuple<int, int>(3, 4),
            Description = "The character's blood is poisoned, preventing it from clotting.",
            Effect = "Permanent Sickened condition. Whenever the character rolls a 3 or less on a Base Die on a contested check, they receive 1 damage."
        };

        public static Injury Poison_Myotoxin = new Injury
        {
            Name = "Myotoxin",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Poison,
            RollRange = new Tuple<int, int>(5, 6),
            Description = "The character's muscles are poisoned, causing them to weaken and deteriorate.",
            Effect = "Permanent Sickened condition. Whenever the character rolls a 3 or less on a Base Die on an Attack-related check, they immediately fail that check and instead become Maimed until the start of their next turn."
        };

        public static Injury Poison_Cytotoxin = new Injury
        {
            Name = "Cytotoxin",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Poison,
            RollRange = new Tuple<int, int>(7, 8),
            Description = "The character's cells break down, causing organ failure.",
            Effect = "Permanent Sickened condition. Whenever the character rolls a 3 or less on a Base Die, they lose benefits of any Boons they have until the start of their next turn."
        };

        public static Injury Poison_Pneumotoxin = new Injury
        {
            Name = "Pneumotoxin",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Poison,
            RollRange = new Tuple<int, int>(9, 10),
            Description = "The character's lungs are poisoned, making breathing difficult.",
            Effect = "Permanent Sickened condition. Whenever the character rolls a 3 or less on a Base Die on a Health check, they are considered to be Drowning until the start of their next turn."
        };

        public static Injury Poison_Immunotoxin = new Injury
        {
            Name = "Immunotoxin",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Poison,
            RollRange = new Tuple<int, int>(11, 12),
            Description = "The character's immune system is poisoned, leaving them vulnerable to diseases and infections.",
            Effect = "Permanent Sickened condition. Whenever the character rolls a 3 or less on a Base Die, they gain a random Poison Injury until they are treated with a DR6 Medicine check."
        };
        #endregion

        #region Acid Injuries
        public static Injury Acid_DamagedArmor = new Injury
        {
            Name = "Damaged Armor",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Acid,
            RollRange = new Tuple<int, int>(1, 3),
            Description = "The character's armor is damaged by acid.",
            Effect = "Maximum Endurance is halved."
        };

        public static Injury Acid_DamagedWeapon = new Injury
        {
            Name = "Damaged Weapon",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Acid,
            RollRange = new Tuple<int, int>(4, 6),
            Description = "The character's weapon is damaged by acid.",
            Effect = "Attack rolls with the affected weapon are halved."
        };

        public static Injury Acid_DamagedShield = new Injury
        {
            Name = "Damaged Shield",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Acid,
            RollRange = new Tuple<int, int>(7, 9),
            Description = "The character's shield is damaged by acid.",
            Effect = "Defense checks with the affected shield are halved."
        };

        public static Injury Acid_DamagedAdventuringItem = new Injury
        {
            Name = "Damaged Adventuring Item",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Acid,
            RollRange = new Tuple<int, int>(10, 12),
            Description = "The character's adventuring item is damaged by acid.",
            Effect = "A random equipped adventuring item is destroyed and cannot be used anymore."
        };
        #endregion

        #region Fire Injuries
        public static Injury Fire_Burning = new Injury
        {
            Name = "Burning",
            InjuryLocation = InjuryLocation.None,
            DamageType = DamageType.Fire,
            RollRange = new Tuple<int, int>(1, 12),
            Description = "The character is on fire.",
            Effect = "Inflicted with Burning."
        };
        #endregion

        #region Ice Injuries
        
        #endregion
    }
}
