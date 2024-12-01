namespace Deedforge.Domain.AdditionalEntities
{
    public class PassiveEffectCollection
    {
        public List<PassiveEffect>? PassiveEffects { get; set; }
    }

    public class PassiveEffect
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
