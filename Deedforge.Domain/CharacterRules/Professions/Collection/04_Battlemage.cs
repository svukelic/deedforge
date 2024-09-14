namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Battlemage = new Profession
        {
            Name = "Battlemage",
            Order = 1,
            ImageUrl = "images/professions/battlemage.png",
            Description1 = "Battlemages are the ultimate combination of brute force and magical prowess. They are able to cast spells in the heat of battle while also being able to withstand heavy blows. Unlike traditional wizards, they do not shy away from combat, instead they embrace it as an opportunity to showcase their power. They can cast a range of spells, from fiery blasts that can incinerate enemies, to protective wards that can shield their allies.",
            Description2 = "With their potent spells, Battlemages serve as powerful force multipliers in any party. They can blast enemies with devastating spells or use their magic to protect allies and control the battlefield. Their unique abilities make them a versatile and powerful addition to any adventuring group.",
            GrantedSkills = "Trained in one Fortitude Skill and Trained in one Intellect Skill.",
            Limitations = "Choose one Spell Category when picking this Profession. You can only cast Spells from that Category.",
            CombatFeature = new ProfessionFeature
            {
                Name = "War Magic",
                Description = "During a Tactical Round, you gain the following features:<br /><br />    - When you take Prepare an Action, you can now prepare Spells with enemies as targets as well.<br />    - When you cast a Spell with yourself as a target, you can also target one friendly character within Near vicinity as well.<br />    - If you prepare a Counterspell Spell, it is considered to be Empowered to the maximum tier you can empower, and you don’t suffer any Perils from casting it.<br /><br />Additionally, you always know Counterspell Spell and you gain training in Medium and Heavy Armors."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "TBD",
                Description = "TBD"
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Arcane Summons",
                Description = "You gain Summon Arcane Servant Rest Action.<br /><br />When you take Summon Arcane Servant Rest Action, you summon one of the following forms of an Arcane Servant to assist you and your party throughout the Rest and which dissipates once their work is done or the Rest is done:<br /><br />    - Enchanted Messenger – You summon an arcane servant which can deliver a single message of your choice, the same as if you used Enchanted Message Scroll (see Adventuring Items page).<br />    - Mystic Watcher – You summon an arcane servant that watch over you and your party as you rest. The Watcher takes Keep Watch Rest Action, and uses your Spellcasting Skill for any relevant checks. Should it spot any danger, it will immediately alert you and your party of it.<br />    - Esoteric Librarian – You summon an arcane servant which provides you with a temporary book on any relatively common topic you demand. The Guide determines whether the topic is common enough, and may grant you access to an uncommon topic as needed. This book can be used by you or anyone in your party for Studying, and it disappears once the Rest is done.<br />"
            }
        };
    }
}
