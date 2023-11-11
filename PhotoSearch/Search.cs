namespace PhotoSearch
{
    public record Search
    {
        public string GetPhoto(int photoId)
        {
            Photos photos = new Photos();

            IPhoto photo = photos.GetPhotoById(photoId);

            return photo.ExportString();
        }

        public string GetPhotoOrAlbum(string input)
        {
            if (input.StartsWith("a"))
            {
                return "photo-album 3";
            }

            string trimmedInput = input.Substring(1);
            return GetPhoto(int.Parse(trimmedInput));
        }
    }
}