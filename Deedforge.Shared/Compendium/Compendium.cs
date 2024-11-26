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

namespace Deedforge.Shared.Compendium
{
    public class Compendium
    {
        public static CompendiumData CompendiumData { get; set; } = GetCompendiumData();
            
        private static CompendiumData GetCompendiumData()
        {
            return new CompendiumData
            {
                Skills = GetProperties<Skill, Skills>(),
                Actions = GetProperties<Action, Actions>(),
                Deeds = GetProperties<Deed, Deeds>(),
                Boons = GetProperties<Status, Boons>(),
                Conditions = GetProperties<Status, Conditions>(),
                Scars = GetProperties<Scar, Scars>(),
                
                Professions = GetProperties<Profession, Professions>().OrderBy(x => x.Order).ToList(),

                Armors = GetProperties<Armor, Armors>(),
                Shields = GetProperties<Shield, Shields>(),
                Weapons = GetProperties<Weapon, Weapons>(),
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
