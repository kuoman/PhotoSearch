namespace PhotoSearch
{
    public record Search
    {
        public string GetPhoto(int photoId)
        {
            Photos photos = new Photos();

            Photo photo = photos.GetPhotoById(photoId);

            return photo.ExportString();
        }
    }
}