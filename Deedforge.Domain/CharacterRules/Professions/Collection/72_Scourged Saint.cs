namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession ScourgedSaint = new Profession
        {
            Name = "Scourged Saint",
            Order = 72,
            ImageUrl = "images/professions/scourged-saint.png",
            Description1 = "The Scourged Saint is a paradoxical figure, a beacon of faith and resilience who finds strength within their suffering. Inflicted with a debilitating disease or ailment, they have chosen to channel their pain into a higher purpose, becoming a symbol of hope and inspiration. In a party, the Scourged Saint often serves as a spiritual guide and a source of unwavering moral strength, embodying the belief that even in the darkest of trials, one can find the light.",
            Description2 = "The Scourged Saint's role is multifaceted. They possess unique divine abilities that draw power from their affliction, often using their own suffering to heal wounds, purify the corrupt, or ward off malevolent forces. For example, in a dire battle, they might invoke their inner turmoil to smite an enemy with righteous fury or mend their allies' injuries with the power of their faith. Beyond combat, the Scourged Saint is a moral compass within the party, offering counsel and wisdom, and serving as a voice of conscience when decisions become morally complex. Their unwavering devotion can inspire the group to rise above challenges and temptations, making them a vital source of spiritual strength. In the face of adversity, the Scourged Saint's profound resilience becomes a symbol of hope for their companions, teaching that even in the darkest moments, faith and determination can illuminate the path forward.",
            GrantedSkills = "Trained in Health",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Saint's Piety",
                Description = "You have a pool of dies that represent your Piety. These dies are known as Piety Dies, and the maximum number of these Dies in your pool is equal to your Proficiency Tier in Health.<br /><br />Additionally, you gain a permanent Imperiled Status. You decide when taking this Profession the Damage Type of the Status and the Action on which the Status triggers.<br /><br />You gain a Piety Die whenever this Imperiled Status triggers.<br /><br />Whenever you hit an enemy or an enemy fails a contested check against you, you can spend a Piety Die to inflict an Imperiled Status."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Aura of Awe",
                Description = "You have the ability to exert an aura that grabs the attention of anyone within your line of sight.<br /><br />When you activate this aura, all non-player characters that can see your or hear you will be drawn to you. While this aura is active, all Subterfuge checks done by you or any characters affected by the aura automatically fail.<br /><br />Additionally, you can use Health for any Charisma Skill check done against character affected by your aura instead of the usual skill."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Vicarious Suffering",
                Description = "You gain the following benefits:<br /><br />- Injury DRs are halved for you.<br />- You gain a Toughness Point for each Severe Injury you have whenever you finish a Rest.<br />- You gain Suffer Burdens Rest Actions.<br /><br />When you take Suffer Burdens Rest Action, you magically take over an injury from a willing character taking Rest alongside you. You additionally gain a Piety Die whenever you take this Rest Action."
            }
        };
    }
}
