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

        public string GetPhotoOrAlbum(string input)
        {
            string trimmedInput = input.Substring(1);
            return GetPhoto(int.Parse(trimmedInput));
        }
    }
}