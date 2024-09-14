namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession EldritchCursed = new Profession
        {
            Name = "Eldritch-Cursed",
            Order = 57,
            ImageUrl = "images/professions/eldritch-cursed.png",
            Description1 = "The Eldritch-Cursed is a tragic figure, bearing the weight of an otherworldly curse that intertwines their fate with the eldritch forces beyond human comprehension. This curse grants them sinister, supernatural powers but at a great cost, making them both a blessing and a curse to their party. Their role in the group is that of the enigmatic and unpredictable magic wielder, capable of bending reality to their will while constantly grappling with the lurking horrors of their own curse.",
            Description2 = "In the midst of battle, the Eldritch-Cursed can draw upon the eldritch energies coursing through them to cast potent spells and harness otherworldly abilities. Their magic often carries unpredictable side effects, sometimes veering into the realm of chaos. One moment, they might conjure a devastating bolt of eldritch energy to obliterate their enemies, and the next, their curse might manifest as eerie whispers that unsettle their foes or disturbing visions that can offer cryptic insights. Their role in the party is that of the arcane powerhouse struggling to harness their dark powers while seeking a way to break free from the curse's grasp.",
            GrantedSkills = "",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Harbinger of Dissonance",
                Description = "You gain Eldritch Dissonance action.<br /><br />Eldritch Dissonance<br />AP Cost: 1<br />Restriction: Once per turn<br />You force a target enemy within Far vicinity of you that you can see to make a contested check against your Profession Skill. The effect that is bestowed upon the target if they fail depends on which specific Attribute check you force them to make:<br /><br />- Fortitude – You twist the target's vision about their own physical being. On failed contested check, the target needs to roll on Physical Injuries table.<br />- Reflex – You twist the target's perception of reality. The target gains 1 Wound and becomes Clumsy until the end of their next turn.<br />- Intellect – You twist the target's memories. The target becomes Confused until the end of their next turn.<br />- Charisma – You twist the target's confidence in themselves. The target becomes Frightened of a character or object of your choice within the target's line of sight until the end of their next turn.<br /><br />Once a target fails on a specific Attribute check, they become immune to that same Attribute check until you finish a Rest."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Immaterial Hunger",
                Description = "Whenever a humanoid fails a contested check against you, you immediately gain insight into a Knowledge they possess.<br /><br />You can then choose to steal that Knowledge for yourself. You can have any number of Knowledge pieces stolen this way, but they dissipate when you finish a Rest. While the Knowledge is stolen, the original target is considered to not have it.<br /><br />Whenever you choose to steal a Knowledge, you need to make a check with your Profession Skill to see whether you suffer from a Peril. Peril Rating for this check starts at 0 and increases by 3 for each stolen Knowledge you're in possession of. When you suffer from this Peril, you gain a level of Exhaustion."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Assistance from Beyond",
                Description = "Whenever you or a party member of yours taken an Exploration or a Rest Action, you can choose to immediately replace the results of the checks done as part of that Action with the maximum possible result for those checks.<br /><br />However, whenever you do so you need to make a check with your Profession Skill to see whether you suffer from a Peril. This Peril has a Peril Rating of 6. When you suffer from this Peril, you must immediately roll on Profane Injuries table."
            }
        };
    }
}
