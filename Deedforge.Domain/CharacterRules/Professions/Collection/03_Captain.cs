namespace Deedforge.Domain.CharacterRules.Professions.Collection
{
    public partial class Professions
    {
        public static Profession Captain = new Profession
        {
            Name = "Captain",
            Order = 3,
            ImageUrl = "images/professions/captain.png",
            Description1 = "In the heart of battle, amidst the chaos and clamor of clashing steel, the Captain stands as a beacon of hope and strategy. They are the master tacticians, the leaders who inspire their allies to fight with renewed vigor and guide them through the most treacherous of encounters. With a keen eye for the ebb and flow of combat, they command the battlefield, directing their allies with precise orders and positioning themselves where they are needed most. A Captain might lead a charge against a horde of goblins, rallying their allies to follow them into the fray, their armor gleaming in the torchlight as they cut a path through the enemy ranks.",
            Description2 = "But a Captain’s role extends beyond the battlefield. They are the voice of reason in a heated debate, the calming presence in a tense negotiation, and the guiding hand in the planning of an expedition. With their tactical acumen, they can anticipate dangers and devise strategies to overcome them. They are the ones who ensure the party’s survival in hostile environments, using their knowledge of strategy and logistics to secure safe campsites, manage supplies, and navigate challenging terrains. When the party stumbles upon a seemingly insurmountable obstacle, it is the Captain who devises a plan, whether it’s scaling a treacherous mountain pass or infiltrating a heavily guarded fortress. In essence, the Captain is the glue that holds the party together, the unyielding pillar that supports and guides them through their perilous adventures.",
            GrantedSkills = "Trained in one Fortitude Skill and Trained in one Charisma Skill.",
            Limitations = "None.",
            CombatFeature = new ProfessionFeature
            {
                Name = "Squire",
                Description = "You gain a Squire Companion. Squire Companion is a creature which follows the Companion rules.<br /><br />The Squire uses Foe statblock based on your Archetype, as outlined below in Squire Statblocks.<br />The Squire gains copy of your Archetype Features.<br />For each Proficiency Tier you have in Charisma, the Squire gains:<br />    - An additional Maximum Wound<br />    - A Skill Boost in either Defense or Subterfuge<br />    - A Skill Boost in one Weaponry Skill of your choice<br />    - A Skill Boost in any Skill of your choice<br />    - A copy of a Trait you also possess<br />Whenever you finish a Rest, your Squire Companion loses all of their Wounds and Injuries.<br />If your Squire Companion dies, you can revive them or find a different one during a Rest by spending your Rest Action to do so.<br />"
            },
            SocialFeature = new ProfessionFeature
            {
                Name = "Aura of Confidence",
                Description = "People often willingly follow your orders.<br /><br />While in a Social Encounter, you can now take Issue Order action with any non-hostile humanoid who can understand you as the target. They will heed your command immediately for any simple tasks and tasks which directly benefit them. Any more complex task or a task that puts them at danger, make either a Persuasion or Intimidation check, contested by the target’s Charisma check. On success, the target listens to you. On fail, the target refuses the order and grows slightly more hostile towards you.<br /><br />Additionally, whenever you make a Persuasion or an Intimidation check, any roll with a result of 3 or less is treated as 4. This number increases by +2 for each Proficiency Tier you have in the rolled skill."
            },
            RespiteFeature = new ProfessionFeature
            {
                Name = "Master of Logistics",
                Description = "TBD"
            }
        };
    }
}
