namespace Deedforge.Client.Helpers
{
    public class TableChildRowWrapper<T>
    {
        public bool ShowDetails { get; set; } = false;
        public T Item { get; set; }

        public TableChildRowWrapper(T item)
        {
            Item = item;
        }

        public void ToggleDetails()
        {
            ShowDetails = !ShowDetails;
        }
    }
}
