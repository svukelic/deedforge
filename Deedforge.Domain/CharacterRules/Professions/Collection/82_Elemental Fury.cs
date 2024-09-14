namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession ElementalFury = new Profession
        {
            Name = "Elemental Fury",
            Order = 82,
            ImageUrl = "images/professions/elemental-fury.png",
            Description1 = "The Elemental Fury is a formidable force of nature incarnate, wielding the raw power of the elements with unrivaled mastery. Their role in the party is that of a living tempest and a versatile combatant. With the ability to harness the elemental forces of fire, water, earth, and air, they are a walking cataclysm, capable of unleashing devastating spells and manipulating the environment to their advantage.",
            Description2 = "In the heat of battle, the Elemental Fury can call upon the fury of the elements to conjure fiery infernos, freezing blizzards, seismic tremors, or raging storms. Their dramatic abilities include summoning walls of fire to scorch foes, creating tidal waves to drown enemies, forming earthen barriers to shield allies, or unleashing tornadoes that tear through opposition. They can also channel elemental energies into their weaponry, turning a simple strike into a blazing or electrifying assault. Whether it's raining meteors from the sky or causing the ground to tremble beneath their enemies' feet, the Elemental Fury's command over the elements makes them a devastating force on the battlefield, capable of turning the tide of any encounter.",
            GrantedSkills = "Trained in Nature",
            Limitations = "Cannot cast Spells",
            CombatFeature = new ProfessionFeature
            {
                Name = "Cataclysmic Harbinger",
                Description = "You gain Unleash Cataclysm action.<br /><br />Unleash Cataclysm<br />AP Cost: 2<br />Restriction: Once per turn<br /><br />You unleash an elemental Area Effect centered on yourself affecting all creatures within Near vicinity of you. You choose whether you want to enact an Offensive or Assistive effect, and you choose which element you are invoking.<br /><br />In case of Offensive effect, all affected creatures must make a Reflex check contested by your Nature check. Creatures that fail the check have a debilitating effect inflicted on them.<br /><br />In case of Assistive effect, all friendly characters receive a beneficial effect.<br /><br />All listed effects last until the start of your next turn.<br /><br />However, whenever you use this ability, you must make a Nature check to see whether you suffer from Peril. Peril Rating for this check is equal to 2 + number of creatures affected.<br /><br />When you suffer from this Peril, you are inflicted the Offensive effect of the invoked element."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Elemental Teachings",
                Description = "While in a Social Encounter, you can choose to invoke the teachings of one of the elements, creating an aura that spreads from you.<br /><br />When you activate this aura, you need to make a Nature check against DR defined by the Guide.<br /><br />If you succeed on that check, all creatures within Near vicinity of you, including you, are affected by the aura's effect. The specific effect depends on the invoked element.<br /><br />However, you need to maintain the aura on your turn, repeating the check every time.<br /><br />- Fire – Fire teaches you the importance of action and passion. Affected creatures become Enraged.<br />- Ice – Ice teaches you the importance of calmness and patience. Affected creatures become Pacified.<br />- Lightning – Lightning teaches you the importance of sheer power. Affected creatures become Deafened and Distracted.<br />- Earth – Earth teaches you the importance of finding your place in the world. Affected creatures become Restrained."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Master of Elements",
                Description = "You gain Subdue Elements Exploration Action.<br /><br />When you take Subdue Elements Exploration Action, you attempt to bend the elements to your will.<br /><br />Make a Nature check against Exploration DR. On success, your entire party ignores any Exploration DR increases caused by Weather condition until the next Rest."
            }
        };
    }
}
