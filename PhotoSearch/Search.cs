namespace PhotoSearch
{
    public record Search
    {
        public string GetPhoto(int photoId)
        {

            PhotoData photoData = new PhotoData();

            Photo photo = photoData.GetPhotoById(photoId);

            return photo.ExportString();
        }
    }
}