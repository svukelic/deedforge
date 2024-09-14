namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession SpiritOfVengeance = new Profession
        {
            Name = "Spirit of Vengeance",
            Order = 67,
            ImageUrl = "images/professions/spirit-of-vengeance.png",
            Description1 = "The Spirit of Vengeance is a haunting and enigmatic entity. In a party, they embody relentless justice, wielding eerie abilities to hunt down and punish those who have committed wicked deeds. These vengeful spirits are often bound to a individuals, imbuing them with otherworldly powers and an unquenchable thirst for retribution.",
            Description2 = "Riding a spectral steed ablaze with supernatural flames, the Spirit of Vengeance charges into the heart of darkness, leaving a trail of ethereal fire in their wake. They wield possessed weapons, delivering searing punishment to evildoers who dare cross their path. With the uncanny ability to sense guilt and malevolence, they track down their targets relentlessly, ensuring that the scales of justice are balanced. Within the party, they serve as the unwavering moral compass, guardians of virtue and protectors of the innocent. The Spirit of Vengeance brings an aura of both terror and retribution to their medieval world, making them a formidable force dedicated to cleansing the realm of malevolence.",
            GrantedSkills = "Trained in Insight",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Possessed Weapons",
                Description = "Any weapon that deals Physical damage and that you have equipped you can turn into a possessed weapon. You can have upwards of 2 such possessed weapons.<br /><br />A possessed weapon deals your choice of Hallowed or Profane damage, which you choose when you turn the weapon into a possessed one. When attacking with a possessed weapon, you ignore any Resistance to Hallowed or Profane damage.<br /><br />Turning a weapon into a possessed one and changing the damage type of an already possessed weapon costs 1 AP.<br /><br />Optionally, you can also treat the weapon as if it's a Magic Weapon."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Penitent Gaze",
                Description = "You have an ability to look into the soul of any intelligent Humanoid target within Melee vicinity of you. If done during a Combat Encounter, this action costs 2 AP.<br /><br />When you do so, the target needs to make a Charisma Check contested by your Insight check. If they fail, you immediately gain insight into most notable crimes the target has committed in their life.<br /><br />If these crimes are particularly egregious, as determined by the Guide, the target is considered to be an Evil-Doer until your next Rest. You have Upper Hand on all attacks and Charisma Skill checks against Evil-Doers.<br /><br />However, if the target turns out to be a particularly good person, they are considered to be a Good-Doer. You must immediately roll on Hallowed Injuries tables and you have Lower Hand on all attacks and Charisma Skill checks against the Good-Doer."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Otherworldly Sustenance",
                Description = "You no longer consume Rations when resting and you don't need to eat.<br /><br />Whenever you Rest, if you successfully used your Penitent Gaze feature against an Evil-Doer since your last Rest, you can choose to gain a benefit of Food of your choice as if you ate it.<br /><br />This feature also applies to any Mount under your control."
            }
        };
    }
}
