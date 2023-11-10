namespace PhotoSearch
{
    public record Photo (int albumId, int id, string title, string url, string thumbnailUrl)
    {
        public string ExportString()
        {
            return $"[{id}] {title}";
        }
    }
}