using Deedforge.Domain.Adventuring;
using Deedforge.Domain.CharacterRules.Ancestries;
using Deedforge.Domain.CharacterRules.Professions;
using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.CoreRules.Statuses;
using Deedforge.Domain.Gear.Adornments;
using Deedforge.Domain.Gear.Armors;
using Deedforge.Domain.Gear.Shields;
using Deedforge.Domain.Gear.Weapons;
using Action = Deedforge.Domain.CoreRules.ActionsReactions.Action;

namespace Deedforge.Shared.Compendium
{
    public class CompendiumData
    {
        #region Core Rules
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Action> Actions { get; set; } = new List<Action>();
        public List<Deed> Deeds { get; set; } = new List<Deed>();
        public List<Status> Boons { get; set; } = new List<Status>();
        public List<Status> Conditions { get; set; } = new List<Status>();
        public List<Scar> Scars { get; set; } = new List<Scar>();
        #endregion

        #region Character Rules
        public List<Profession> Professions { get; set; } = new List<Profession>();
        public List<Ancestry> CommonAncestries { get; set; } = new List<Ancestry>();
        public List<Ancestry> ExoticAncestries { get; set; } = new List<Ancestry>();
        #endregion

        #region Gear
        public List<Armor> Armors { get; set; } = new List<Armor>();
        public List<Shield> Shields { get; set; } = new List<Shield>();
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public List<Adornment> Adornments { get; set; } = new List<Adornment>();
        #endregion

        #region Adventuring
        public List<Danger> Dangers { get; set; } = new List<Danger>();
        #endregion
    }
}
