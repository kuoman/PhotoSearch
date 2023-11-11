namespace PhotoSearch;

public class NullPhoto : IPhoto
{
    public string ExportString()
    {
        return "Photo not found";
    }
}