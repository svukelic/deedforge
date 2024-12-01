namespace Deedforge.Domain.Gear.Adornments.Collection
{
    public partial class Adornments
    {
        public static Adornment Bandolier = new Adornment
        {
            Name = "Bandolier",
            Description = "A belt worn across the chest, featuring loops, pouches, or pockets designed for carrying and quickly accessing multiple items. While worn, allows you to designate up to 3 Adventuring Items as Equipped items.",
            AdornmentType = AdornmentType.Belt,
        };
    }
}
