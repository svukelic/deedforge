namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession LivingWeapon = new Profession
        {
            Name = "Living Weapon",
            Order = 78,
            ImageUrl = "images/professions/living-weapon.png",
            Description1 = "The Living Weapon is a true marvel of adaptability and versatility, capable of transforming their very body into an array of lethal armaments. Their unique talent allows them to serve as the party's Swiss army knife of combat, ever-ready to adapt to any situation. With a thought, they can shift their limbs into a deadly arsenal, from razor-sharp blades to devastating blunt instruments. Their role in a party is that of the ultimate combat specialist, able to provide solutions to a wide range of challenges.",
            Description2 = "In battle, a Living Weapon can seamlessly transition from offense to defense, crafting shields and armor from their own body or unleashing a relentless barrage of attacks with newfound weapons. They are the embodiment of adaptability, capable of taking on any foe and overcoming obstacles with ease. Their dramatic examples include forming a set of impenetrable armor to protect their allies from a dragon's fiery breath, morphing their limbs into powerful siege weapons to breach enemy fortifications, or transforming into a whirlwind of blades to decimate waves of adversaries. The Living Weapon is the party's answer to versatility in combat, always prepared to evolve their body into whatever weapon is needed to emerge victorious.",
            GrantedSkills = "",
            Limitations = "Cannot cast Spells",
            CombatFeature = new ProfessionFeature
            {
                Name = "Combat Adaptations",
                Description = "You have the ability to shape your body to various weaponry and armors. You can have up to three of these adaptations simultaneously. Activating an adaptation costs 1 AP, and you can activate or change any number of adaptation.<br /><br />- Weapon Adaptation – You transform one of your hands into any weapon that doesn't require two hands to be used (except an Exotic weapon, unless you have Exotic Weapon Training for that weapon). You use your Health Skill for attacks with these weapons.<br />- Shield Adaptation – You transform one of your hands into any type of shield.<br />- Armor Adaptation – You cover your skin with any type of armor. You can have only one Armor Adaptation active."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Consume Identity",
                Description = "You have the ability to consume corpses of humanoids no older than 7 days. When you do so, you gain access to the deceased person's likeness, voice, and general memories that allow you to adopt their identity.<br /><br />You can have a limited number of consumed identities stored. This number is equal to your Proficiency Tier in Health.<br /><br />At any given time, you can transform your likeness into that of one of stored identities. If done while in combat, this action costs 1 AP. If done while out of sight of anyone other than your party member, you also gain Hidden Status which lasts until you out yourself in any way (as deemed by the Guide)."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Rapid Regrowth",
                Description = "Whenever you take Recuperate Rest Action, in addition to its regular effects, you also gain your choice of one of the following effects:<br /><br />- You lose an additional 1d4 worth of Wounds.<br />- You regrow all your missing body parts, curing any such Severe Injuries in the process.<br />- You immediately lose 1d4 non-Severe Injuries."
            }
        };
    }
}
