namespace Deedforge.Domain.Helpers
{
    public static class SetterHelper<T>
    {
        public static List<T> Set(params T[] items)
        {
            return new List<T>(items);
        }
    }
}
