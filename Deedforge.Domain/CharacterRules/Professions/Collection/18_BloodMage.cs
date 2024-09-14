namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession BloodMage = new Profession
        {
            Name = "Blood Mage",
            Order = 18,
            ImageUrl = "images/professions/blood-mage.png",
            Description1 = "In the pulsing heart of a swirling arcane storm, or the hushed silence of a forbidden ritual chamber, the Blood Mage stands as a master of life's essence. They are the life-weavers, the arcane manipulators who tap into the very life force that flows within all living beings to wield magic of unparalleled power. With a flick of their wrist, a Blood Mage might draw upon their own life force to unleash a devastating spell, the air crackling with raw energy as their blood fuels the arcane onslaught. Or they could reach out with their magic to drain the vitality of their enemies, their foes' strength ebbing away to invigorate the Blood Mage and their allies.",
            Description2 = "The Blood Mage can weaken and obliterate their enemies. In a tense standoff, they could subtly sap the strength of their enemies, their foes growing weaker without even realizing the cause. In essence, the Blood Mage is the master of life's ebb and flow, a wielder of a magic that is as terrifying as it is awe-inspiring, and a crucial magician in any encounter that tests the limits of life and death.",
            GrantedSkills = "",
            Limitations = "None",
            CombatFeature = new ProfessionFeature
            {
                Name = "Blood Magic",
                Description = "Whenever you Empower a Spell, it is now automatically Empowered to the maximum Tier you can Empower it, and you do not suffer from Perils when doing so.<br /><br />However, you gain a Wound whenever you Empower a Spell.<br /><br />Additionally, you can now choose to use Health as your Spellcasting Skill."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Heart-Seeker",
                Description = "You are in tune with the heart beats and the blood flow of living beings within Near vicinity of you.<br /><br />You immediately catch onto whenever someone's heart beat increases due to them lying or being afraid. This ability also grants you Upper Hand on all Insight checks against living creatures."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Blood Transfusion",
                Description = "You gain Blood Transfusion Rest Action.<br /><br />When you take Blood Transfusion Rest Action, you spend part of your Rest purifying the blood of a friendly character taking Rest alongside you.<br /><br />This Rest Action inherits all effects of the Treat Rest Action. Additionally, should you succeed on any relevant role while taking this Action, you can also transfer one Injury from the treated person to another willing person.<br /><br />Finally, you can also target yourself with this Rest Action."
            }
        };
    }
}
