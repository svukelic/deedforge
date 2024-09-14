namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Templar = new Profession
        {
            Name = "Templar",
            Order = 10,
            ImageUrl = "images/professions/templar.png",
            Description1 = "Templars are holy warriors who have devoted their lives to serving a divine cause. They wear heavy armor and wield weapons to defend their allies from evil forces. Their abilities are focused on healing and protection, and they have access to a variety of spells that can buff allies, smite enemies, and cleanse afflictions. In combat, Templars act as the frontline defenders, soaking up damage and protecting their more vulnerable allies.",
            Description2 = "For example, a Templar might rush into a group of enemies, shield raised, and start smiting them with divine power. As their allies fight alongside them, the Templar might heal any wounded comrades, cleanse them of poisons or curses, and buff them with spells that enhance their strength, speed, or defenses. Overall, Templars are a versatile and powerful class that can make a huge difference in any party, both on and off the battlefield.",
            GrantedSkills = "Trained in Charisma",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Templar's Piety",
                Description = "You have a pool of d4 dies that represent your Piety. These dies are known as Piety Dies, and the maximum number of these Dies in your pool is equal to your Proficiency Tier in Religion.<br /><br />Whenever you are targeted by an Attack and that Attack misses, you gain 1 Piety Die.<br /><br />With this feature, you gain access to Holy Smite.<br /><br />When you attempt to hit an enemy with an attack, you can choose to Smite them by spending and rolling a Piety Die. You add the result of that roll to that Weapon check. If the attack hits, the damage type changes into Hallowed."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Powerful Presence",
                Description = "Whenever you succeed on an Intimidation or a Persuasion check, the target also gains Taunted Status, although if you are not in Combat they are not under obligation to attack at all, they are just considered to be focused solely on you.<br /><br />Taunted creatures have Lower Hand on all contested checks against your party members."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Crusader's Path",
                Description = "Once you dedicate yourself to a goal, it is nigh impossible to turn you away from it. Whenever your party finishes Travel Exploration Action and rolls Event Die, you can allow your party to make that check twice, and choose which result to take.<br /><br />Additionally, when you use your Prayer Rest Action granted by the Cleric Archetype, you can now ask for Protection instead:<br /><br />- Protection – You ask your deity to help protect those you care about. Designate one ally that took Rest alongside you. That ally gains +2 AR until your next Rest. You can designate yourself as well, but in that case the granted bonus AR is halved."
            }
        };
    }
}
