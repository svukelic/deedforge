namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession DemonHost = new Profession
        {
            Name = "Demon-Host",
            Order = 38,
            ImageUrl = "images/professions/demon-host.png",
            Description1 = "A Demon-Host is a character who has forged a perilous pact with a malevolent demonic entity, tethering their soul to the otherworldly forces of chaos and destruction. This unholy communion grants them access to formidable, dark powers that can wreak havoc upon their enemies. However, the role of a Demon-Host in a party is a double-edged sword, as they must constantly grapple with the inner turmoil of their demonic connection. Their abilities include harnessing destructive spells, summoning infernal minions, and manipulating dark energies to inflict dire afflictions upon their foes.",
            Description2 = "In a party, the Demon-Host serves as a formidable offensive presence, capable of unleashing devastating bursts of dark magic that can obliterate adversaries and cripple their defenses. They can summon demonic allies to the battlefield, bolstering the party's forces in times of dire need. Yet, the price of their power is steep, as they must constantly wrestle with the malevolent spirit within them, facing the risk of losing control or being consumed by the demon's insatiable hunger for chaos. This inner struggle can test the Demon-Host's willpower and the trust of their companions, making them enigmatic and unpredictable figures within the party dynamic.",
            GrantedSkills = "",
            Limitations = "Reaching 10 levels of Exhaustion doesn't make you die, but rather causes you to be taken over by a demonic entity. The Guide determines the specifics of this situation, which usually means losing control of this character.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Demonic Avatar",
                Description = "You gain an ability to physically manifest the demon bound to you. This Action costs 1 AP to activate, which causes the demon to physically possess your body and temporarily transform it into that of a demon.<br /><br />You choose the specific form, which must be that of a Foe of Demon Type with Easy Threat Rating and a maximum Foe Tier equal to Proficiency Tier in your Occultist Spellcasting Skill.<br /><br />When activating this feature and at the start of your subsequent turns while maintaining this demonic form, you need to make a Spellcasting check as if you're casting and sustaining a Spell with a Sustain property to check whether you suffer from a Peril. Peril Rating for this check is equal to three times the Foe Tier of the chosen demonic form. When you suffer from this Peril, you do not lose the demonic form, but you do gain a level of Exhaustion.<br /><br />Additionally, you keep the ability to cast your Occultist Spells while in demonic form."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Forbidden Knowledge",
                Description = "The demonic entity bound to you is always watchful and happy to whisper to you, but this comes at a price. Whenever you use one of the following features, you gain a level of Exhaustion.<br /><br />- Whenever you are about to be inflicted with a Surprised Status, you can choose not to become Surprised.<br />- Whenever you fail a contested Charisma Skill check, you can choose to reroll that check.<br />- Whenever you fail a Skill check to recall knowledge about specific topic, you can choose to succeed on that check instead.<br /><br />Additionally, you gain a special Knowledge (Demons). With this Knowledge, you have a supernatural ability to communicate with Demons, no matter which form of communication they usually use. Whenever you need to make any Charisma Skill Check against a Demon, you can instead make a check using your Spellcasting Skill (it still counts as Charisma Skill Check even if the used Spellcasting Skill isn't a Charisma Skill)."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Dark Assistance",
                Description = "When taking an Exploration or a Rest Action, you can call upon the demonic spirit bound to you to assist you and your party.<br /><br />The demon can take any Exploration or Rest Action you can and you roll Skill checks as if you're doing the Action, but whenever you fail a Skill check as part of this feature, you must roll on Profane Injury table."
            }
        };
    }
}
