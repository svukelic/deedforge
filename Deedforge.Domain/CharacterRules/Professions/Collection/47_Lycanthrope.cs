namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Lycanthrope = new Profession
        {
            Name = "Lycanthrope",
            Order = 47,
            ImageUrl = "images/professions/lycanthrope.png",
            Description1 = "The Lycanthrope is a formidable and enigmatic profession, characterized by their unique ability to shift between human and animal forms, harnessing the primal power of lycanthropy. In a party, they are often the embodiment of duality, capable of seamlessly transitioning from a skilled human to a ferocious beast. In their human form, Lycanthropes are adept trackers, masterful hunters, and keen strategists. They use their intellect to decipher clues, scout ahead, and make tactical decisions, ensuring their party navigates the wilderness and confronts foes with precision.",
            Description2 = "When the moon rises or battle calls for it, Lycanthropes undergo a mesmerizing transformation, shifting into a powerful animal form, such as a wolf, bear, or panther. In this state, their physical prowess skyrockets, and they become agile, savage combatants. Their senses sharpen, allowing them to detect hidden threats and ambushes. The Lycanthrope's role in a party often revolves around versatility – they can serve as trackers, frontline warriors, or scouts, adapting to the needs of the group. Whether stalking prey through moonlit forests or tearing through enemy ranks with primal fury, Lycanthropes are adventurers bound to the untamed forces of nature.",
            GrantedSkills = "",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Feral Form",
                Description = "You can now use your Blood-kin's Monstrous Form feature as many times as you want.<br /><br />When you transform, you also gain Fangs and Claws Natural Weapons, and Night Vision.<br /><br />However, the transformation is now more extreme and painful. Whenever the transformation ends, you must immediately roll on Physical Injuries table."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Pack Hunter",
                Description = "While in a Social Encounter, whenever you take an Action and if an ally of yours has previously taken an Action that directly helped your Action, you subtract additional 1d6 from the current Complexity.<br /><br />Additionally, whenever you activate your Blood-kin's Monstrous Form while in a Social Encounter, you inflict Frightened Status on all characters that are not your allies and that can see you transform."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Supernatural Senses",
                Description = "Whenever you take Forage Rest Action, you can choose to either gain Upper Hand on all checks done as part of Forage, or take Scout Exploration Action."
            }
        };
    }
}
