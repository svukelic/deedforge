namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Sharpshooter = new Profession
        {
            Name = "Sharpshooter",
            Order = 8,
            ImageUrl = "images/professions/sharpshooter.png",
            Description1 = "Sharpshooters are masters of ranged combat, using their exceptional marksmanship skills to take down enemies from afar. They specialize in a variety of ranged weapons, such as bows, crossbows, and firearms, and can hit targets with precision and deadly force. Whether they're shooting down enemies from the safety of a rooftop or taking down a charging foe with a well-placed shot, sharpshooters are an essential part of any adventuring party.",
            Description2 = "In addition to their deadly accuracy, sharpshooters also possess a keen eye for spotting enemies at a distance and can often provide valuable information to their allies. They excel at scouting and can use their range advantage to provide covering fire for their party members during combat. With their combination of lethal accuracy, keen perception, and tactical savvy, sharpshooters are an indispensable asset to any adventuring party looking to stay one step ahead of their enemies.",
            GrantedSkills = "Trained in Perception",
            Limitations = "Cannot wear Heavy Armor",
            CombatFeature = new ProfessionFeature
            {
                Name = "Steady Hand",
                Description = "Whenever you hit with a weapon attack or succeed on a contested Reflex check, you can choose to perform one of the following actions at no AP cost:<br /><br />- Make a Perception Check.<br />- Reload an equipped Weapon (if applicable).<br />- Take a Weapon Attack action with an equipped Thrown Weapon against a target in range.<br />- Take an Archetype-granted Action (a Combat Technique that doesn't inflict Wounds for a Warrior, Find Weakspot for a Rogue, and Track Foe for a Ranger)."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Sharpshooter's Instinct",
                Description = "While in a Social Encounter, you and your party cannot get Surprised and you have Upper Hand on all Perception checks."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Far Sight",
                Description = "While in an Exploration Encounter, you automatically take Scout Exploration Action at each Rest, alongside any other Exploration Action you want to take."
            }
        };
    }
}
