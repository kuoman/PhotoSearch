namespace PhotoSearch
{
    public interface IPhoto
    {
        string ExportString();
    }

    public record Photo (int albumId, int id, string title, string url, string thumbnailUrl) : IPhoto
    {
        public string ExportString()
        {
            return $"[{id}] {title}";
        }
    }
}