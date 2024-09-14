namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Greenskeeper = new Profession
        {
            Name = "Greenskeeper",
            Order = 36,
            ImageUrl = "images/professions/greenskeeper.png",
            Description1 = "Greenskeepers are the guardians of the natural world, their connection to the plant kingdom running deep and harmonious. With their innate ability to nurture and manipulate flora, they are invaluable in both cultivating lush gardens and wielding the untamed power of nature against their foes. In a party, Greenskeepers take on the role of both healer and controller, using their mastery over plant life to mend wounds, ensnare enemies, and harness the wild vitality of the natural world.",
            Description2 = "One of the most remarkable abilities of a Greenskeeper is their capacity to command plant growth. They can coax vines to form protective barriers, conjure thorny thickets to impede adversaries, or even shape wood and branches into formidable weapons. Greenskeepers also possess a unique form of healing magic, using the energy of the earth to mend injuries and restore vitality. Their connection to the forests allows them to call upon the aid of woodland creatures, summoning allies such as treants, sprites, and fey spirits to assist their party. Whether they are turning the battlefield into a verdant sanctuary, entangling foes in vines, or bringing forth the wrath of the forest, Greenskeepers are an indispensable asset to any adventuring group seeking to protect the natural world or harness its formidable power.",
            GrantedSkills = "Trained in Woodworking",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Call of the Forest",
                Description = "You know Conjure Plants Spell and two more Spells of your choice, which must be of Nature (Forests) Category.<br /><br />Peril Rating for these Spells is halved for you."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Blessed Botanist",
                Description = "You have a number of additional Knowledges equal to your Proficiency Tier in Woodworking. These Knowledges need to be somewhat related to plants, trees, forests, etc.<br /><br />Additionally, you innately know basic emotional state, such as fear or happiness, of any plant within Near vicinity of you."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Dendro-Sculptor",
                Description = "Whenever you learn Crafting Recipes as part of Woodworking, you learn one additional Crafting Recipe and you can also choose to learn Crafting Recipes from any Crafting Skill. You use your Woodworking Skill to determine requirements and craft these Recipes.<br /><br />Additionally, whenever you take Craft Rest Action while in a forest, grove or a park, you receive one additional Progress Point."
            }
        };
    }
}
