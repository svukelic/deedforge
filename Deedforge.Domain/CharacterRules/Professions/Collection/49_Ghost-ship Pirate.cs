namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession GhostShipPirate = new Profession
        {
            Name = "Ghost-ship Pirate",
            Order = 49,
            ImageUrl = "images/professions/ghost-ship-pirate.png",
            Description1 = "The Ghost-ship Pirate is a legend among sailors, a spectral marauder who haunts the high seas aboard a ghostly vessel. Their unique connection to this ethereal warship grants them a sinister edge and an air of eerie mystery. In a party, they often serve as the enigmatic navigators of the supernatural, wielding the powers of the spirit world to control their phantom ship and command the restless souls that dwell within.",
            Description2 = "At the heart of the Ghost-ship Pirate's abilities lies their spectral vessel, a ship that is more than just wood and canvas. This ghostly craft can materialize and dematerialize at will, appearing out of the mist to ambush unsuspecting foes or slipping through solid obstacles to evade pursuers. The ship is crewed by vengeful spirits, cursed souls who serve the Ghost-ship Pirate with unwavering loyalty. These restless entities swarm enemies in combat, overwhelming them with ghostly attacks or dragging them into the eerie depths below. The Ghost-ship Pirate's role in a party is one of eerie intrigue and supernatural power, as they navigate treacherous waters, commune with otherworldly entities, and command a vessel that exists both in the realm of the living and the domain of the dead. Whether it's harnessing the spectral winds to gain a supernatural speed boost or unleashing a ghostly barrage of cannon fire, the Ghost-ship Pirate brings an otherworldly presence to any adventuring group.",
            GrantedSkills = "",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Accursed Cannon-fire",
                Description = "You gain Accursed Cannon-fire action.<br /><br />AP Cost: 2<br />Restriction: Once per turn<br />Accursed Cannon-fire is a special Attack which is treated as if it's an Attack with a Ranged Weapon. It is considered to have Heavy, Firearm, Reload, and Sunder properties.<br /><br />Additionally, this Attack also explodes, affecting and prompting Reflex check from all targets within Melee vicinity of the target location."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Part of the Crew",
                Description = "You gain a special Knowledge (Sea Secrets). With this Knowledge, you have an innate knowledge of variety of secrets buried at sea, such as historical disappearances, stories about treasures, legendary pirates and sailors, sea-related curses, etc.<br /><br />Additionally, when talking to sailors and other seafarers, you automatically have intimate knowledge of the goal, ship name and the general path of their last ship voyage."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Part of the Ship",
                Description = "Any Naval Vehicle you are on is always considered to be fully crewed.<br /><br />The vehicle also cannot have its movement speed reduced by any magical mean, and it automatically repairs damage every time you take Rest on it. Repaired damage is equal to number of d4 dices equal to vehicle's Size.<br /><br />Additionally, you have Upper Hand on all Skill checks done as part of a Rest or Exploration action while on a Naval Vehicle."
            }
        };
    }
}
