using System;
using System.Text;

namespace PhotoSearch
{
    public interface IPhoto
    { 
        StringBuilder ExportString(StringBuilder stringBuilder);
        bool HasId(int inputId);
        bool HasAlbumId(int inputId);
    }

    public record Photo (int albumId, int id, string title, string url, string thumbnailUrl) : IPhoto
    {
        public StringBuilder ExportString(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine($"[{id}] {title}");
            stringBuilder.Append(Environment.NewLine);
            return stringBuilder;
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