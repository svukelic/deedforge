namespace Deedforge.Shared.Compendium
{
    public interface IDataFetchService
    {
        Task<CompendiumData> GetCompendiumData();
    }
}
