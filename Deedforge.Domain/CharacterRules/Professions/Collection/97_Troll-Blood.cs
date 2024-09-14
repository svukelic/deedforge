namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession TrollBlood = new Profession
        {
            Name = "Troll-Blood",
            Order = 97,
            ImageUrl = "images/professions/troll-blood.png",
            Description1 = "The Troll-Blood is a formidable profession that carries within them the bloodline of trolls, granting them incredible regenerative abilities and brute strength. In a party, they serve as the vanguard, a near-unkillable force that can absorb immense damage and disrupt enemy formations. Troll-Bloods are known for their astounding resilience and the ability to rapidly heal from wounds. This remarkable regenerative power makes them exceptional frontline combatants, capable of enduring a barrage of attacks while relentlessly advancing on their foes.",
            Description2 = "A Troll-Blood's role in a party is that of the unyielding protector. They excel at drawing enemy fire and attention away from their allies, acting as a living shield while the rest of the party focuses on offense. In battles, they become living battering rams, charging into the fray with little concern for their own safety. Their ability to regenerate means they can endure sustained combat, outlasting opponents through sheer durability. Troll-Bloods can also unleash a primal rage, increasing their physical prowess and allowing them to unleash devastating melee attacks that can send multiple foes flying. In times of dire need, they can even tap into their troll blood's regenerative might to heal their allies or reattach severed limbs. With their indomitable spirit and ability to turn the tide of battle, the Troll-Blood is an invaluable asset to any adventuring party.",
            GrantedSkills = "Trained in Health",
            Limitations = "The Guide determines which creatures count as \"wildlings\" within the setting",
            CombatFeature = new ProfessionFeature
            {
                Name = "Regenerative Onslaught",
                Description = "Whenever you have a number of Wounds greater than or equal to half your Maximum Wounds, your regenerative abilities kick in. These only work if you are not Heavily Wounded.<br /><br />Outside of Combat, you lose a Wound every 1 minute.<br /><br />While in a Combat Encounter, at the start of each of your turns, you can choose which one effect to invoke from the following list:<br /><br />Additionally, once per Rest, when you start your turn Heavily Wounded, you can choose to invoke all three of the above effects."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Alpha Wildling",
                Description = "You gain a special Knowledge (Wildlings). With this Knowledge, you have an ability to communicate with sentient humanoids who live in the wilderness, no matter which form of communication they usually use.<br /><br />You also have Bolstered Status on all Charisma Skill checks against wildlings, and wildlings will usually be neutral towards you and your party, unless you give them a reason for hostility."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Bloodbrew",
                Description = "Your Health Skill now counts as Crafting Skill and contributes to Crafting Attribute.<br /><br />For each Proficiency Tier you have in Health, you learn two Crafting Recipes. These Recipes must be for items of either Potion or Poison type. When crafting these Recipes, you use your Health Proficiency Tier to determine the number of Progress Points you gain.<br /><br />However, instead of using Crafting Components when crafting these Recipes, you must use your own blood. Therefore, whenever you use Craft Rest Action, you gain 1 Wound."
            }
        };
    }
}
