namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession PlagueDoctor = new Profession
        {
            Name = "Plague Doctor",
            Order = 21,
            ImageUrl = "images/professions/plague-doctor.png",
            Description1 = "In the heart of a pestilent swamp, or the crowded streets of a city struck by a mysterious illness, the Plague Doctor stands as a beacon of hope and healing. They are the healers, the curers of disease who wield their knowledge of medicine and alchemy to combat the most virulent of afflictions. With a vial of potent antidote in one hand and a staff in the other, a Plague Doctor might move through a battlefield, their magic cleansing allies of debilitating poisons and sealing wounds with a touch. Or they could concoct a powerful potion, their brew causing a fallen ally to stir and return to the fight, their vitality restored.",
            Description2 = "But a Plague Doctor's role in a party extends beyond their healing capabilities. They are the scientists, the alchemists, and the purveyors of preventative medicine. With their deep understanding of diseases and their causes, they can identify and neutralize threats before they become a problem, their knowledge often proving crucial in navigating disease-ridden areas. In a city struck by a plague, they might be the one to trace the source of the disease, their investigations leading to a contaminated well or a cursed artifact. In a fight against a venomous beast, they could provide their allies with antitoxins, their preparations ensuring that the creature's venom poses less of a threat. In essence, the Plague Doctor is the master of healing and prevention, a crucial support in any situation where disease and poison are as much a threat as any sword or spell.",
            GrantedSkills = "Trained in Medicine",
            Limitations = "Cannot wear Heavy Armor",
            CombatFeature = new ProfessionFeature
            {
                Name = "Harmacist",
                Description = "You gain the following benefits:<br /><br />- You can use your Proficiency Tier in Medicine when attacking with a Blowgun.<br />- When using Blowgun to fire a poison, the poison isn't used up right away, but rather at the end of the Encounter.<br />- You can use Apply Potion and Apply Emergency Kit actions at range using a Blowgun."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Field Medic",
                Description = "You gain two pieces of Knowledge of your choice from the following list:<br /><br />- Magical Diseases<br />- Parasitic Creatures<br />- Disease-related Cults<br />- Healing-oriented Organizations<br /><br />Additionally, whenever you finish a Rest, you gain a number of Emergency Kits equal to your Proficiency Tier in Medicine. You additionally gain Apply Emergency Kit action.<br /><br />AP Cost: 1<br />Restriction: Once per turn<br />You apply Emergency Kit to a target character within Melee vicinity of you, causing them to lose your choice of either a Wound, or a non-Severe Injury."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Plague Doctor's Craft",
                Description = "You gain Surgery Rest Action.<br /><br />When you take Surgery Rest Action, you spend part of your Rest operating on a willing character. When you do so, the target character loses a number of Wounds equal to your Proficiency Tier in Medicine, and also heals from an Injury, including potentially Severe Injury (but not a missing limb or organ), of your choice that they were suffering from.<br /><br />Any effect that affects Treat Rest Action also applies to Surgery Rest Action."
            }
        };
    }
}
