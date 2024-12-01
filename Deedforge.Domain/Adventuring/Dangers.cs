using Deedforge.Domain.Prestige;

namespace Deedforge.Domain.Adventuring
{
    public class Danger
    {
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public required string Description { get; set; }
        public required string Precautions { get; set; }
    }

    public class Dangers
    {
        public static Danger FreezingWeather = new Danger
        {
            Name = "Freezing Weather",
            ImageUrl = "images/dangers/freezing-weather.png",
            Description = "The region's temperature is below freezing. Extended exposure may result in death.",
            Precautions = "The Party will need to find shelters often and rest to avoid the effects of the cold."
        };

        public static Danger ScorchingHeat = new Danger
        {
            Name = "Scorching Heat",
            ImageUrl = "images/dangers/scorching-heat.png",
            Description = "The region's temperature is scorching. Extended exposure may result in death.",
            Precautions = "The Party will need to find water and rest often in the shade to avoid the effects of the heat."
        };

        public static Danger SocietalChaos = new Danger
        {
            Name = "Societal Chaos",
            ImageUrl = "images/dangers/societal-chaos.png",
            Description = "The region is in turmoil due to a civil war, revolution, or other strife. Bandits and other criminals are more active than normal.",
            Precautions = "The Party will need to be extra vigilant and prepared for conflict."
        };

        public static Danger WarFront = new Danger
        {
            Name = "War Front",
            ImageUrl = "images/dangers/war-front.png",
            Description = "The region is directly affected by a war. Roving war bands are common, and resources such as food and water are scarce.",
            Precautions = "The Party will need to travel cautiously, be wary of their resources, and be prepared for conflict."
        };

        public static Danger DiseaseOutbreak = new Danger
        {
            Name = "Disease Outbreak",
            ImageUrl = "images/dangers/disease-outbreak.png",
            Description = "A disease is spreading through the region. The Party may be affected.",
            Precautions = "The Party will need to find medicine and rest often to avoid the effects of the disease."
        };
    }
}
