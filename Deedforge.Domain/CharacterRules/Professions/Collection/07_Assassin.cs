namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Assassin = new Profession
        {
            Name = "Assassin",
            Order = 7,
            ImageUrl = "images/professions/assassin.png",
            Description1 = "Assassins are deadly and precise killers, trained in the art of stealth and deception. They are experts at infiltrating enemy territory, taking out key targets, and disappearing without a trace. These capabilities make them able to take down even the most heavily-guarded targets. In combat, they prefer to strike from the shadows, using surprise attacks to take their enemies off guard.",
            Description2 = "In a party, assassins serve as invaluable assets for stealth missions and covert operations. They excel at gathering information, taking out key targets, and disabling enemy defenses. While they may not be the strongest fighters in the group, their ability to take down enemies quickly and quietly can make all the difference in a battle.",
            GrantedSkills = "Trained in any two Agility Skills.",
            Limitations = "Cannot wear Medium or Heavy Armor.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Assassin’s Strike",
                Description = "You gain the following benefits:<br /><br />    - You can now take Attack action during Tactical Round, but only against targets with Surprised Status.<br />    - You have Upper Hand on all attacks against Surprised targets.<br />    - You keep your Hidden Status when taking the Move Action without needing to roll for it again, but your movement must end behind some sort of Obstacle.<br />"
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "TBD",
                Description = "TBD"
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Assassinate",
                Description = "TBD"
            }
        };
    }
}
