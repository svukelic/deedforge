namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Valkyrie = new Profession
        {
            Name = "Valkyrie",
            Order = 63,
            ImageUrl = "images/professions/valkyrie.png",
            Description1 = "The Valkyries are legendary warriors which embody bravery, honor, and a deep connection to the divine. Valkyries are fierce combatants, clad in gleaming armor and wielding powerful weapons, but they also possess a unique ability to guide fallen souls to the afterlife. They are often seen as the protectors of their party, ensuring that their comrades' spirits remain unbroken in the face of adversity.",
            Description2 = "On the battlefield, a Valkyrie is a force to be reckoned with. They charge into combat with an unmatched ferocity, their weapons cleaving through foes with divine precision. With the power to call upon the blessings of the gods, they can protect their allies, turning the tide of battle in their favor. Their role in the party is that of a guardian and a leader, inspiring their comrades with courage and valor. They uphold the principles of honor and sacrifice, ensuring that the party's legacy will be remembered for generations to come.",
            GrantedSkills = "",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Divine Gift of Battle",
                Description = "While in a Combat Encounter, when you see an enemy declare an attack, you can as a Reaction spend one of your Tokens to bestow either an empowering gift upon a targeted ally or a debilitating effect upon the triggering enemy within Near vicinity that you can see. The bestowed effect depends on the type of the Token spent:<br /><br />- Courageous – The target ally gains a divine shield that grants them Resistance to all damage and prevents them from becoming Heavily Wounded. The shield lasts until the end of their next turn.<br />- Cowardly – The target enemy gains Burdened Status until the end of their turn."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Guide of the Fallen",
                Description = "While touching a corpse of an intelligent humanoid, you can immediately gain insight into circumstances of their death. The Guide determines specific information you gain, some of which may be vague or obfuscated. You additionally learn whether the person overall led a Courageous life or a Cowardly life.<br /><br />If the corpse was dead for no more than 7 days, you can also choose to guide the soul of that person to afterlife. If you do so, you gain either a Courageous Token or a Cowardly Token, depending on the type of life they led.<br /><br />You can have up to 3 of these Tokens at the same time."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Divine Gift of Rest",
                Description = "When you start a Rest, you can choose to spend one of your Tokens to bestow a rejuvenating gift upon an ally of yours which is also taking a Rest. The bestowed effect depends on the type of the Token spent:<br /><br />- Courageous – The target ally loses 2d4 levels of Exhaustion.<br />- Cowardly – The target ally loses 1d4 Wounds.<br /><br />If you do not spend any Token during a Rest, you instead gain a Token of your choice."
            }
        };
    }
}
