namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession SteamBallistician = new Profession
        {
            Name = "Steam Ballistician",
            Order = 75,
            ImageUrl = "images/professions/steam-ballistician.png",
            Description1 = "The Steam Ballistician is a highly specialized profession that combines the art of marksmanship with the ingenuity of steam-powered technology. Their role in a party is to provide long-range firepower, striking down enemies with incredible precision and devastating force. Armed with steam-powered rifles and ingenious gadgets, Steam Ballisticians are masters of ranged combat, capable of hitting targets at incredible distances. Their weapons fire powerful, high-velocity rounds that can pierce through armor and barriers, making them invaluable in battles against heavily fortified opponents.",
            Description2 = "In a party, the Steam Ballistician takes on the role of a sniper and artillery expert. They excel at engaging foes from a safe distance, picking off key targets with precision shots. With their steam-powered rifles, they can fire a variety of specialized rounds, from explosive shells that create devastating area-of-effect damage to armor-piercing rounds that can take down heavily armored foes. Beyond their marksmanship, Steam Ballisticians are also proficient engineers, able to repair and maintain their unique weaponry on the fly. The Steam Ballistician's presence in a party ensures that no enemy is safe from their relentless, long-range onslaught.",
            GrantedSkills = "Trained in Technology",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Steam-Powered Arsenal",
                Description = "You have access to a special Steam-Powered Weapon which can be configured in different, distinct ways to provide different modes of attack.<br /><br />You use Technology checks when making attack checks with your Steam-Powered Weapon. The Weapon, due to its advanced design, has Weight of 2 and always requires two hands to be used. You also gain access to a second Steam-Powered Weapon if you have Master Proficiency Tier in Technology.<br /><br />You gain Configure Steam-Powered Weapon Rest Action.<br /><br />When you take Configure Steam-Powered Weapon Rest Action, you spend part of your Rest adapting your Steam-Powered Weapon to a specific mode, listed in the table below."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Canny Engineer",
                Description = "Any Adventuring Item that you crafted that has a single use now can be used twice.<br /><br />While in a Social Encounter, you have Bolstered Status on all checks done as part of using an Adventuring Item that you crafted."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Deft Repairman",
                Description = "When crafting items, you can use your Technology Proficiency Tier to determine the number of Progress Points you gain, no matter which Crafting Skill the recipe belongs to.<br /><br />Additionally, when taking Repair Rest Action, the number of dice you roll to determine how much damage you repair is tripled."
            }
        };
    }
}
