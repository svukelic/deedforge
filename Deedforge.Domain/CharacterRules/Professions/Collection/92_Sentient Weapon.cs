namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession SentientWeapon = new Profession
        {
            Name = "Sentient Weapon",
            Order = 92,
            ImageUrl = "images/professions/sentient-weapon.png",
            Description1 = "The Sentient Weapon is a unique and enigmatic profession that is, in essence, a weapon with a consciousness. In a party, they bring an otherworldly and often eerie presence, as they are not just tools but sentient beings capable of wielding incredible power. These living weapons are masters of combat, drawing upon their supernatural abilities and deep understanding of weaponry to protect their allies and vanquish their foes.",
            Description2 = "Sentient Weapons have the ability to take over the bodies of their wielders, enhancing their combat prowess to an extraordinary degree. They possess not only the knowledge of countless battles but also an innate magical affinity that allows them to unleash devastating attacks. As sentient beings, they can communicate with others through telepathy, providing strategic insights and tactical advice during combat. Once established, the bond between a Sentient Weapon and their host is unbreakable. In a party, Sentient Weapons are formidable front-line combatants, often leading the charge against the most formidable adversaries. Their mastery of combat techniques and their ability to channel magic through their forms make them formidable adversaries. Whether it's cleaving through hordes of enemies with a single swing or unleashing powerful elemental blasts, the Sentient Weapon's presence on the battlefield is always a game-changer.",
            GrantedSkills = "",
            Limitations = "Cannot cast Spells except through Profession's features, cannot invest Skill Boost in Fortitude Skills, Reflex Skills, and Weaponry Skills other than Profession Skill",
            CombatFeature = new ProfessionFeature
            {
                Name = "Hungering Sentience",
                Description = "Whenever you are next to a corpse of an intelligent humanoid, you can choose to take over that body as your Host. Your old Host immediately and harmlessly crumbles to dust, and you gain full control of your new Host. While you have a Host, the body and the weapon are considered to be one and the same and utterly inseparable.<br /><br />When you take a new Host, the Guide will provide you with specific outline of Fortitude and Reflex Skill Proficiency Tiers the body possesses. However, no Fortitude or Reflex Skill can have Proficiency Tier higher than Proficiency Tier in your Profession Skill. Should the body have any Skill with Proficiency Tier higher than that, then Proficiency Tier is considered to be equal to the Proficiency Tier in your Profession Skill.<br /><br />Additionally, you also gain limited access to any Spells or special Actions that the Host possessed during life. These are for you known as Collected Abilities. Whenever you take a new Host, you can choose to store any number of their known Spells or special Actions as your Collected Abilities. You can have a maximum number of stored Collected Abilities equal to twice the Proficiency Tier in your Profession Skill. You use your Profession Skill when using any of the Collected Abilities.<br /><br />Your Collected Abilities persist even if you take a new Host."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Eldritch Consciousness",
                Description = "Insight checks done against you by anyone who doesn't have the ability to read minds automatically fail. You also have Upper Hand on all checks to read minds of intelligent creatures."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Collector of Memories",
                Description = "Whenever you take Study Rest Action, you can attempt to probe your Host's old memories for any remaining knowledge. Declare your Study Focus. The Guide determines if the chosen Study Focus is a Knowledge that the Host would have possessed during the life. If they have, you immediately gain that Knowledge.<br /><br />If you have at least one Knowledge obtained this way from your current Host, you also gain permanent Bolstered Status on all checks to pass as your Host."
            }
        };
    }
}
