using Deedforge.Domain.CoreRules.Attacking;
using Deedforge.Domain.Gear;
using Deedforge.Shared.Compendium;
using System.Reflection;

namespace Deedforge.Services
{
    public class DataFetchService : IDataFetchService
    {
        public async Task<CompendiumData> GetCompendiumData()
        {
            await Task.Yield();

            var data = new CompendiumData
            {
                MeleeAttacks = await GetProperties<AttackForm, MeleeAttacks>(),
                Armors = await GetProperties<Armor, Armors>(),
                Shields = await GetProperties<Shield, Shields>(),
            };

            return data;
        }

        public async Task<List<T>> GetProperties<T, P>()
        {
            await Task.Yield();

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
