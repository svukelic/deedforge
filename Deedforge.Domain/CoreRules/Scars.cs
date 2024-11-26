namespace Deedforge.Domain.CoreRules
{
    public class Scar
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ReputationBlock { get; set; }
    }

    public class Scars
    {
        public static Scar Cold = new Scar
        {
            Name = "Cold",
            Description = "You're not moved by emotional appeals or social bonds.",
            ReputationBlock = "Mercy"
        };

        public static Scar Soft = new Scar
        {
            Name = "Soft",
            Description = "You lose your edge; you become sentimental, passive, gentle.",
            ReputationBlock = "Ruthlessness"
        };

        public static Scar Cynical = new Scar
        {
            Name = "Cynical",
            Description = "Every act of kindness looks suspicious to you; you see ulterior motives in generosity and can't bring yourself to trust in goodwill.",
            ReputationBlock = "Generosity"
        };

        public static Scar Martyr = new Scar
        {
            Name = "Martyr",
            Description = "You compulsively give away your resources and energy, finding worth only in self-sacrifice and deprivation.",
            ReputationBlock = "Greed"
        };

        public static Scar Fractured = new Scar
        {
            Name = "Fractured",
            Description = "Reality shifts and bends in your perception; you can't trust your own memories or senses enough to speak any truth with certainty.",
            ReputationBlock = "Truth"
        };

        public static Scar Naive = new Scar
        {
            Name = "Naive",
            Description = "Trauma has left you with a childlike inability to lie; you blurt out truths even when they endanger you.",
            ReputationBlock = "Lie"
        };

        public static Scar Abandoned = new Scar
        {
            Name = "Abandoned",
            Description = "Previous betrayals have left you unable to fully commit; you always keep one foot out the door.",
            ReputationBlock = "Reliability"
        };

        public static Scar Dependent = new Scar
        {
            Name = "Dependent",
            Description = "Fear of abandonment has made you pathologically loyal; you'll endure any abuse rather than risk being alone.",
            ReputationBlock = "Betrayal"
        };

        public static Scar Terrorized = new Scar
        {
            Name = "Terrorized",
            Description = "Some horror broke something fundamental in you; your fighting spirit is gone, leaving only freeze or flee responses.",
            ReputationBlock = "Valor"
        };

        public static Scar Reckless = new Scar
        {
            Name = "Reckless",
            Description = "You have little regard for your own safety or best interests.",
            ReputationBlock = "Cowardice"
        };

        public static Scar Shattered = new Scar
        {
            Name = "Shattered",
            Description = "Your once-sharp mind keeps slipping; complex thoughts scatter like startled birds.",
            ReputationBlock = "Genius"
        };

        public static Scar Obsessed = new Scar
        {
            Name = "Obsessed",
            Description = "You're enthralled by one thing: an activity, a person, an ideology.",
            ReputationBlock = "Buffoon"
        };

        public static Scar Frenzied = new Scar
        {
            Name = "Frenzied",
            Description = "Your nerves are shot; the slightest pressure sends you into a spiral of uncontrolled reactions.",
            ReputationBlock = "Coolness"
        };

        public static Scar Dissociated = new Scar
        {
            Name = "Dissociated",
            Description = "You're so detached from yourself that nothing seems quite real; fear slides off you like water.",
            ReputationBlock = "Panic"
        };
    }
}
