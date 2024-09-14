namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Spellblade = new Profession
        {
            Name = "Spellblade",
            Order = 6,
            ImageUrl = "images/professions/spellblade.png",
            Description1 = "In the swirling maelstrom of battle, where magic and steel clash in a deadly dance, the Spellblade stands as a unique fusion of might and mysticism. They are the arcane warriors, the mages who wield sword and spell with equal proficiency, a living testament to the harmony of physical prowess and magical power. With a blade in one hand and arcane energy crackling in the other, a Spellblade is a sight to behold on the battlefield. They might charge into the fray, their sword wreathed in flames, cutting down enemies with fiery strikes, or stand their ground against a charging beast, their raised hand unleashing a bolt of lightning that sends the creature sprawling.",
            Description2 = "But the Spellblade's versatility extends beyond their ability to deal damage. They are the adaptable core of any adventuring party, capable of filling multiple roles as the situation demands. With their blend of martial training and arcane knowledge, they can serve as frontline fighters, ranged damage dealers, or even support casters. One moment, they might be at the forefront of the battle, their magic-enhanced blade clashing against an enemy's weapon. The next, they could be at the backlines, their hands weaving complex arcane gestures as they cast a spell to heal their allies or shield them from harm. In essence, the Spellblade is the bridge between the physical and the mystical, a versatile and invaluable asset to any party, capable of adapting to any challenge that comes their way.",
            GrantedSkills = "",
            Limitations = "Cannot wear Heavy Armor",
            CombatFeature = new ProfessionFeature
            {
                Name = "Arcane Strike",
                Description = "You gain Arcane Strike action.<br /><br />Arcane Strike<br />AP Cost: 1 (2 for Weapons with Heavy property)<br />Restriction: Once per turn<br />You cast a Spell and immediately deliver it through a weapon attack with an equipped weapon. On that attack's hit, the target suffers all the effects as if you took Attack action, and also suffers the effects of the Spell. If the Spell asks for a contested check, the hit target automatically fails it. On attack miss, the Spell is lost."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Phasewalk",
                Description = "You have an ability to teleport short distances, up to 10 meters. You need to have the target location in line of sight and direct, unobstructed path to it.<br /><br />Whenever you use this ability, you must make a check with your Spellcasting Skill to see whether you suffer from a Peril as if you cast a Spell. The Peril Rating for this Peril is equal to 4 (or 6 if you are in a Combat Encounter)."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Mystic Raider",
                Description = "You have an innate ability to sense hidden magics in your vicinity. You feel the presence of any item, wall or passage that was made invisible or somehow hidden through usage of magic within Near vicinity of you.<br /><br />Whenever you take Scout Exploration Action, you can instead make a check with your Spellcasting Skill. On success, you gain the usual benefits of the action, as well as gain insight into direction of any powerful magics within a specific radius from the party. That radius is number hexes equal to your Proficiency Tier in the Skill used to make the check."
            }
        };
    }
}
