namespace Deedforge.Domain.CharacterRules.Professions
{
    public class Profession
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string GrantedSkills { get; set; }
        public string Limitations { get; set; }
        public ProfessionFeature CombatFeature { get; set; }
        public ProfessionFeature SocialFeature { get; set; }
        public ProfessionFeature RespiteFeature { get; set; }
        public string OrderRoman
        {
            get
            {
                return ToRoman(Order);
            }
        }

        private string ToRoman(int number)
        {
            if (number < 1) return string.Empty;

            var romanNumerals = new[]
            {
            new { Value = 1000, Numeral = "M" },
            new { Value = 900, Numeral = "CM" },
            new { Value = 500, Numeral = "D" },
            new { Value = 400, Numeral = "CD" },
            new { Value = 100, Numeral = "C" },
            new { Value = 90, Numeral = "XC" },
            new { Value = 50, Numeral = "L" },
            new { Value = 40, Numeral = "XL" },
            new { Value = 10, Numeral = "X" },
            new { Value = 9, Numeral = "IX" },
            new { Value = 5, Numeral = "V" },
            new { Value = 4, Numeral = "IV" },
            new { Value = 1, Numeral = "I" }
        };

            var result = string.Empty;
            foreach (var item in romanNumerals)
            {
                while (number >= item.Value)
                {
                    result += item.Numeral;
                    number -= item.Value;
                }
            }

            return result;
        }
    }
}
