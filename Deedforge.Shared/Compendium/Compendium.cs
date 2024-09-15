using Deedforge.Domain.Adventuring;
using Deedforge.Domain.CharacterRules.Professions.Collection;
using Deedforge.Domain.CharacterRules.Professions;
using Deedforge.Domain.CoreRules.Attacking;
using Deedforge.Domain.CoreRules.Statuses;
using Deedforge.Domain.Gear;
using System.Reflection;

namespace Deedforge.Shared.Compendium
{
    public class Compendium
    {
        public static CompendiumData CompendiumData { get; set; } = GetCompendiumData();
            
        private static CompendiumData GetCompendiumData()
        {
            return new CompendiumData
            {
                Deeds = GetProperties<Deed, Deeds>(),
                Boons = GetProperties<Status, Boons>(),
                Conditions = GetProperties<Status, Conditions>(),
                MeleeAttacks = GetProperties<AttackForm, MeleeAttacks>(),
                Armors = GetProperties<Armor, Armors>(),
                Shields = GetProperties<Shield, Shields>(),
                Professions = GetProperties<Profession, Professions>().OrderBy(x => x.Order).ToList(),
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
                    T instance = (T)field.GetValue(null); // null because it's a static field
                    results.Add(instance);
                }
            }

            return results;
        }
    }
}
