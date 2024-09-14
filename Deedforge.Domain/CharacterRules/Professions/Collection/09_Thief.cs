namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Thief = new Profession
        {
            Name = "Thief",
            Order = 9,
            ImageUrl = "images/professions/thief.png",
            Description1 = "In the shadowy corners of a bustling tavern, or the dimly lit alleyways of a city at night, the Thief is in their element. They are the masters of stealth and subterfuge, the unseen hand that lightens a mark's purse, the silent figure that slips past the guards undetected. With nimble fingers and a keen eye for detail, a Thief can pick a lock with ease, disarm a trap with a flick of their wrist, or slip a valuable trinket from a pocket without the owner ever noticing. They might infiltrate a heavily guarded mansion, moving like a shadow through the halls, bypassing traps and guards alike to retrieve a priceless artifact.",
            Description2 = "But a Thief's role in a party extends beyond their skills in stealth and larceny. They are the scouts, the infiltrators, the ones who can get in and out without being seen. In a dungeon crawl, they are often the first to enter a new room, checking for traps and hidden threats. In a tense negotiation, they might be the one to slip away unnoticed, gathering information or securing an escape route in case things go south. When the party needs to get somewhere without being seen, it's the Thief who leads the way, guiding them through secret passages and hidden paths. In essence, the Thief is the unseen hand of the party, the silent operative who ensures their success through stealth, cunning, and a knack for getting out of the most precarious situations.",
            GrantedSkills = "Trained in Subterfuge",
            Limitations = "Cannot wear Medium or Heavy Armor",
            CombatFeature = new ProfessionFeature
            {
                Name = "Swindler",
                Description = "Retrieving items from a Container doesn't cost any additional AP for you, and you gain Swindle action.<br /><br />AP Cost: 1<br />Restriction: Once per turn<br />You attempt to steal a carried item within Melee vicinity of you that you can clearly see. Make a Subterfuge check, contested by the Reflex check of the character carrying the target item. On success, the target character loses that item, and you equip it instead. If the target has Distracted Status, your Sleight of Hand check is done with Upper Hand."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Spycraft",
                Description = "You can perfectly recreate mannerism and speech of a person, or a specific group of people, as long as you have heard them speak before.<br /><br />While in a Social Encounter, you have Upper Hand on all Deception and Subterfuge checks."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Sound of Silence",
                Description = "While in an Exploration Encounter, you and your party have Upper Hand on all Subterfuge checks.<br /><br />Additionally, obstacles that could be circumvented by being climbed do not slow down your party."
            }
        };
    }
}
