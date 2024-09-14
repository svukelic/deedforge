namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Lich = new Profession
        {
            Name = "Lich",
            Order = 48,
            ImageUrl = "images/professions/lich.png",
            Description1 = "The Lich is a haunting and enigmatic profession that delves into the darkest realms of necromancy and undeath. Their role in a party is one of unparalleled magical mastery and eerie presence. Liches are often feared and misunderstood, but their abilities are undeniably potent. They are masters of the arcane, capable of wielding necrotic magic with deadly precision, and their very existence blurs the line between life and death.",
            Description2 = "A Lich's abilities are shrouded in the macabre. They can manipulate the souls of the living and the dead and launch devastating assaults that drain the life force from their enemies. They are nearly immortal, as their phylacteries safeguard their souls from death, allowing them to return time and again. In a party, a Lich serves as a formidable offensive backbone, but their presence may also instill unease and distrust among their allies due to the sinister reputation associated with their kind.",
            GrantedSkills = "Trained in Arcana",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Soulstealer",
                Description = "Whenever you deal damage with a Weapon Attack or a Spell, you can choose to turn the damage type into Profane.<br /><br />Additionally, you have a pool of d4 dies that represent a number of Souls you stole. These dies are known as Soul Dies, and the maximum number of these Dies in your pool is equal to your Proficiency Tier in Arcana.<br /><br />Whenever you inflict a Profane Injury, you steal a Soul, thus gaining a Soul Die.<br /><br />With this feature, you gain access to Death Coil.<br /><br />When you attempt to hit an enemy with an attack, you can choose to use Death Coil by spending and rolling a Soul Die. You add the result of that roll to that check."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Unnatural Disturbance",
                Description = "Your very existence affects natural laws in your vicinity.<br /><br />While in a Social Encounter, whenever a Hostile Participant makes a check whose result would add to Encounter Complexity, you can choose to instead subtract that result from the Encounter Complexity. However, each time you do so, you gain a level of Exhaustion.<br /><br />Additionally, you gain a special Knowledge (Undeath). With this Knowledge, you have intimate knowledge about undeath, undead creatures, and legendary artifacts related to undeath."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Lich's Phylactery",
                Description = "When you became a Lich, you gained access to a powerful artifact called a Phylactery. As long as your Phylactery exists, you cannot die from the effects of Exhaustion. However, if your Phylactery is destroyed, you stop being a Lich (discuss with your Guide how to approach the given circumstances).<br /><br />Whenever you finish a Rest, you can choose to store or retrieve any number of Soul Dies into your Philactery, which can hold a maximum number of Dies equal to twice your Proficiency Tier in Arcana.<br /><br />Should you die from any cause, you don't truly die. Instead, your body reconstitutes itself during your party's next Rest, reviving you with 10 levels of Exhaustion. When you are revived this way, you can also choose to immediately spend any number of Soul Dies from your Phylactery, losing a level of Exhaustion for each Die spent."
            }
        };
    }
}
