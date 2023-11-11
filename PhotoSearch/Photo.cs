using System.Runtime.Serialization.Formatters;

namespace PhotoSearch
{
    public interface IPhoto
    {
        string ExportString();
        bool HasId(int inputId);
        bool HasAlbumId(int inputId);
    }

    public record Photo (int albumId, int id, string title, string url, string thumbnailUrl) : IPhoto
    {
        public string ExportString()
        {
            return $"[{id}] {title}";
        }

        public bool HasId(int inputId)
        {
            return (id == inputId);
        }

        public bool HasAlbumId(int inputId)
        {
            return (albumId == inputId);
        }
    }
}