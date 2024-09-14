namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Siegemaster = new Profession
        {
            Name = "Siegemaster",
            Order = 41,
            ImageUrl = "images/professions/siegemaster.png",
            Description1 = "Siegemasters are the formidable architects of destruction, wielding the knowledge and power to unleash devastation upon fortifications and strongholds. These masters of siege warfare possess the ability to conjure and control massive siege engines, such as trebuchets, ballistae, and catapults, with uncanny precision. In a party, their role is clear-cut: to break through enemy defenses and create opportunities for their comrades. With the power to reduce towering walls to rubble and breach impenetrable gates, Siegemasters play a crucial role in assaulting fortified positions and ensuring victory on the battlefield.",
            Description2 = "One of the most impressive abilities of a Siegemaster is their expertise in identifying and exploiting the weaknesses of defensive structures. Through careful study and observation, they can discern the structural vulnerabilities of walls, castles, and other fortifications, providing invaluable insights to their party on how to breach or circumvent these defenses. Siegemasters also possess the knowledge to construct makeshift siege engines on the fly, turning the surrounding environment into a weapon. Whether it's creating improvised battering rams or crafting makeshift artillery from found materials, their resourcefulness knows no bounds. With Siegemasters at the helm, a party can transform seemingly impregnable fortresses into conquerable targets, making them essential assets in any campaign of conquest or siege warfare.",
            GrantedSkills = "Trained in Architecture",
            Limitations = "–",
            CombatFeature = new ProfessionFeature
            {
                Name = "Summon Siege Machine",
                Description = "Whenever you finish a Rest, you choose which Siege Machine you will have access to until the next time you finish a Rest (refer to Siege Machines page).<br /><br />The Siege Machine is safely stored in an extra-dimensional space. The Machine can be summoned or dismissed by spending 1 AP. It appears in a location Near you with enough space. The Machine is, in addition to being a Land Vehicle, in your case also considered a sentient Construct which obeys your vocal commands and follows Companion rules.<br /><br />Your summoned Siege Machine has the following adjustments to its stats:<br /><br />- Armor Rating: 5 + your Proficiency Tier in Architecture<br />- Maximum Damage: Three times your Proficiency Tier in Architecture"
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Grand Destroyer",
                Description = "You gain a special Knowledge (Siege). With this Knowledge, you have an innate and detailed insight into laying a siege. You instinctively know how to encircle defensive perimeters, take measurements of defensive capabilities and how to bring them down, and both minimize and maximize civilian casualties.<br /><br />Additionally, you Study Foe action granted by the Specialist Archetype can now also target buildings and vehicles."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Destructive Engineering",
                Description = "You gain Analyze Defenses Rest Action.<br /><br />When you take Analyze Defenses Rest Action, you spend your Rest analyzing the defenses of a location such as a castle or a walled town. To take this Rest Action, you need to either have seen the location in question or have some sort of document or map describing it.<br /><br />When you take this Rest Action, make an Architecture Skill check against DR determined by the Guide. On success, the Guide will provide a set of details regarding the location's weaknesses in defenses, rough estimates of defenders and their gear, potential passages in and out of the location, etc."
            }
        };
    }
}
