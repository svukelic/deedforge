namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession WeaponMaster = new Profession
        {
            Name = "Weapon Master",
            Order = 27,
            ImageUrl = "images/professions/weapon-master.png",
            Description1 = "The Weapon Master is a combat specialist who has honed their skills to perfection, mastering the art of seamlessly switching between an arsenal of weapons with unmatched precision. These warriors are true maestros on the battlefield, capable of adapting to any situation by wielding a diverse array of arms. In the heat of combat, they can effortlessly transition from a massive two-handed sword to a nimble dagger, exploiting their opponents' weaknesses with relentless ferocity. Weapon Masters are the embodiment of versatility, their expertise granting them the ability to disarm, incapacitate, or eliminate foes with calculated finesse.",
            Description2 = "In a party, the Weapon Master plays a pivotal role as the group's primary combatant and damage dealer. Their unmatched proficiency with various weapon types allows them to fill multiple combat roles, adapting to the ever-changing threats encountered during adventures. Whether it's holding the front line with a shield and sword, delivering devastating ranged attacks with a crossbow, or infiltrating enemy ranks with stealth and daggers, the Weapon Master can be counted on to deliver precise strikes and turn the tide of battle. Their versatility also extends to their ability to teach and mentor others, making them valuable allies for party members seeking to enhance their combat skills.",
            GrantedSkills = "",
            Limitations = "Cannot cast Spells",
            CombatFeature = new ProfessionFeature
            {
                Name = "Art of Battle",
                Description = "Whenever you hit an enemy with a weapon attack, instead of inflicting a Wound you can choose to inflict a Status which lasts until the end of their next turn.<br /><br />The specific Status depends on what kind of weapon you used to hit them:<br /><br />- Magic Weapons – Sickened<br />- Simple & One-handed Weapons – Clumsy<br />- Ranged Weapon with Firearm Property – Blinded<br />- Ranged Weapons without Firearm Property – Stupefied<br />- Two-handed Weapon with Reach Property – Crippled<br />- Two-handed Weapons without Reach Property – Fatigued<br /><br />Additionally, whenever you hit an enemy with a weapon, you can immediately take Swap Weapon action at no AP cost."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Virtue of Patience",
                Description = "While in a Social Encounter, you have Upper Hand on all contested checks you were forced to make, but also have Lower Hand on all contested checks that you initiated."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Student of War",
                Description = "Whenever you finish a Rest, you can choose one piece of Knowledge that you possess. The Knowledge needs to be about a specific type, group or organization of creatures, which are then referred to as your Antagonists. Until your next Rest, you have Bolstered Status on all attacks against all Antagonists.<br /><br />Additionally, whenever you take Study Rest Action with a focus pertaining to war history, combat, weapons, tactics, etc., you can use your Proficiency Tier in Weaponry instead of Intellect to determine the number of Study Points you gain."
            }
        };
    }
}
