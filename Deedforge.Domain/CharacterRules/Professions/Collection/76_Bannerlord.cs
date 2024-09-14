namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Bannerlord = new Profession
        {
            Name = "Bannerlord",
            Order = 76,
            ImageUrl = "images/professions/bannerlord.png",
            Description1 = "The Bannerlord is the embodiment of leadership and battlefield prowess, a commanding figure who inspires their allies to fight with unwavering resolve. Leading from the frontlines, they raise their banner high, rallying their party and turning the tide of battle. A Bannerlord's role in a party is pivotal, serving as the vanguard and a symbol of unity, ensuring that their comrades fight as a cohesive force rather than a disparate group of individuals.",
            Description2 = "In the chaos of combat, the Bannerlord's presence is a source of inspiration. With a wave of their banner or a resounding battle cry, they bolster the morale of their allies, granting them increased courage and resilience. On the battlefield, they exhibit masterful combat skills, often wielding their weapon with unmatched precision. For example, a Bannerlord might lead a charge against a formidable enemy, their banner streaming behind them, and their allies following with renewed vigor. Beyond combat, the Bannerlord also excels in strategic planning, guiding their party through perilous quests and helping them navigate complex challenges. Their leadership extends to diplomacy as well, where their charisma and tact can forge alliances, secure resources, and navigate delicate negotiations. In essence, the Bannerlord is the heart and soul of the party, a steadfast leader whose presence ensures that victory is not only achievable but inevitable.",
            GrantedSkills = "Trained in Intimidation",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Battle Standard",
                Description = "You gain a special weapon called Battle Standard. Battle Standard consists of an intricate flag attached to a sturdy pole, and has the following characteristics:<br /><br />- Properties: Light, Grip, Daze<br />- Additional Effects: Battle Standard gains Reach property when used with two hands. If Battle Standard is broken, it can be repaired over the course of Rest without taking any Rest Action.<br /><br />While you're wielding Battle Standard, you gain access to Issue Mass Order action.<br /><br />Issue Mass Command<br />AP Cost: 1<br />Restriction: Once per turn<br />You issue a rallying command that can be seen and heard within Very Far vicinity, which can be Launch Assault, Reposition, or Defend. All of your party members which can see or hear you can, should they wish so, immediately as a Reaction take an action. The specific action depends on the type of the command:<br /><br />- Launch Assault – Attack or Cast Spell which targets an enemy.<br />- Reposition – Move Action.<br />- Defend – Raise Shield, Hide or Cast Spell with Self-targeted property."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Symbol of Authority",
                Description = "While in a Social Encounter, any neutral participant counts as friendly participant for you and your party members.<br /><br />Additionally, when making Deception, Persuasion or Performance checks, you can instead make an Intimidation check."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Inspiring Tactician",
                Description = "Whenever you or a party member of yours gains a Toughness Point at the end of their Rest, they gain one additional Toughness Point"
            }
        };
    }
}
