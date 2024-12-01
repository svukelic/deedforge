using Deedforge.Domain.Adventuring;
using Deedforge.Domain.CharacterRules.Professions.Collection;
using Deedforge.Domain.CharacterRules.Professions;
using Deedforge.Domain.CoreRules.Statuses;
using System.Reflection;
using Deedforge.Domain.Gear.Weapons;
using Deedforge.Domain.Gear.Weapons.Collection;
using Deedforge.Domain.Gear.Armors;
using Deedforge.Domain.Gear.Armors.Collection;
using Deedforge.Domain.Gear.Shields;
using Deedforge.Domain.Gear.Shields.Collection;
using Deedforge.Domain.CoreRules.ActionsReactions;
using Action = Deedforge.Domain.CoreRules.ActionsReactions.Action;
using Deedforge.Domain.CoreRules;
using Deedforge.Domain.CoreRules.Skills;
using Deedforge.Domain.Gear.Adornments;
using Deedforge.Domain.Gear.Adornments.Collection;
using Deedforge.Domain.CharacterRules.Ancestries;
using Deedforge.Domain.CharacterRules.Ancestries.Collection;

namespace Deedforge.Shared.Compendium
{
    public class Compendium
    {
        public static CompendiumData CompendiumData { get; set; } = GetCompendiumData();
            
        private static CompendiumData GetCompendiumData()
        {
            var allAncestries = GetProperties<Ancestry, Ancestries>();

            return new CompendiumData
            {
                Skills = GetProperties<Skill, Skills>(),
                Actions = GetProperties<Action, Actions>().OrderBy(x => x.Name).ToList(),
                Deeds = GetProperties<Deed, Deeds>(),
                Boons = GetProperties<Status, Boons>().OrderBy(x => x.Name).ToList(),
                Conditions = GetProperties<Status, Conditions>().OrderBy(x => x.Name).ToList(),
                Scars = GetProperties<Scar, Scars>(),

                Professions = GetProperties<Profession, Professions>().OrderBy(x => x.Order).ToList(),
                CommonAncestries = allAncestries.Where(x => x.AncestryType == AncestryType.Common).OrderBy(x => x.Order).ToList(),
                ExoticAncestries = allAncestries.Where(x => x.AncestryType == AncestryType.Exotic).OrderBy(x => x.Order).ToList(),

                Armors = GetProperties<Armor, Armors>().OrderBy(x => x.ArmorType).ThenBy(x => x.Name).ToList(),
                Shields = GetProperties<Shield, Shields>().OrderBy(x => x.Name).ToList(),
                Weapons = GetProperties<Weapon, Weapons>()
                    .OrderBy(x => x.Types.FirstOrDefault())
                    .ThenBy(x => x.Name)
                    .ToList(),
                Adornments = GetProperties<Adornment, Adornments>().OrderBy(x => x.Name).ToList(),

                Dangers = GetProperties<Danger, Dangers>().OrderBy(x => x.Name).ToList(),
            };
        }

        public static List<T> GetProperties<T, P>()
        {
            var properties = GetFields<T, P>();

            return properties;
        }

        private static List<T> GetFields<T, P>()
        {
            List<T> results = new List<T>();
            FieldInfo[] fields = typeof(P).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(T))
                {
                    T? instance = (T?)field.GetValue(null);
                    if (instance != null)
                    {
                        results.Add(instance);
                    }
                }
            }

            return results;
        }
    }
}
