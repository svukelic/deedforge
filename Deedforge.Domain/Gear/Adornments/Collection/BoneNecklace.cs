namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment BoneNecklace = new Adornment
        {
            Name = "Bone Necklace",
            Description = "A necklace made from the bones of various creatures. As an Action, you can remove a bone from the Necklace and make a Knowledge Check. The Check is made with any Skill you choose and is done as if you had Legendary Proficiency in that Skill, but the Check must be about a specific creature type or species. The Necklace can have up to 5 bones, and each bone can be used only once, but you replenish 1 bone every time your Party defeats a Unique foe.",
            AdornmentType = AdornmentType.Jewelry,
        };
    }
}
