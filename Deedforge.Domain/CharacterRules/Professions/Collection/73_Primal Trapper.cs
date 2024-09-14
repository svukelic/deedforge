namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession PrimalTrapper = new Profession
        {
            Name = "Primal Trapper",
            Order = 73,
            ImageUrl = "images/professions/primal-trapper.png",
            Description1 = "The Primal Trapper is a resourceful and tenacious survivalist, skilled in the art of trapping and crafting from the spoils of the natural world. In an adventuring party, their role is that of a versatile and self-reliant scout, capable of navigating the wilderness, providing sustenance, and setting deadly traps for unsuspecting foes.",
            Description2 = "Within a party, Primal Trappers excel as pathfinders and guides, using their deep knowledge of the wilderness to lead their companions safely through untamed terrain. They are adept at foraging for food and resources, ensuring that the party can sustain themselves during long journeys or while isolated in the wild. Primal Trappers are also skilled hunters, able to set traps that incapacitate or eliminate threats, making them invaluable for perimeter defense or ambush tactics. Their expertise extends to crafting weapons and armor from the hides and bones of fallen creatures, providing the party with unique and powerful gear tailored to their needs. Whether it's leading the way through dense forests, securing a campsite, or unleashing a barrage of deadly traps, the Primal Trapper's resourcefulness and knowledge of the wild make them an indispensable asset to any adventuring party.",
            GrantedSkills = "Trained in Leatherworking",
            Limitations = "Cannot use any weapon or armor that wasn't crafted with the Behemoth's Bounty feature",
            CombatFeature = new ProfessionFeature
            {
                Name = "Big-Game Hunter",
                Description = "Your expertise as a hunter has taught you a number of useful tricks and abilities.<br /><br />- Behemoth Wrangler. Creatures larger than you do not gain any benefits from their size when targeting you or the traps that you set, or when trying to resist effects from the traps that you set.<br />- Primal Preparations. You have Resistance on all attacks against creatures that you have specific Knowledge of.<br />- Trapper's Craft. You can use your Survival checks when attacking the target of your Track Foe action granted by the Ranger Archetype. However, you cannot use that action again until either your target is dead or you finish a Rest."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Beast Whisperer",
                Description = "You have permanent Bolstered Status on all Animal Handling and Survival checks to interact with Animals. You and your party additionally have Upper Hand on all Subterfuge checks to hide from the targets of your Track Foe action."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Behemoth's Bounty",
                Description = "You adhere to \"nose-to-tail\" principle of carcass utilization, granting you the ability to harvest body parts of slain creatures and use them to craft powerful gear.<br /><br />You can harvest body parts of any dead non-humanoid creature that was dead for no longer than 1 day, a process which requires certain time and yields a number of both Rations and Crafting Components.<br /><br />Additionally, you gain Craft Primal Gear Rest Action.<br /><br />When you take Craft Primal Gear Rest Action, you spend a part of your Rest crafting a Weapon, Armor or Trap made out of the body parts you harvested from slain creatures.<br /><br />You use Leatherworking for this Rest Action, and the Action inherits any effects that apply to Craft Rest Action. When taking this Action, you can craft any Weapon, Armor or Adventuring Item of Trap type that you wish, keeping in mind their respective Proficiency Tier requirements and amounts of Progress Points needed to craft them. However, items crafted this way cannot be repaired once broken."
            }
        };
    }
}
