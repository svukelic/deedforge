namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession IronAcolyte = new Profession
        {
            Name = "Iron Acolyte",
            Order = 69,
            ImageUrl = "images/professions/iron-acolyte.png",
            Description1 = "The Iron Acolyte is a master of melding magic and machinery, a true marvel in the realm of technological prowess. Within a party, they serve as both ingenious inventors and skilled physicians. Iron Acolytes are known for their ability to craft intricate mechanical prosthetics, replacing lost limbs and bestowing enhanced abilities upon their comrades. These prosthetics are not only marvels of engineering but also channels for magical energy, allowing the recipients to tap into incredible powers. Additionally, Iron Acolytes possess an intimate understanding of the inner workings of machinery, making them indispensable when it comes to repairing and maintaining mechanical devices.",
            Description2 = "On the battlefield, an Iron Acolyte is a versatile support class, utilizing their mechanical creations to bolster their party's combat capabilities and control technology. They can provide cover, grant enhanced mobility, and even heal injuries using their advanced prosthetics. Their role in the party is that of a brilliant inventor and a compassionate healer, ensuring that their comrades are always equipped to face any challenge that comes their way. Iron Acolytes combine the wonders of technology with the mystique of magic, forging a path to victory through ingenuity and innovation.",
            GrantedSkills = "Trained in Technology",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Magnetokinetics",
                Description = "You gain the following abilities:<br /><br />- You can interact with any machine within Near vicinity of you that you can see as if you are next to it.<br />- You can always take Disarm action, no matter your current gear, against any metal weapon within Near vicinity of you that you can see.<br />- You have Resistance against all attacks made by Constructs."
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Apostle of the Machines",
                Description = "You gain a special Knowledge (Machine Souls). With this Knowledge, you can make a Technology check instead of a usual Skill whenever you are making a check that relates to anything related to technology and machines, including historical matters, religious questions, when interacting with intelligent Constructs, etc.<br /><br />Additionally, you also learn the unique Machine Language. This language cannot be understood nor learned by anyone except other Iron Acolytes. All intelligent Constructs can also innately understand this language, although they don't necessarily have the ability to speak it."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Craft Prosthetic",
                Description = "You gain Craft Prosthetic Rest Action.<br /><br />When you take Craft Prosthetic Rest Action, you spend part of your Rest crafting a Prosthetic for yourself or one of your allies who is in need of one.<br /><br />Crafting a Prosthetic costs a number of Crafting Components equal to half the Attachment DR of the Prosthetic. You can craft any Prosthetic, but they all count as having Mechanical type.<br /><br />You immediately attach the crafted Prosthetic without the need to roll for it. You can have a number of Prosthetics crafted and installed equal to twice your Proficiency Tier in Technology.<br /><br />Additionally, whenever you or any character who has at least one of your Prosthetics installed finishes a Rest, they gain number of Toughness Points equal to the number of your Prosthetics they have installed. The Toughness Points gained this way last until their next Rest."
            }
        };
    }
}
