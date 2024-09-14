namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Forgemaster = new Profession
        {
            Name = "Forgemaster",
            Order = 20,
            ImageUrl = "images/professions/forgemaster.png",
            Description1 = "A Forgemaster is a skilled artisan who specializes in crafting weapons and armor from raw materials, using their knowledge of metallurgy and blacksmithing techniques. They are the master of the forge, and their creations are highly prized for their durability and quality. In a party, a Forgemaster is often the go-to person for improving the group's equipment or crafting new gear, making them a valuable asset in combat and exploration alike. They also have a keen eye for detail, which allows them to identify the weaknesses in enemy armor and weapons, giving their allies a tactical advantage.",
            Description2 = "In addition to their proficiency with the forge, Forgemasters also possess physical strength and durability, allowing them to wield heavy weapons and withstand powerful attacks. They may also have some knowledge of traps and explosives, which they can use to set up ambushes or breach enemy fortifications. The crux of their capabilities includes creating weapons with special properties. Overall, the Forgemaster's role in a party is to provide their allies with the tools they need to succeed, whether that means improving their armor and weapons, crafting special items, or using their own strength and skills to take down the enemy.",
            GrantedSkills = "Trained in either Arcana or Technology, Training in Heavy Armor",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Imbue Weapons",
                Description = "When you hit an enemy with a Weapon, you can spend one additional AP to imbue the attack with an additional effect. You can also use this feature as a Reaction when an ally of yours within 5m of you attacks an enemy using one of your Reforged items. You choose the additional effect from the following list:<br /><br />- Bleeding – The target enemy must make a Fortitude check contested by your choice of either Arcana or Technology roll. If they fail, they gain Imperiled (Physical) Status.<br />- Frost – The target enemy must make a Fortitude check contested by your choice of either Arcana or Technology roll. If they fail, they gain Freezing Status.<br />- Slow – The target enemy must make a Fortitude check contested by your choice of either Arcana or Technology roll. If they fail, they gain Slowed Status until the end of their next turn."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Mythic Quartermaster",
                Description = "You no longer need to take Bind Enchanted Item Rest Action in order to bind it to you, but rather you can do it as a simple action as long as you are touching the item. If done during the combat, this action costs 2 AP. As part of that same action you can also drop an existing binding to a different magic item occupying the same slot you are binding to.<br /><br />Additionally, you gain a special Knowledge (Relics). With this Knowledge, you have intimate knowledge about famous items, the stuff of legends, such as weapons and armors."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Forgemaster's Craft",
                Description = "You gain Reforge Rest Action.<br /><br />When you take Reforge Rest Action, you spend part of your Rest imbuing a non-Enchanted Item with power. When you do so, the target item becomes an Enchanted Item. You choose which particular Enchantment is bestowed. The target item also becomes immune to Broken Status.<br /><br />The number of Reforged items you can have at the same time and the maximum Enchantment Rarity is equal to your Proficiency Bonus in either Arcana or Technology."
            }
        };
    }
}
