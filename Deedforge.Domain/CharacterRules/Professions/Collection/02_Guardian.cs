namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Guardian = new Profession
        {
            Name = "Guardian",
            Order = 2,
            ImageUrl = "images/professions/Guardian.png",
            Description1 = "Guardians are stalwart protectors, often trained for combat and dedicated to defending others. They stand firm in the face of danger, shielding their allies from harm and striking back at those who would threaten them. Whether they are defending a person, a place, or an ideal, Guardians use their strength, their weapons, and their unwavering courage to hold the line.",
            Description2 = "In a party, Guardians are the first line of defense, rushing into battle to draw the enemy’s attention away from their more vulnerable allies. They are experts at using their bodies and their armor to absorb blows, allowing their comrades to strike at the enemy from a safe distance. Guardians often use shields or heavy armor to protect themselves and their allies, and they are skilled at knocking down foes or pushing them away to create space. In dire situations, a Guardian may even sacrifice themselves to save their companions, stepping in front of a fatal blow or shielding others from an explosion. The courage and selflessness of Guardians are what make them indispensable members of any party.",
            GrantedSkills = "Trained in Defense and one more Fortitude Skill.",
            Limitations = "None.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Shield Bash",
                Description = "Any shield that you have equipped is also considered a weapon with Light Weapon Design and Bash Attack, and your other weapon doesn't need to be a Light weapon in order for you to have it equipped alongside your Shield.<br /><br />Additionally, you can enter a Protective Stance by spending 1 AP. The Stance lasts until the start of your next turn, during which you gain the following effects:<br />- You have Upper Hand on all Defense Checks.<br />- Your Movement Speed is halved."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "TBD",
                Description = "TBD"
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "TBD",
                Description = "TBD"
            }
        };
    }
}
