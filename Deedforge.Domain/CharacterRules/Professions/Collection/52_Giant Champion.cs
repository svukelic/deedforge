namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession GiantChampion = new Profession
        {
            Name = "Giant Champion",
            Order = 52,
            ImageUrl = "images/professions/giant-champion.png",
            Description1 = "The Giant Champion is a colossal force of nature, a towering figure among warriors whose very presence on the battlefield commands attention and fear. Their role in a party is that of an indomitable protector and a devastating frontline combatant. These formidable beings are often marked by their immense size, incredible strength, and unyielding determination.",
            Description2 = "A Giant Champion's abilities are awe-inspiring. They can wield enormous weapons with ease, crush their enemies with earth-shaking blows, and withstand even the most punishing of assaults. Their massive stature alone can turn the tide of battle, as they intimidate foes and provide cover for their allies. They can single-handedly hold the line against a horde of enemies, use colossal strength to topple enemy fortifications, and unleash earth-shattering roars that rally their comrades to victory. In a party, a Giant Champion serves as the ultimate vanguard, soaking up damage and protecting their allies while delivering devastating blows that break enemy lines. Their mere presence is often a source of inspiration for their comrades, making them invaluable assets in any battle.",
            GrantedSkills = "Trained in Athletics",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Giant's Might",
                Description = "You gain Invoke Giant's Might action.<br /><br />Invoke Giant's Might<br />AP Cost: 1<br />Restriction: Once per turn<br />You grow in size, causing you to adopt Large Size Category and all of the benefits of that size. If you have Master Proficiency Tier in Athletics, you grow to Massive size instead.<br /><br />This transformation lasts for 10 minutes or until the end of the current Encounter, whichever comes first. When this action ends, you gain 1 level of Exhaustion."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Thunderous Voice",
                Description = "You are able to use any of the Warrior's Combat Techniques which doesn't inflict Wounds at range within Far Vicinity against any target that can hear you. Any check rolled as part of a Combat Techniques used in this way is done with an Upper Hand while in a Social Encounter.<br /><br />Additionally, you can roll Athletics for any Intimidation check."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Ancient Builder",
                Description = "When taking Fortify Camp Rest Action, you can now choose up three effects instead of the usual one."
            }
        };
    }
}
