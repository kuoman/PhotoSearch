using System.Collections.Generic;
using System.Text;

namespace PhotoSearch;

public record Album(int AlbumId, List<Photo> albumPhotos)
{
    public string ExportString()
    {
        if (albumPhotos == null) return $"Album {AlbumId} not found";
        if (albumPhotos.Count == 0) return $"No photos in Album {AlbumId}";

        StringBuilder sb = new StringBuilder();
        sb.Append($"photo-album {AlbumId}");

        foreach (Photo photo in albumPhotos)
        {
            photo.ExportString(sb);
        }

        return sb.ToString();
    }
}