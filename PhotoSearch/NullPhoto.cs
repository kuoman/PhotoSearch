namespace PhotoSearch;

public class NullPhoto : IPhoto
{
    public string ExportString()
    {
        return "Photo not found";
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