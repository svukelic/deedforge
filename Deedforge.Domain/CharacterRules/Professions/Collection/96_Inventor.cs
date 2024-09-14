namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Inventor = new Profession
        {
            Name = "Inventor",
            Order = 96,
            ImageUrl = "images/professions/inventor.png",
            Description1 = "The Inventor is a brilliant and innovative mind among adventurers, specializing in crafting ingenious contraptions and devices to overcome various challenges. Their role within a party is that of the ingenious problem-solver and creator of unconventional solutions. Inventors bring a mix of creativity and technical prowess to the group, using their unique gadgets and inventions to both support allies and thwart adversaries.",
            Description2 = "In a party, Inventors serve as the creative masterminds, capable of turning seemingly ordinary materials into extraordinary inventions. They are the ones who can fashion devices on the fly, such as makeshift bridges, traps, or explosive gadgets, to navigate treacherous terrain or outsmart enemies. Inventors are renowned for their ability to craft ingenious tools that can heal wounds, disable traps, or disrupt magical effects. These tinkerers can also construct combat-oriented contraptions like clockwork allies, remote-controlled drones, or powerful siege engines that unleash havoc upon the battlefield. Inventors often carry a variety of tools and spare parts, ready to assemble the perfect solution for any predicament. Their boundless ingenuity and knack for invention make them the ultimate utility experts in an adventuring party, ensuring that no problem is too complex to overcome.",
            GrantedSkills = "Trained in Crafting",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Hybrid Arsenal",
                Description = "You have learned how to combine different weapons into one, gaining access to a Hybrid Weapon. When attacking with your Hybrid Weapon, you choose with which of the two combined weapons you want to attack, and the weapons maintain their separate properties, additional effects, enchantments, etc.<br /><br />You use your Crafting Attribute to make Weapon Attack checks with your Hybrid Weapon. You also gain access to a second Hybrid Weapon if you have Master Proficiency Tier in your Profession Skill.<br /><br />One of the two combined weapons must be either a Magic Weapon (if your Profession Skill is Arcana), or a Ranged Weapon with Firearm property (if your Profession Skill is Technology).<br /><br />Additionally, you gain Hybridize Weaponry Rest Action.<br /><br />When you take Hybridize Weaponry Rest Action, you spend part of your Rest re-assembling your Hybrid Weapon. You combine two weapons to which you have access, following previously stated conditions."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Patent Genius",
                Description = "You gain a special Knowledge (Innovations). With this Knowledge, you have an innate ability to at least roughly understand how complex inventions function. This includes various advanced machinery, magical constructs, complex magical rituals, etc.<br /><br />Whenever you succeed on a Crafting check or Intellect Skill check to analyze and understand such an object, it counts as if you took Study Rest Action with the Study Focus being, as deemed by the Guide, an area of expertise relevant to the analyzed object."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Augmented Crafting",
                Description = "Whenever you take Craft Rest Action, you now earn additional Progress Points. The amount is equal to the Proficiency Tier value in your Profession Skill."
            }
        };
    }
}
