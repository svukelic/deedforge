namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Vampire = new Profession
        {
            Name = "Vampire",
            Order = 46,
            ImageUrl = "images/professions/vampire.png",
            Description1 = "The Vampire is a haunting and enigmatic figure in the realm of adventurers. These nigh-immortal creatures of the night possess a unique blend of dark powers and seductive charisma. In a party, they often play the role of the alluring manipulator, using their mesmerizing abilities to gain information, sow discord among enemies, and even control the battlefield.",
            Description2 = "Vampires are notorious for their blood-drinking prowess, which grants them increased strength and vitality. They can deftly charm others, bending weaker-willed foes to their will and turning them into unwitting pawns. With a mere thought, a Vampire can transform into a swarm of bats, evading danger or launching surprise attacks on their enemies. In combat, their supernatural agility and strength make them formidable melee combatants. However, it's their strategic finesse that truly shines. Vampires excel at weakening adversaries by sapping their life force and creating chaos on the battlefield. They might mesmerize an enemy into turning against their allies, cloud the minds of guards to gain access to forbidden knowledge, or orchestrate an ambush by disappearing into the night and reappearing with a deadly strike. The Vampire's role in a party is that of the shadowy puppeteer, using their dark powers to control, deceive, and ultimately dominate both friend and foe, all while harboring their insatiable thirst for blood.",
            GrantedSkills = "",
            Limitations = "Considered to be Undead for all effects that explicitly target the Undead. You cannot lose any Wounds during the day, except through your Blood Drinker feature.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Blood Drinker",
                Description = "You gain Drink Blood action.<br /><br />AP Cost: 1<br />Restriction: Once per turn, can only target living humanoid characters with either Pacified, Stunned or Unconscious Status.<br />You attempt to drink blood from your target. Once this action is taken, it lasts until the start of your next turn. During this time, your target is also considered to be Restrained. If your target stops being Restrained before this action ends, it is considered that your attempt to drink blood has failed.<br /><br />If the action ends without interruptions, you lose 1 Wound and the target is inflicted 1 Wound (Profane). If you don't have any Wounds, you instead gain 1 Toughness Point. Number of Toughness Points you can have at the same time from this feature is equal to your Proficiency Tier in Fortitude. Additionally, drinking blood also satisfies conditions for your Blood-kin's Dark Hunger feature."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Vampiric Charm",
                Description = "While in a Social Encounter, you can attempt to charm people. This feature only works against humanoid targets.<br /><br />When you attempt to charm someone, the target needs to make a Charisma check contested by a Charisma Skill check of your choice. If the target fails the contested check, they become Pacified until the next time they take Rest.<br /><br />The nature of this action is immediately apparent to anyone witnessing it other than your target. If your target succeeds on the contested check, they are aware of what you attempted to do."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Bat Form",
                Description = "While in an Exploration Encounter, you can turn into a swarm of bats to scout or travel more efficiently. This Form grants you Upper Hand on all checks done as part of Scout or Map Area checks.<br /><br />While in Bat Form, you are considered to have Flying speed and you cannot be ambushed if you are traveling alone. If you are traveling as part of a Party, you instead gain immunity to Surprised Status while in this Form."
            }
        };
    }
}
