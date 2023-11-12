using System.Text;

namespace PhotoSearch;

public class NullPhoto : IPhoto
{
    public StringBuilder ExportString(StringBuilder stringBuilder)
    {
        return stringBuilder.Append("Photo not found");
    }

    public bool HasId(int inputId)
    {
        throw new System.NotImplementedException();
    }

    public bool HasAlbumId(int inputId)
    {
        throw new System.NotImplementedException();
    }
}